      subroutine VR(wVRBox,hVRBox,mapBase,RGBBase,
     $ VRRange,rangeContour,relaMin,relaMax,VRValue,bulkGrav,
     $  VRMode,nNodeVRMask,xVRMask,flagMask)

      implicit none
      
      
	 !DEC$ ATTRIBUTES DLLEXPORT :: VR
	 !DEC$ ATTRIBUTES ALIAS:'VR' :: VR
	 !DEC$ ATTRIBUTES Reference :: 
     $ wVRBox,hVRBox,mapBase,RGBBase,VRRange,rangeContour,
     $ relaMin,relaMax,VRValue,bulkGrav,VRMode,nNodeVRMask,xVRMask,
     $ flagMask
      
     
      integer wVRBox,hVRBox,VRRange,VRMode,nNodeVRMask,flag
      
      byte flagMask(wVRBox,hVRBox),mapBase(wVRBox,hVRBox),
     $  RGBBase(4,wVRBox,hVRBox),toByte,RGBCell(4)
      
      real VRValue(wVRBox,hVRBox),VRCell
      
      double precision relaMax,relaMin,
     $   rangeContour(2),maxVR,minVR,relaValue,bulkGrav,xVRMask(10,2),
     $  areaMask
      
      integer iW,iH,jW,jH,pixCount,iPt,iCell,jCell,solidCount
      
      double precision xB,yB,xPA(10),yPA(10)
      
      
      ! VRMode=0 only calculate the density of this rectangular; 
      !         =1 plot contour;   =4 grayscale 
      !         =2 Calculate the void ratio of the masked area.
      !         =3 plot cell void ratio.  VRRange becomes the cell size.  =5 gray scale
      
      VRValue=0
      flagMask=0
      RGBBase(4,:,:)=-1
      
      
      do iW=1,wVRBox
         do iH=1,hVRBox
          
             if (RGBBase(1,iW,iH).ne.-1)  then
                mapBase(iW,iH)=1
             else
                mapBase(iW,iH)=0
             end if
          
         end do ! iH
      end do ! iW

      
      
      if (VRMode.eq.2) then   ! Check each pixle and see whether it is masked
      
        do iPt=1,10
        
            xPA(iPt)=xVRMask(iPt,1)
            yPA(iPt)=xVRMask(iPt,2)
        
        end do
        
        do iW=1,wVRBox
             do iH=1,hVRBox
          
             xB=iW*1.0
             yB=iH*1.0
             call PtPoly(xB,yB,nNodeVRMask,xPA,yPA,flag)
             flagMask(iW,iH)=flag
          
             end do ! iH
        end do ! iW
        
      end if
      
       
      if ((VRMode.eq.1).or.(VRMode.eq.4)) then
      
          do iW=1,wVRBox
          
             do iH=1,hVRBox
             
                pixCount=0
                
                do jW=max(1,iW-VRRange),min(wVRBox,iW+VRRange)
                   
                   do jH=max(1,iH-VRRange),min(hVRBox,iH+VRRange)
                   
                      pixCount=pixCount+1
                      VRValue(iW,iH)=VRValue(iW,iH)+mapBase(jW,jH)
                      
                   end do
                   
                end do
                
                VRValue(iW,iH)= VRValue(iW,iH)/pixCount
                
             end do
          
          end do
          
          relaMin=minval(VRvalue)
          relaMax=maxval(VRvalue)

          
             do iW=1,wVRBox
          
                do iH=1,hVRBox
                
                   relaValue=(VRValue(iW,iH)-rangeContour(1))/
     $             (rangeContour(2)-rangeContour(1))
         
                   relaValue=min(1.,max(0.,relavalue))
                   if (VRMode.eq.1) then
                    call BHSV2RGB(relaValue,RGBBase(:,iW,iH))
                   else
                    RGBBase(1:3,iW,iH)=tobyte(int(255-255*relaValue))
                   end if
                end do
          
             end do
          
          
          elseif ((VRMode.eq.3).or.(VRMode.eq.5)) then 
          
            do iCell=0,int(wVRBox/VRRange)
            
              do jCell=0,int(hVRBox/VRRange)
                
                pixCount=0
                solidCOunt=0 
                
                do iW=iCell*VRRange+1,min(iCell*VRRange+VRRange,wVRBox)
                
                do iH=jCell*VRRange+1,min(jCell*VRRange+VRRange,hVRBox)
                  
                  pixCount=pixCount+1
                  solidCount=solidCount+mapBase(iW,iH)
                
                end do
                end do
                
                if ((solidCount.ge.0).and.
     $            (solidCount.ge.0.5*pixCount)) then
     
                  VRCell=pixCount/(solidCount+0.0)-1
                  relaValue=(VRCell-rangeContour(1))/
     $             (rangeContour(2)-rangeContour(1))
         
                  relaValue=min(1.,max(0.,relavalue))
                  
                  if (VRMode.eq.3) then
                    call BHSV2RGB(relaValue,RGBCell)
                  else
                    RGBCell(1:3)=tobyte(int(255-255*relaValue))
                  end if
 
                  do iW=iCell*VRRange+1 , 
     $             min(iCell*VRRange+VRRange,wVRBox)
     
                  do iH=jCell*VRRange+1 , 
     $             min(jCell*VRRange+VRRange,hVRBox)
     
                  RGBBase(:,iW,iH)=RGBCell(:)
                  
                  end do
                  end do

                else 
                  RGBCell=255
                  do iW=iCell*VRRange+1 , 
     $             min(iCell*VRRange+VRRange,wVRBox)
     
                  do iH=jCell*VRRange+1 , 
     $             min(jCell*VRRange+VRRange,hVRBox)
     
                  RGBBase(:,iW,iH)=RGBCell(:)
                  
                  end do
                  end do

                  
                end if

                
              end do  !jCell
            end do  !iCell
      

        else if (VRMode.eq.0) then
          
          bulkGrav=0
          do iW=1,wVRBox
          
             do iH=1,hVRBox
             
                 bulkGrav=bulkGrav+mapBase(iW,iH)
                      
                                 
             end do
          
          end do
          
          bulkGrav=bulkGrav/(wVRBox*hVRBox)
       
       
          
       else if (VRMode.eq.2) then
       
           bulkGrav=0
           areaMask=0
           
          do iW=1,wVRBox
          
             do iH=1,hVRBox
             
                 if (flagMask(iW,iH).eq.1) then 
                 
                    bulkGrav=bulkGrav+mapBase(iW,iH)
                    areaMask=areaMask+1
                    
                    RGBBase(3,iW,iH)=tobyte(255-255*mapBase(iW,iH))
                    RGBBase(2,iW,iH)=tobyte(255-130*mapBase(iW,iH))
                    RGBBase(1,iW,iH)=tobyte(255-200*mapBase(iW,iH))
                 
                 else
                 
                    RGBBase(3,iW,iH)=tobyte(255-95*mapBase(iW,iH))
                    RGBBase(2,iW,iH)=tobyte(255-190*mapBase(iW,iH))
                    RGBBase(1,iW,iH)=tobyte(255-240*mapBase(iW,iH))
              
                 end if
             
                                 
             end do
          
          end do
          
          bulkGrav=bulkGrav/max(areaMask,0.00001)
         end if
      

      
      
      end subroutine
            