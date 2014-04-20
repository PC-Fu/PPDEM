      subroutine Histogram(nEle,nActEle,xEle,yELe,mInertEle,qEle,
     $   iniOri,Ori,elong,nVertex,nCon,xCon,yCon,FxCon,FyCon,FCon,
     $   flagConBoun,FAngle,fricRatio,tanNorm,qNorm,nNodeMask,Mask,
     $   BinForce,BinOri,BinFR,BinNorm,BinSlideNorm,iHistMode,
     $   iWeight,jWeight,iBoundMode,flagFMask,flagEMask,nBinForce,
     $   nBinOri,nBinFR,nBinNorm,ptBinF,ptBinE,ptBinFR,ptBinNorm,
     $   ptBinSlideNorm,
     $   tsFabric,tsStress,tsConNorm,numContact,pairCon,flagOutput,
     $   vol,iCurStep,ptcStress,nEleMaskOut,fctSldNorm,scalePolar)
     
      implicit none    
     
       !DEC$ ATTRIBUTES DLLEXPORT :: Histogram
	 !DEC$ ATTRIBUTES ALIAS:'Histogram' :: Histogram
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,nActEle,xEle,yELe,mInertEle,qEle,
     $   iniOri,Ori,elong,nVertex,nCon,xCon,yCon,FxCon,FyCon,FCon,
     $   flagConBoun,FAngle,fricRatio,tanNorm,qNorm,nNodeMask,Mask,
     $   BinForce,BinOri,BinFR,BinNorm,BinSlideNorm,iHistMode,
     $   iWeight,jWeight,iBoundMode,flagFMask,flagEMask,nBinForce,
     $   nBinOri,nBinFR,nBinNorm,ptBinF,ptBinE,ptBinFR,ptBinNorm,
     $   ptBinSlideNorm,
     $   tsFabric,tsStress,tsConNorm,numContact,pairCon,flagOutput,
     $   vol,iCurStep,ptcStress,nEleMaskOut,fctSldNorm,scalePolar
	 
	 
	 
	integer nEle,nCon,nBinForce,nBinOri,nBinFR,nBinNorm,i,iCurStep(4) 

	double precision xEle(nEle),yEle(nEle),mInertEle(nEle),qEle(nEle),
     $   iniOri(nEle),Ori(nEle),xCon(nEle*10),yCon(nEle*10),
     $	 FxCon(nEle*10),FyCon(nEle*10),FCon(nEle*10),FAngle(nEle*10),
     $   xPA(10),yPA(10),elong(nEle),fricRatio(nEle*10),
     $   tanNorm(nEle*10),qNorm(nEle*10),areaMask,vol,ptcStress(nEle,6)
     
      double precision BinForce(nBinForce),BinOri(nBinOri),
     $   BinFR(nBinFR),BinNorm(nBinNorm),BinSlideNorm(nBinNorm),
     $   maxBinF,maxBinE,
     $   binFIntv,binEIntv,binFRIntv,maxBinFR,maxBinNorm,
     $   binNormIntv,fctSldNorm
      
      integer nActEle,nNodeMask,Mask(10),iEle,iCon,iBin,jBin,
     $   pairCon(nEle*10,2),nEleMaskOut   !nEleMask is sometimes used as the summation of the weight factors
      
      
      integer iHistMode,iWeight,jWeight,iNode,flagFMask(nEle*10),
     $ flagEMask(nEle),nVertex(nEle),ptBinF(nBinForce*4,2),
     $ ptBinE(nBinOri*4,2),ptBinNorm(nBinNorm*4,2),
     $ ptBinSlideNorm(nBinNorm*4,2),ptBinFR(nBinFR,4),
     $ flagConBoun(nEle*10),iBoundMode,flagOutput
     
      real scalePolar
      
      !! iWeight=1: fabric weighted by the mass of the particle and (elongation-1); contact normal and contact force weighted by the magitude of force
      !! iWeight=0, not weighted
      !! jWeight: additional weight for fabric tensor and histogram.  =0 no weight; =1 weight by stress XX; =2 weight by stress XY; =4 weight by stressYY; =5 weight by bulk stress; =6 weight by max shear stress
      !! although is weight by stress, because mass as already included in the weight, the total weight is actually force.
      !! iHistMode = 0 for global; =1 for masked.
      !! iBoundMode = 0 if excluding boundary contacts (flagConBoun=1 or 2); =1 if including boundary contacts
      !! flagOutput = 0 if this operation is for screen display; =1 or 2 is for output, 2 with a line break
      
      double precision tsFabric(4),tsStress(8),tsConNorm(4),numContact
     $ ,nEleMask,temp,temp1,temp2
      !!! One dimension vector for 2D tensor, 1=11,2=12,3=21,4=22
      !!! tsStress has eight component.  1-4 by boundary summation, and 5-8 by body summation.
      
      
      FCon=0
      Ori=0
      BinForce=0
      BinOri=0
      BinFR=0
      BinNorm=0
      BinSlideNorm=0
      binFIntv=3.142/nBinForce  ! This number should be slightly bigger than pi
      binEIntv=3.142/nBinOri
      binNormIntv=3.142/nBinNorm
      binFRIntv=0.9999999/(nBinFR-1)   ! FR values greater than 0.9999 fall into the last bin
      tsFabric=0
      tsStress=0
      tsConNorm=0
      numContact=0
      areaMask=vol   ! if iHistMode=0, no mask, use areaMask=1, and devide the tensors by the total volume in the vb code
      nEleMask=0
      maxBinE=0
      maxBinF=0
      maxBinFR=0
      maxBinNorm=0
 
 
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!     
      !!!!!!!! Initialize the mask.                          !!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      if ((iHistMode.eq.1).and.(nNodeMask.gt.0)) then   !Masked
         do iNode=1,nNodeMask
            xPA(iNode)=xEle(Mask(iNode))
            yPA(iNode)=yEle(Mask(iNode))
         end do
         xPA(nNodeMask+1)=xEle(Mask(1))
         yPA(nNodeMask+1)=yEle(Mask(1))
         
         areaMask=0
         do iNode=1,nNodeMask
            areaMask=areaMask+xPA(iNode)*yPA(iNode+1)
     $       -xPA(iNode+1)*yPA(iNode)
         end do
         
         areaMask=areaMask/2
      
      end if
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!     
      !!!!!!!! Calculate the orientation of each particle   !!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      do iEle=1,nActEle
      
         ori(iEle)=mod(iniOri(iEle)+qEle(iELe),3.1416)
      
         if (ori(iEle).lt.0) then
            ori(iEle)=ori(iEle)+3.1416
         end if
      
      end do

      !!!Temporarily calculate a vector for paper following Curry 1956
      !temp=0
      !temp1=0
      !temp2=0
      !do iEle=1,nActEle
      !temp1=sin(2*ori(iEle))+temp1
      !temp2=cos(2*ori(iEle))+temp2
      
      !end do
      !temp=sqrt(temp1**2+temp2**2)
      !temp=temp/nActEle
    

      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!     
      !!!!!!!! Calculate the orientation of each force and each contact norm   !!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      do iCon=1,nCon
      
         FCon(iCon)=sqrt(FxCon(iCon)**2+FyCon(iCon)**2)
         
         if (abs(FCon(iCon)).gt.1e-6) then
            if (abs(FxCon(iCon)).lt.0.01*abs(FyCon(iCon))) then
                FAngle(iCon)=1.57
            else
                FAngle(iCon)=atan(FyCon(iCon)/FxCon(iCon))
            end if
         end if
         
         if (FAngle(iCon).lt.0) then
            FAngle(iCon)=FAngle(iCon)+3.1416
         end if
         
         qNorm(iCon)=atan(tanNorm(iCon))
 
          if (qNorm(iCon).lt.0) then
            qNorm(iCon)=qNorm(iCon)+3.1416
         end if
     
      end do
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!     
      !!!!!!!! Judge whether each element is masked   !!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      do iEle=1,nActEle
         
         
          if (iHistMode.eq.0) then

               flagEMask(iEle)=1

          else
          
             call PtPoly(xEle(iEle),yEle(iEle),nNodeMask,
     $           xPA,yPA,flagEMask(iEle))
          
          end if
          
          
          nEleMask=nEleMask+flagEMask(iEle)
     
         
      end do
      
      nEleMaskOut=nEleMask
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!     
      !!!!!!!! Judge whether each force is masked   !!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
         
      do iCon=1,nCon
      
         if (iHistMode.eq.0) then
               flagFMask(iCon)=1
         else
            call PtPoly(xCon(iCon),yCon(iCon),nNodeMask,
     $        xPA,yPA,flagFMask(iCon))
         end if
         
         if ((iBoundMode.eq.0).and.(flagConBoun(iCon).gt.0)) then  ! if excluding boundary forces
         
            flagFMask(iCon)=0
         
         end if
         
      end do
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!Calculate the coordination number !!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      do iCon=1,nCon
      
      
        if ( (flagConBoun(iCon).eq.0) .and. 
     $     (flagEMask(pairCon(iCon,1)).eq.1) ) then
        
            numContact=numContact+1
        
        end if
        
        if ( (flagConBoun(iCon).eq.0) .and. 
     $     (flagEMask(pairCon(iCon,2)).eq.1) ) then
        
            numContact=numContact+1
        
        end if

        if ( (flagConBoun(iCon).eq.2) .and. 
     $     (flagEMask(pairCon(iCon,1)).eq.1) ) then
        
            numContact=numContact+1
        
        end if
        
      end do
      
      numContact=numContact/nEleMask      
      
      
     
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!Calculate the fabric tensor !!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      tsFabric=0
      nEleMask=0
      do iEle=1,nActEle
         
         if (flagEMask(iEle).eq.1) then
            
            if (iWeight.eq.0) then
               if (nVertex(iEle).gt.0) then
                  tsFabric(1)=tsFabric(1)+cos(ori(iEle))**2
                  tsFabric(2)=tsFabric(2)+
     $               cos(ori(iEle))*cos(ori(iEle)-1.571)
                  tsFabric(3)=tsFabric(2)
                  tsFabric(4)=tsFabric(4)+cos(ori(iEle)-1.571)**2
                  
                  nEleMask=nEleMask+1

               end if
            else 
               if (nVertex(iEle).gt.0) then
               

                  tsFabric(1)=tsFabric(1)+cos(ori(iEle))**2
     $               *(elong(iEle)-1)*mInertEle(iEle)
     $               *(min(jWeight,1)*ptcStress(iEle,max(jWeight,1))
     $               +max((1-jWeight),0))
     
                  tsFabric(2)=tsFabric(2)+
     $               cos(ori(iEle))*cos(ori(iEle)-1.571)
     $               *(elong(iEle)-1)*mInertEle(iEle)
     $               *(min(jWeight,1)*ptcStress(iEle,max(jWeight,1))
     $               +max((1-jWeight),0))
     
                  tsFabric(3)=tsFabric(2)
     
                  tsFabric(4)=tsFabric(4)+cos(ori(iEle)-1.571)**2
     $               *(elong(iEle)-1)*mInertEle(iEle)
     $               *(min(jWeight,1)*ptcStress(iEle,max(jWeight,1))
     $               +max((1-jWeight),0))
     
                  nEleMask=nEleMask+(elong(iEle)-1)*mInertEle(iEle)
     $               *(min(jWeight,1)*ptcStress(iEle,max(jWeight,1))
     $               +max((1-jWeight),0))
     
               end if
            end if
         
         end if
         
      end do
      
      tsFabric=tsFabric/nEleMask
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!Calculate the contact normal tensor !!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

      nEleMask=0
      do iCon=1,nCon
        if (((flagConBoun(iCon).eq.0).or.(flagConBoun(iCon).eq.2)).and.
     $      (flagFMask(iCon).eq.1)) then
     
           tsConNorm(1)=tsConNorm(1)+cos(atan(tanNorm(iCon)))**2
           tsConNorm(2)=tsConNorm(2)+
     $         cos(atan(tanNorm(iCon)))*cos(atan(tanNorm(iCon))-1.571)
           tsConNorm(3)=tsConNorm(2)
           tsConNorm(4)=tsConNorm(4)+cos(atan(tanNorm(iCon))-1.571)**2
                  
           nEleMask=nEleMask+1


        end if  
      
      
      end do
      
      
      tsConNorm=tsConNorm/nEleMask
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!  Create the histograms.  Not executed if flagOutput=1
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      if (flagOutput.eq.0) then 
          
          do iEle=1,nActEle
             
             if (flagEMask(iEle).eq.1) then
                
                if (iWeight.eq.0) then
                   if (nVertex(iEle).gt.0) then
                    BinOri(int(ori(iEle)/binEIntv)+1)=
     $                BinOri(int(ori(iEle)/binEIntv)+1)+1
                   end if
                else 
                   if (nVertex(iEle).gt.0) then
                    BinOri(int(ori(iEle)/binEIntv)+1)=
     $                  BinOri(int(ori(iEle)/binEIntv)+1)
     $                  +(elong(iEle)-1)*mInertEle(iEle)
     $                  *(min(jWeight,1)*ptcStress(iEle,max(jWeight,1))
     $                  +max((1-jWeight),0))
     
     
                   end if
                end if
             
             end if
             
          end do
          
          
          do iCon=1,nCon
          
             if (flagFMask(iCon).eq.1) then
                
                if (iWeight.eq.0) then
                   BinForce(int(FAngle(iCon)/binFIntv)+1)=
     $              BinForce(int(FAngle(iCon)/binFIntv)+1)+1
         
                   BinNorm(int(qNorm(iCon)/binNormIntv)+1)=
     $              BinNorm(int(qNorm(iCon)/binNormIntv)+1)+1
     
        
                   if (fricRatio(iCon).gt.0.9999999) then
                      BinSlideNorm(int(qNorm(iCon)/binNormIntv)+1)=
     $                BinSlideNorm(int(qNorm(iCon)/binNormIntv)+1)+1
                   end if 
         
                else 
                   BinForce(int(FAngle(iCon)/binFIntv)+1)=
     $              BinForce(int(FAngle(iCon)/binFIntv)+1)
     $              +abs(FCon(iCon))
         
                   BinNorm(int(qNorm(iCon)/binNormIntv)+1)=
     $              BinNorm(int(qNorm(iCon)/binNormIntv)+1)
     $              +abs(FCon(iCon))
     

                   if (fricRatio(iCon).gt.0.9999999) then
                      BinSlideNorm(int(qNorm(iCon)/binNormIntv)+1)=
     $                BinSlideNorm(int(qNorm(iCon)/binNormIntv)+1)
     $                +abs(FCon(iCon))
                   end if 

                end if
                
             end if
          end do
          
          
          do iCon=1,nCon
          
             if (flagFMask(iCon).eq.1) then
                
                if (iWeight.eq.0) then
                   BinFR(int(fricRatio(iCon)/binFRIntv)+1)=
     $               BinFR(int(fricRatio(iCon)/binFRIntv)+1)+1
        
                else 
                   BinFR(int(fricRatio(iCon)/binFRIntv)+1)=
     $               BinFR(int(fricRatio(iCon)/binFRIntv)+1)
     $              +abs(FCon(iCon))
                end if
                
             end if
          end do

          do iBin=1,nBinOri
              maxBinE=maxBinE+binOri(iBin)**2
          end do
          do iBin=1,nBinForce
              maxBinF=maxBinF+binForce(iBin)**2
          end do
          do iBin=1,nBinNorm
              maxBinNorm=maxBinNorm+binNorm(iBin)**2
          end do
          do iBin=1,nBinFR
              maxBinFR=maxBinFR+binFR(iBin)*250/nBinFR
          end do
          
          maxBinE=max(maxBinE,0.0000001)
          maxBinF=max(maxBinF,0.0000001)
          maxBinFR=max(maxBinFR,0.0000001)
          maxBinNorm=max(maxBinNorm,0.0000001)
          
          maxBinE=240**2/scalePolar/maxBinE
          maxBinNorm=240**2/scalePolar/maxBinNorm
          maxBinF=240**2/scalePolar/maxBinF
          maxBinFR=70**2/scalePolar/maxBinFR
          
          
          BinOri=BinOri*sqrt(MaxBinE)
          BinForce=BinForce*sqrt(MaxBinF)
          BinFR=BinFR*maxBinFR
          BinNorm=BinNorm*sqrt(MaxBinNorm)
          BinSlideNorm=BinSlideNorm*sqrt(MaxBinNorm)*fctSldNorm
          
          
          do jBin=1,nBinForce*2
          
            if (jBin.gt.nBinForce) then
                iBin=jBin-nBinForce
            else
                iBin=jBin
            end if
          
            ptBinF(jBin*2-1,1)=BinForce(iBin)*cos(binFIntv*(jBin-1))+150
            ptBinF(jBin*2,1)=BinForce(iBin)*cos(binFIntv*jBin)+150
            ptBinF(jBin*2-1,2)=164-BinForce(iBin)*sin(binFIntv*(jBin-1))
            ptBinF(jBin*2,2)=164-BinForce(iBin)*sin(binFIntv*jBin)
             
          
          end do
          
          do jBin=1,nBinOri*2
          
            if (jBin.gt.nBinOri) then
                iBin=jBin-nBinOri
            else
                iBin=jBin
            end if
            
            
             ptBinE(jBin*2-1,1)=BinOri(iBin)*cos(binEIntv*(jBin-1))+150
             ptBinE(jBin*2,1)=BinOri(iBin)*cos(binEIntv*(jBin))+150
             ptBinE(jBin*2-1,2)=164-BinOri(iBin)*sin(binEIntv*(jBin-1))
             ptBinE(jBin*2,2)=164-BinOri(iBin)*sin(binEIntv*jBin)
             
          
          end do

          do jBin=1,nBinNorm*2
          
            if (jBin.gt.nBinNorm) then
                iBin=jBin-nBinNorm
            else
                iBin=jBin
            end if

          
             ptBinNorm(jBin*2-1,1)=
     $              BinNorm(iBin)*cos(binNormIntv*(jBin-1))+150
             ptBinNorm(jBin*2,1)=BinNorm(iBin)
     $          *cos(binNormIntv*(jBin))+150
             ptBinNorm(jBin*2-1,2)=
     $              164-BinNorm(iBin)*sin(binNormIntv*(jBin-1))
             ptBinNorm(jBin*2,2)=164-BinNorm(iBin)*sin(binNormIntv*jBin)
             

             ptBinSlideNorm(jBin*2-1,1)=
     $              BinSlideNorm(iBin)*cos(binNormIntv*(jBin-1))+150
             ptBinSlideNorm(jBin*2,1)=BinSlideNorm(iBin)
     $          *cos(binNormIntv*(jBin))+150
             ptBinSlideNorm(jBin*2-1,2)=
     $              164-BinSlideNorm(iBin)*sin(binNormIntv*(jBin-1))
             ptBinSlideNorm(jBin*2,2)=
     $              164-BinSlideNorm(iBin)*sin(binNormIntv*jBin)
          
          end do


          do iBin=1,nBinFR
          
             ptBinFR(iBin,1)=250.0/nBinFR*(iBin-1)
             ptBinFR(iBin,2)=164-BinFR(iBin)
             ptBinFR(iBin,3)=250.0/nBinFR
             ptBinFR(iBin,4)=BinFR(iBin)
             
          
          end do
      
      end if
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!Calculate the stress tensor by body summation!!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

      
      do iCon=1,nCon
      

            if ((flagConBoun(iCon).eq.0) .and. 
     $      (flagEMask(pairCon(iCon,1)).eq.1).and.
     $      (flagEMask(pairCon(iCon,2)).eq.1)) then
     
                tsStress(5)=tsStress(5) + FxCon(iCon)*
     $             (xEle(pairCon(iCon,1))-xEle(pairCon(iCon,2)))
     
                tsStress(6)=tsStress(6) + FyCon(iCon)*
     $             (xEle(pairCon(iCon,1))-xEle(pairCon(iCon,2)))
     
                tsStress(7)=tsStress(7) + FxCon(iCon)*
     $             (yEle(pairCon(iCon,1))-yEle(pairCon(iCon,2)))
     
                tsStress(8)=tsStress(8) + FyCon(iCon)*
     $             (yEle(pairCon(iCon,1))-yEle(pairCon(iCon,2)))
            
            else if ((flagConBoun(iCon).eq.0) .and. 
     $      (flagEMask(pairCon(iCon,1)).eq.1).and.
     $      (flagEMask(pairCon(iCon,2)).eq.0)) then
     
                tsStress(5)=tsStress(5) + FxCon(iCon)*
     $             (xEle(pairCon(iCon,1))-xCon(iCon))
                tsStress(6)=tsStress(6) + FyCon(iCon)*
     $             (xEle(pairCon(iCon,1))-xCon(iCon))
                tsStress(7)=tsStress(7) + FxCon(iCon)*
     $             (yEle(pairCon(iCon,1))-yCon(iCon))
                tsStress(8)=tsStress(8) + FyCon(iCon)*
     $             (yEle(pairCon(iCon,1))-yCon(iCon))
     
            else if ((flagConBoun(iCon).eq.0) .and. 
     $      (flagEMask(pairCon(iCon,1)).eq.0).and.
     $      (flagEMask(pairCon(iCon,2)).eq.1)) then
     
                tsStress(5)=tsStress(5) + FxCon(iCon)*
     $             (xCon(iCon)-xEle(pairCon(iCon,2)))
                tsStress(6)=tsStress(6) + FyCon(iCon)*
     $             (xCon(iCon)-xEle(pairCon(iCon,2)))
                tsStress(7)=tsStress(7) + FxCon(iCon)*
     $             (yCon(iCon)-yEle(pairCon(iCon,2)))
                tsStress(8)=tsStress(8) + FyCon(iCon)*
     $             (yCon(iCon)-yEle(pairCon(iCon,2)))

            else if ((flagConBoun(iCon).gt.0) .and. 
     $      (flagEMask(pairCon(iCon,1)).eq.1)) then
     
                tsStress(5)=tsStress(5) + FxCon(iCon)*
     $             (xEle(pairCon(iCon,1))-xCon(iCon))
                tsStress(6)=tsStress(6) + FyCon(iCon)*
     $             (xEle(pairCon(iCon,1))-xCon(iCon))
                tsStress(7)=tsStress(7) + FxCon(iCon)*
     $             (yEle(pairCon(iCon,1))-yCon(iCon))
                tsStress(8)=tsStress(8) + FyCon(iCon)*
     $             (yEle(pairCon(iCon,1))-yCon(iCon))

            end if

      
      end do




      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!Calculate the stress tensor by boudary summation!!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      do iCon=1,nCon
        
        if (((flagConBoun(iCon).eq.0) .and. 
     $  (flagEMask(pairCon(iCon,1)).eq.1).and.
     $  (flagEMask(pairCon(iCon,2)).eq.0)) 
     $  .or. 
     $  ((flagConBoun(iCon).gt.0).and.
     $  (flagEMask(pairCon(iCon,1)).eq.1))) then
        !! If (the contact is a E-E contact and only one of the two elements is in the mask) or (this contact is a bounary contact and the element is in the mask)
        
        tsStress(1)=tsStress(1) - xCon(iCon)*FxCon(iCon)
        tsStress(2)=tsStress(2) - xCon(iCon)*FyCon(iCon)
        tsStress(3)=tsStress(3) - yCon(iCon)*FxCon(iCon)
        tsStress(4)=tsStress(4) - yCon(iCon)*FyCon(iCon)
        
        flagFMask(iCon)=1   !  Temporary debug.  See which forces are included in stress calculation.
        
        else if ((flagConBoun(iCon).eq.0) .and. 
     $  (flagEMask(pairCon(iCon,1)).eq.0).and.
     $  (flagEMask(pairCon(iCon,2)).eq.1)) then
        
        tsStress(1)=tsStress(1) + xCon(iCon)*FxCon(iCon)
        tsStress(2)=tsStress(2) + xCon(iCon)*FyCon(iCon)
        tsStress(3)=tsStress(3) + yCon(iCon)*FxCon(iCon)
        tsStress(4)=tsStress(4) + yCon(iCon)*FyCon(iCon)
        
        flagFMask(iCon)=1
        
        else
        
        flagFMask(iCon)=0
        end if   
      end do
      
        tsStress=tsStress/areaMask

        
      if (flagOutput.eq.1) then
        write (3000,'(4E14.6,"   *   ",$)') 
     $   (tsFabric(i),i=1,4)
      else if (flagOutput.eq.2) then
        write (3000,'(4E14.6)')
     $   (tsFabric(i),i=1,4)
        write (3000,'(I8,$)') iCurStep(1)+1
      end if

      if (flagOutput.eq.1) then
        write (4000,'(4E14.6,"   *   ",$)')
     $   (tsStress(i+4),i=1,4)
      else if (flagOutput.eq.2) then
        write (4000,'(4E14.6)')
     $  ( tsStress(i+4),i=1,4)
        write (4000,'(I8,$)') iCurStep(1)+1
      end if

        flagOutput=0
        
      end subroutine
      
       
