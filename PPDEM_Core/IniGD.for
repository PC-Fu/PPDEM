      Subroutine IniGD(nEle,xEle,yEle,rEle,qEle,nVertex,xVertex,
     $	yVertex,limitAll,nGridX,nGridY,nEleGrid,lEG,
     $	wCellGD,xGrid,maxNEleGrid,nHLine,nVLine,
     $   nHPtGD,nVPtGD,iHElePtGD,iVElePtGD,rqiHPtGD,rqiVPtGD,
     $   xHPtGD,xVPtGD, flagDyeGrid)
     
     
      !Initiate grid for deformation measurement.
      ! nHPtGD, nVPtGD (iLine)
      ! iHElePtGD, iVElePtGD(iLine, iPt)
      ! rqiHPtGD, rqiVPtGD(iLine,iPt,2)
      ! xHPtGD, xVPtGD(iLine, iPt,2)
      
      Implicit none
      !DEC$ ATTRIBUTES DLLEXPORT :: IniGD
	!DEC$ ATTRIBUTES ALIAS:'IniGD' :: IniGD
	 !DEC$ ATTRIBUTES Reference :: 
     $ nEle,xEle,yEle,rEle,qEle,nVertex,xVertex,
     $	yVertex,limitAll,nGridX,nGridY,nEleGrid,lEG,
     $	wCellGD,xGrid,maxNEleGrid,nHLine,nVLine,
     $   nHPtGD,nVPtGD,iHElePtGD,iVElePtGD,rqiHPtGD,rqiVPtGD,
     $   xHPtGD,xVPtGD, flagDyeGrid
     
     
	integer nEle,nGridX,nGridY,maxNEleGrid,nHLine,nVLine
	double precision xEle(nEle),yEle(nEle),rEle(nEle),qEle(nEle),
     $	xVertex(nEle,10),yVertex(nEle,10),limitAll(4),wCellGD,xGrid

	integer lEG(nGridX,nGridY,maxNEleGrid),nEleGrid(nGridX,nGridY)

	double precision yLineH,xLineV
	
	integer i,iCol,iRow,iEle,jEle,iLine,flagInter,flagDyeGrid(nEle)
	
	integer nVertex(nEle),nHPtGD(nHLine),nVPtGD(nVLine),
     $   iHElePtGD(nHLine,1000),iVElePtGD(nVLine,1000)
     
      double precision rqiHPtGD(nHLine,1000,2)
     $   ,rqiVPtGD(nVLine,1000,2),
     $   xHPtGD(nHLine,1000,2),xVPtGD(nVLine,1000,2)

	double precision xCfPt(2,2),cosq,sinq
	
	double precision ASinCos
	
	
	nHPtGD(nHLine)=0
	nVPtGD(nVLine)=0
	flagDyeGrid=0
	
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!  Horizontal Lines  !!!!!!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

	do iLine=1,nHLine
	
	   yLineH=limitAll(3)+wCellGD*(iLine-1)
	   
	   do iRow=max(1,int((yLineH-limitAll(3))/xGrid)),
     $			min(nGridY,int((yLineH-limitAll(3))/xGrid)+2)
				
			do iCol=1,nGridX
			
		      do iEle=1,nEleGrid(iCol,iRow)
		         jEle=lEG(iCol,iRow,iEle)
			   	if ( ( (yEle(jEle)+rEle(jEle)).gt.yLineH ).and.
     $			   	  ( (yEle(jEle)-rEle(jEle)).lt.yLineH )) then
     
					   Call CfPt(yLineH,jEle,nEle,xEle,yEle,rEle,
     $					   nVertex,xVertex,yVertex,xCfPt,1,flagInter)	
     				      
         		      if (flagInter.eq.1) then
         		      
         		        flagDyeGrid(jEle)=1

                        do i=1,2 
                           
                           nHPtGD(iLine)=nHPtGD(iLine)+1
                           iHElePtGD(iLine,nHPtGD(iLine))=jEle
                           xHPtGD(iLine,nHPtGD(iLine),1)=xCfPt(i,1)
                           xHPtGD(iLine,nHPtGD(iLine),2)=xCfPt(i,2)
                           rqiHPtGD(iLine,nHPtGD(iLine),1)=Dsqrt(
     $                        (xEle(jEle)-xCfPt(i,1))**2+
     $                        (yEle(jEle)-xCfPt(i,2))**2)
     
                           cosq=(xCfPt(i,1)-xEle(jEle))/
     $                        rqiHPtGD(iLine,nHPtGD(iLine),1)
                           sinq= xCfPt(i,2)-yEle(jEle)
                           
                           rqiHPtGD(iLine,nHPtGD(iLine),2)=ASinCos(
     $                        cosq,sinq)            
                           
                           rqiHPtGD(iLine,nHPtGD(iLine),2)=
     $                       rqiHPtGD(iLine,nHPtGD(iLine),2)-qEle(jEle)

                        end do 
                     
					   end if
					
				   end if  ! yLineH is within the y limits of this element
					
			   end do	!iEle=1,nEleGrid(iCol,iRow)
			   
			end do  ! iCol
			
		end do  ! iRow=max(1,int(yPx/wCellGD)),min(nGridY,int(yPx/wCellGD))+2)

	call SortGDLine(nHPtGD(iLine),iHElePtGD(iLine,:),
     $	rqiHPtGD(iLine,:,:),xHPtGD(iLine,:,:),1)
	
	end do  ! iLine=1,nHLine
	
	
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!  Vertical Lines  !!!!!!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

	do iLine=1,nVLine
	
	   xLineV=limitAll(1)+wCellGD*(iLine-1)
	   
	   do iCol=max(1,int((xLineV-limitAll(1))/xGrid)),
     $			min(nGridx,int((xLineV-limitAll(1))/xGrid)+2)
				
			do iRow=1,nGridY
			
		      do iEle=1,nEleGrid(iCol,iRow)
		         jEle=lEG(iCol,iRow,iEle)
			   	if ( ( (xEle(jEle)+rEle(jEle)).gt.xLineV ).and.
     $			          ( (xEle(jEle)-rEle(jEle)).lt.xLineV )) then
     
					   Call CfPt(xLineV,jEle,nEle,xEle,yEle,rEle,
     $					   nVertex,xVertex,yVertex,xCfPt,2,flagInter)	
     				      
         		      if (flagInter.eq.1) then
         		      
         		        flagDyeGrid(jEle)=1

                        do i=1,2
                           
                           nVPtGD(iLine)=nVPtGD(iLine)+1
                           iVElePtGD(iLine,nVPtGD(iLine))=jEle
                           xVPtGD(iLine,nVPtGD(iLine),1)=xCfPt(i,1)
                           xVPtGD(iLine,nVPtGD(iLine),2)=xCfPt(i,2)
                           rqiVPtGD(iLine,nVPtGD(iLine),1)=Dsqrt(
     $                        (xEle(jEle)-xCfPt(i,1))**2+
     $                        (yEle(jEle)-xCfPt(i,2))**2)
     
                           cosq=(xCfPt(i,1)-xEle(jEle))/
     $                        rqiVPtGD(iLine,nVPtGD(iLine),1)
                           sinq= xCfPt(i,2)-yEle(jEle)
                           
                           rqiVPtGD(iLine,nVPtGD(iLine),2)=ASinCos(
     $                        cosq,sinq)            
                           
                           rqiVPtGD(iLine,nVPtGD(iLine),2)=
     $                       rqiVPtGD(iLine,nVPtGD(iLine),2)-qEle(jEle)

                        end do 
                     
					   end if
					
				   end if  ! yLineH is within the y limits of this element
					
			   end do	!iEle=1,nEleGrid(iCol,iRow)
			   
			end do  ! iCol
			
		end do  ! iRow=max(1,int(yPx/wCellGD)),min(nGridY,int(yPx/wCellGD))+2)

	   call SortGDLine(nVPtGD(iLine),iVElePtGD(iLine,:),
     $	rqiVPtGD(iLine,:,:),xVPtGD(iLine,:,:),2)

	end do  ! iLine=1,nHLine	
	
      end subroutine