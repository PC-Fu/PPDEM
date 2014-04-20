	subroutine RConfinement(nEle,xEle,yEle,rEle,nVertex,xVertex,
     $	yVertex,boundEle,limitAll,pInt,nPCon,pPlot,FxC,FyC,FMC,
     $	nGridX,nGridY,nEleGrid,lEG,xGrid,maxNEleGrid,vol,pairCon, 
     $  PStress)

	implicit none
	
	 !DEC$ ATTRIBUTES DLLEXPORT :: RConfinement
	 !DEC$ ATTRIBUTES ALIAS:'RConfinement' :: RConfinement
	 !DEC$ ATTRIBUTES Reference :: 
     $  nEle,xEle,yEle,rEle,nVertex,xVertex,
     $	yVertex,boundEle,limitAll,pInt,nPCon,pPlot,FxC,FyC,FMC,
     $	nGridX,nGridY,nEleGrid,lEG,xGrid,maxNEleGrid,vol,pairCon

	integer nEle,nPcon,nGridX,nGridY,maxNEleGrid
	double precision xEle(nEle),yEle(nEle),rEle(nEle),
     $	xVertex(nEle,10),yVertex(nEle,10),boundEle(nEle,4),limitAll(4),
     $	xGrid, PStress(2)


	integer lEG(nGridX,nGridY,maxNEleGrid),nEleGrid(nGridX,nGridY)

	double precision pInt,pPlot(nEle*10,4),y0Px,x0Py,yPx,xPy
	
	integer nVertex(nEle),nPx,nPy,iPx,iPy,iCol,iRow,flagFound,iEle,
     $	iEletemp,flagInter,pairCon(nEle*10,2)

	double precision FxC(nEle),FyC(nELe),FMC(nEle)
	! FxC, FyC, FMC = the total force on each element due to confinement

	double precision xCfPt(2,2)

	double precision vol
	

	vol=0
	nPCon=0

      
	nPx=(limitAll(4)-limitAll(3))*(1-1e-10)/pInt+1
	nPy=(limitAll(2)-limitAll(1))*(1-1e-10)/pInt+1
	y0Px=limitAll(3)+(limitAll(4)-limitAll(3))*.5e-10
	x0Py=limitAll(1)+(limitAll(2)-limitAll(1))*.5e-10

	FxC=0
	FyC=0
	FMC=0
	
	pPlot=0
	

	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!   Pressure from left       !!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	do iPx=1,nPx
		
		yPx=y0Px+(iPx-1)*pInt
		flagFound=0

	!!!!!!
	! Tricky algorithm.
	! First find the left most column that contains at least one element intersected by y=yPx
	! Then check the next column.
	
	iCol=1

		do while ((iCol.le.nGridX).and.(flagFound.eq.0))
			
			do iRow=max(1,int((yPx-limitAll(3))/xGrid)),
     $			min(nGridY,int((yPx-limitAll(3))/xGrid)+2)
				
				do iEle=1,nEleGrid(iCol,iRow)
					if ((boundEle(lEG(iCol,iRow,iEle),4).gt.yPx).and.
     $						(boundEle(lEG(iCol,iRow,iEle),3).lt.yPx)) then
     
						Call CfPt(yPx,lEG(iCol,iRow,iEle),nEle,xEle,yEle,rEle,
     $						nVertex,xVertex,yVertex,xCfPt,1,flagInter)	
     				      
     				      if (flagInter.eq.1) then
						   if (flagFound.eq.0) then
							   flagFound=1
							   nPCon=nPCon+1
							   iEleTemp=lEG(iCol,iRow,iEle)
							   pPlot(nPCon,1)=xCfPt(1,1)
						   else

							   if (xCfPt(1,1).lt.pPlot(nPcon,1)) then
								   iEleTemp=lEG(iCol,iRow,iEle)
								   pPlot(nPCon,1)=xCfPt(1,1)
							   end if									
   							
						   end if
						end if
					
					end if  ! yPx is within the y limits of this element
					
				end do	!iEle=1,nEleGrid(iCol,iRow)
			
			end do  ! iRow=max(1,int(yPx/xGrid)),min(nGridY,int(yPx/xGrid))+2)
			
			iCol=iCol+1
		
		end do  !while ((iCol.le.nGridX).and.(flagFound=0))
		
		! Found the first column that contains at least one element intersected by the force

		if ((FlagFound.eq.1).and.(iCol.le.nGridX)) then ! 
			
			do iRow=max(1,int((yPx-limitAll(3))/xGrid)),
     $			min(nGridY,int((yPx-limitAll(3))/xGrid)+2)
				
				do iEle=1,nEleGrid(iCol,iRow)
					if ((boundEle(lEG(iCol,iRow,iEle),4).gt.yPx).and.
     $						(boundEle(lEG(iCol,iRow,iEle),3).lt.yPx)) then
						Call CfPt(yPx,lEG(iCol,iRow,iEle),nEle,xEle,yEle,rEle,
     $						nVertex,xVertex,yVertex,xCfPt,1,flagInter)	
     				      if (flagInter.eq.1) then
							if (xCfPt(1,1).lt.pPlot(nPcon,1)) then
								iEleTemp=lEG(iCol,iRow,iEle)
								pPlot(nPCon,1)=xCfPt(1,1)
							end if
					   end if									
							
					
					end if  ! yPx is within the y limits of this element
					
				end do	!iEle=1,nEleGrid(iCol,iRow)
			
			end do  ! iRow=max(1,int(yPx/xGrid)),min(nGridY,int(yPx/xGrid))+2)
		
		end if  !((FlagFound.eq.0).and.(iCol.le.nGridX))

		if (FlagFound.eq.1) then
		
			vol=vol-pPlot(nPcon,1)*pInt
			
			 if (.true.) then
			
			    pPlot(nPcon,2)=yPx
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=3
			    
			    pPlot(nPcon,3)=PStress(1)*pInt
			    FxC(iEleTemp)=FxC(iELeTemp)+PStress(1)*pInt
			    FMC(iEleTemp)=FMC(iEleTemp) 
     $		        - PStress(1)*pInt*(yPx-yEle(iEleTemp))
			    
			 end if
			 
		end if
	
	end do ! iPx=1,nPx
	



	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!   Pressure from right      !!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


	do iPx=1,nPx
		
		yPx=y0Px+(iPx-1)*pInt
		flagFound=0

	!!!!!!
	! Tricky algorithm.
	! First find the left most column that contains at least one element intersected by y=yPx
	! Then check the next column.
	
	iCol=nGridX

		do while ((iCol.ge.1).and.(flagFound.eq.0))
			
			do iRow=max(1,int((yPx-limitAll(3))/xGrid)),
     $			min(nGridY,int((yPx-limitAll(3))/xGrid)+2)
     
				do iEle=1,nEleGrid(iCol,iRow)
					if ((boundEle(lEG(iCol,iRow,iEle),4).gt.yPx).and.
     $						(boundEle(lEG(iCol,iRow,iEle),3).lt.yPx)) then
						Call CfPt(yPx,lEG(iCol,iRow,iEle),nEle,xEle,yEle,rEle,
     $						nVertex,xVertex,yVertex,xCfPt,1,flagInter)	
     
     				      if (flagInter.eq.1) then
						   if (flagFound.eq.0) then
							   flagFound=1
							   nPCon=nPCon+1
							   iEleTemp=lEG(iCol,iRow,iEle)
							   pPlot(nPCon,1)=xCfPt(2,1)
						   else

							   if (xCfPt(2,1).gt.pPlot(nPcon,1)) then
								   iEleTemp=lEG(iCol,iRow,iEle)
								   pPlot(nPCon,1)=xCfPt(2,1)
							   end if									
   							
						   end if
						end if
					
					end if  ! yPx is within the y limits of this element
					
				end do	!iEle=1,nEleGrid(iCol,iRow)
			
			end do  ! iRow=max(1,int(yPx/xGrid)),min(nGridY,int(yPx/xGrid))+2)
			
			iCol=iCol-1
		
		end do  !while ((iCol.ge.0).and.(flagFound.eq.0))
		

		if ((FlagFound.eq.1).and.(iCol.ge.1)) then ! Otherwise didn't find a polygon to apply this force
			
			do iRow=max(1,int(yPx/xGrid)),min(nGridY,int(yPx/xGrid)+2)
				
				do iEle=1,nEleGrid(iCol,iRow)
					if ((boundEle(lEG(iCol,iRow,iEle),4).gt.yPx).and.
     $						(boundEle(lEG(iCol,iRow,iEle),3).lt.yPx)) then
						Call CfPt(yPx,lEG(iCol,iRow,iEle),nEle,xEle,yEle,rEle,
     $						nVertex,xVertex,yVertex,xCfPt,1,flagInter)	
     				      
     				      if (flagInter.eq.1) then
							if (xCfPt(2,1).gt.pPlot(nPcon,1)) then
								iEleTemp=lEG(iCol,iRow,iEle)
								pPlot(nPCon,1)=xCfPt(2,1)
							end if			
					   end if						
							
					
					end if  ! yPx is within the y limits of this element
					
				end do	!iEle=1,nEleGrid(iCol,iRow)
			
			end do  ! iRow=max(1,int(yPx/xGrid)),min(nGridY,int(yPx/xGrid))+2)
		
		end if  !((FlagFound.eq.0).and.(iCol.le.nGridX))

		if (FlagFound.eq.1) then
		
 			vol=vol+pPlot(nPcon,1)*pInt
		
			 if (.true.) then
			
			    pPlot(nPcon,2)=yPx
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=4
			    
			    pPlot(nPcon,3)=-PStress(1)*pInt
			    FxC(iEleTemp)=FxC(iELeTemp)-PStress(1)*pInt
			    FMC(iEleTemp)=FMC(iEleTemp) 
     $		        + PStress(1)*pInt*(yPx-yEle(iEleTemp))

			    
			 end if
			 
		end if 
	
	end do ! iPx=1,nPx
      


	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!   Pressure from bottom     !!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	

	do iPy=1,nPy
		
		xPy=x0Py+(iPy-1)*pInt
		flagFound=0

	
	iRow=1

		do while ((iRow.le.nGridY).and.(flagFound.eq.0))
			
			do iCol=max(1,int((xPy-limitAll(1))/xGrid)),
     $			min(nGridX,int((xPy-limitAll(1))/xGrid)+2)
				
				do iEle=1,nEleGrid(iCol,iRow)
					if ((boundEle(lEG(iCol,iRow,iEle),2).gt.xPy).and.
     $						(boundEle(lEG(iCol,iRow,iEle),1).lt.xPy)) then
						Call CfPt(xPy,lEG(iCol,iRow,iEle),nEle,xEle,yEle,rEle,
     $						nVertex,xVertex,yVertex,xCfPt,2,flagInter)	
     				
     				      if (flagInter.eq.1) then

						   if (flagFound.eq.0) then
							   flagFound=1
							   nPCon=nPCon+1
							   iEleTemp=lEG(iCol,iRow,iEle)
							   pPlot(nPCon,2)=xCfPt(1,2)
						   else

							   if (xCfPt(1,2).lt.pPlot(nPcon,2)) then
								   iEleTemp=lEG(iCol,iRow,iEle)
								   pPlot(nPCon,2)=xCfPt(1,2)
							   end if									
   							
						   end if
						   
						end if
					
					end if  ! xPy is within the x limits of this element
					
				end do	!iEle=1,nEleGrid(iCol,iRow)
			
			end do  ! iCol
			
			iRow=iRow+1
		
		end do   !while ((iRow.le.nGridY).and.(flagFound.eq.0))
		

		if ((FlagFound.eq.1).and.(iRow.le.nGridy)) then ! Otherwise didn't find a polygon to apply this force
			
			do iCol=max(1,int((xPy-limitAll(1))/xGrid)),
     $			min(nGridX,int((xPy-limitAll(1))/xGrid)+2)
				
				do iEle=1,nEleGrid(iCol,iRow)
					if ((boundEle(lEG(iCol,iRow,iEle),2).gt.xPy).and.
     $						(boundEle(lEG(iCol,iRow,iEle),1).lt.xPy)) then
						Call CfPt(xPy,lEG(iCol,iRow,iEle),nEle,xEle,yEle,rEle,
     $						nVertex,xVertex,yVertex,xCfPt,2,flagInter)
     	
     				      if (flagInter.eq.1) then
							if (xCfPt(1,2).lt.pPlot(nPcon,2)) then
								iEleTemp=lEG(iCol,iRow,iEle)
								pPlot(nPCon,2)=xCfPt(1,2)
							end if									
						end if
							
					
					end if 
					
				end do	!iEle=1,nEleGrid(iCol,iRow)
			
			end do 
		
		end if 
		if ((FlagFound.eq.1))then     !.and.(1.0.lt.0.0)
		
			 if (.true.) then
			
			    pPlot(nPcon,1)=xPy
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=1
			    
			    pPlot(nPcon,4)=PStress(2)*pInt
			    FyC(iEleTemp)=FyC(iELeTemp)+PStress(2)*pInt
			    FMC(iEleTemp)=FMC(iEleTemp) 
     $		        + PStress(2)*pInt*(xPy-xEle(iEleTemp))
			 end if
			 
		end if   !((FlagFound.eq.1))
	
	end do ! iPy=1,nPy
      
      
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!   Pressure from top		     !!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

	do iPy=1,nPy
		
		xPy=x0Py+(iPy-1)*pInt
		flagFound=0

	
	iRow=nGridY

		do while ((iRow.ge.1).and.(flagFound.eq.0))
			
			do iCol=max(1,int((xPy-limitAll(1))/xGrid)),
     $			min(nGridX,int((xPy-limitAll(1))/xGrid)+2)
				
				do iEle=1,nEleGrid(iCol,iRow)
					if ((boundEle(lEG(iCol,iRow,iEle),2).gt.xPy).and.
     $						(boundEle(lEG(iCol,iRow,iEle),1).lt.xPy)) then
						Call CfPt(xPy,lEG(iCol,iRow,iEle),nEle,xEle,yEle,rEle,
     $						nVertex,xVertex,yVertex,xCfPt,2,flagInter)	
     				
     				      if (flagInter.eq.1) then

						   if (flagFound.eq.0) then
							   flagFound=1
							   nPCon=nPCon+1
							   iEleTemp=lEG(iCol,iRow,iEle)
							   pPlot(nPCon,2)=xCfPt(2,2)
						   else

							   if (xCfPt(2,2).gt.pPlot(nPcon,2)) then
								   iEleTemp=lEG(iCol,iRow,iEle)
								   pPlot(nPCon,2)=xCfPt(2,2)
							   end if									
   							
						   end if
                     end if					
					end if  ! xPy is within the x limits of this element
					
				end do	!iEle=1,nEleGrid(iCol,iRow)
			
			end do  ! iCol
			
			iRow=iRow-1
		
		end do   !while ((iRow.le.nGridY).and.(flagFound.eq.0))
		

		if ((FlagFound.eq.1).and.(iRow.ge.1)) then ! Otherwise didn't find a polygon to apply this force
			
			do iCol=max(1,int(xPy/xGrid)),min(nGridX,int(xPy/xGrid)+2)
				
				do iEle=1,nEleGrid(iCol,iRow)
					if ((boundEle(lEG(iCol,iRow,iEle),2).gt.xPy).and.
     $						(boundEle(lEG(iCol,iRow,iEle),1).lt.xPy)) then
						Call CfPt(xPy,lEG(iCol,iRow,iEle),nEle,xEle,yEle,rEle,
     $						nVertex,xVertex,yVertex,xCfPt,2,flagInter)	
     				
     				      if (flagInter.eq.1) then

							if (xCfPt(2,2).gt.pPlot(nPcon,2)) then
								iEleTemp=lEG(iCol,iRow,iEle)
								pPlot(nPCon,2)=xCfPt(2,2)
							end if									
                     end if							
					
					end if 
					
				end do	!iEle=1,nEleGrid(iCol,iRow)
			
			end do 
		
		end if 
		if (FlagFound.eq.1)then     ! .and.(1.0.lt.0.0)
		
			 if (.true.) then
			
			    pPlot(nPcon,1)=xPy
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=2
			    
			    pPlot(nPcon,4)=-PStress(2)*pInt
			    FyC(iEleTemp)=FyC(iELeTemp)-PStress(2)*pInt
			    FMC(iEleTemp)=FMC(iEleTemp) 
     $		        - PStress(2)*pInt*(xPy-xEle(iEleTemp))

			    
			 end if
			 


		
		end if  !((FlagFound.eq.1))
	
	end do ! iPx=1,nPx

      vol=vol/(nPx*pInt)*(limitAll(4)-limitAll(3))  ! vol correction
      

	end subroutine
