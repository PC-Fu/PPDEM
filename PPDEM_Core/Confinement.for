	subroutine Confinement(nEle,xEle,yEle,rEle,nVertex,xVertex,
     $	yVertex,boundEle,limitAll,pInt,nPCon,pPlot,FxC,FyC,FMC,
     $	nGridX,nGridY,nEleGrid,lEG,xGrid,flagDebug,maxNEleGrid,vol,
     $  pairCon,nWall,iniFWall,x1Wall,x2Wall,y1Wall,y2Wall,
     $  flagLoadMode,intLoadPara,realLoadPara,iCurStep)

	implicit none
	
	 !DEC$ ATTRIBUTES DLLEXPORT :: Confinement
	 !DEC$ ATTRIBUTES ALIAS:'Confinement' :: Confinement
	 !DEC$ ATTRIBUTES Reference :: 
     $  nEle,xEle,yEle,rEle,nVertex,xVertex,
     $	yVertex,boundEle,limitAll,pInt,nPCon,pPlot,FxC,FyC,FMC,
     $	nGridX,nGridY,nEleGrid,lEG,xGrid,flagDebug,maxNEleGrid,vol,
     $  pairCon,nWall,iniFWall,x1Wall,x2Wall,y1Wall,y2Wall,
     $  flagLoadMode,intLoadPara,realLoadPara,iCurStep

	integer nEle,nPcon,nGridX,nGridY,flagdebug,maxNEleGrid,nWall
	double precision xEle(nEle),yEle(nEle),rEle(nEle),
     $	xVertex(nEle,10),yVertex(nEle,10),boundEle(nEle,4),limitAll(4)
     $	,xGrid,meanDEle,
     $  x1Wall(nWall),x2Wall(nWall),y1Wall(nWall),y2Wall(nWall)

	integer lEG(nGridX,nGridY,maxNEleGrid),nEleGrid(nGridX,nGridY)

	double precision pInt,pPlot(nEle*10,4),y0Px,x0Py,yPx,xPy
	
	integer nVertex(nEle),nPx,nPy,iPx,iPy,iCol,iRow,flagFound,iEle,
     $	iEletemp,flagInter,pairCon(nEle*10,2)

	double precision FxC(nEle),FyC(nELe),FMC(nEle),iniFWall(nWall,2)
	! FxC, FyC, FMC = the total force on each element due to confinement

	double precision xCfPt(2,2)

	double precision vol
	
	double precision time111
	
	integer intLoadPara(0:100000,0:8),iCurStep(4),flagLoadMode
      double precision realLoadPara(0:100000,8)     

	vol=0
	nPCon=0
	iniFWall=0
	
      !call clockx(time111)
      !!write (10000,*) "strating confinement",time111

      meanDEle=sqrt((limitAll(4)-limitAll(3))*
     $ (limitAll(2)-limitAll(1))/nEle)*2
      
	nPx=(limitAll(4)-limitAll(3))*(1-1e-10)/pInt+1
	nPy=(limitAll(2)-limitAll(1))*(1-1e-10)/pInt+1
	y0Px=limitAll(3)+(limitAll(4)-limitAll(3))*.5e-10
	x0Py=limitAll(1)+(limitAll(2)-limitAll(1))*.5e-10

	FxC=0
	FyC=0
	FMC=0
	
	pPlot=0
	
	if (flagLoadMode.eq.0) then
	  iCurStep(2)=0
	end if





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
			
			 if (intLoadPara(iCurStep(2),5).eq.2) then
			
			    pPlot(nPcon,2)=yPx
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=3
			    
			    pPlot(nPcon,3)=realLoadPara(iCurStep(2),5)*pInt
			    FxC(iEleTemp)=FxC(iELeTemp)+realLoadPara(iCurStep(2),5)*pInt
			    
			 end if
			 
		     if (intLoadPara(iCurStep(2),6).eq.2) then
			
			    pPlot(nPcon,2)=yPx
			     
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=3
			    
			    pPlot(nPcon,4)=realLoadPara(iCurStep(2),6)*pInt
			    FyC(iEleTemp)=FyC(iEleTemp)+realLoadPara(iCurStep(2),6)*pInt
c			    FMC(iEleTemp)=FMC(iEleTemp)+realLoadPara(iCurStep(2),6)*pInt
c     $			    *(pPlot(nPCon,1)-xEle(iEleTemp))  !-pX*pInt*(yPx-yEle(iEleTemp))
			    
			 end if
			 
			 if ((intLoadPara(iCurStep(2),5).eq.3).and.
     $		 (abs(pPlot(nPcon,1)-x1Wall(3)).le.2*meanDEle)) then
     
			    iniFWall(3,1)=iniFWall(3,1)+realLoadPara(iCurStep(2),5)*pInt
			    
			 end if
			 
			 if ((intLoadPara(iCurStep(2),6).eq.3).and.
     $		 (abs(pPlot(nPcon,1)-x1Wall(3)).le.2*meanDEle)) then
     
			    iniFWall(3,2)=iniFWall(3,2)+realLoadPara(iCurStep(2),6)*pInt
			    
			 end if

			 if ((intLoadPara(iCurStep(2),5).ne.2).and.
     $		 (intLoadPara(iCurStep(2),6).ne.2)) then
			 
			    nPCon=nPCon-1
			 
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
		
			 if (intLoadPara(iCurStep(2),7).eq.2) then
			
			    pPlot(nPcon,2)=yPx
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=4
			    
			    pPlot(nPcon,3)=-realLoadPara(iCurStep(2),7)*pInt
			    FxC(iEleTemp)=FxC(iELeTemp)-realLoadPara(iCurStep(2),7)*pInt
			    
			 end if
			 
		     if (intLoadPara(iCurStep(2),8).eq.2) then
			
			    pPlot(nPcon,2)=yPx
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=4
			    
			    pPlot(nPcon,4)=-realLoadPara(iCurStep(2),8)*pInt
			    FyC(iEleTemp)=FyC(iEleTemp)-realLoadPara(iCurStep(2),8)*pInt
c			    FMC(iEleTemp)=FMC(iEleTemp)-realLoadPara(iCurStep(2),8)*pInt
c     $			    *(pPlot(nPCon,1)-xEle(iEleTemp))  !-pX*pInt*(yPx-yEle(iEleTemp))
			    
			 end if
			 
			 if ((intLoadPara(iCurStep(2),7).eq.3).and.
     $		 (abs(pPlot(nPcon,1)-x1Wall(4)).le.2*meanDEle)) then
			
			    iniFWall(4,1)=iniFWall(4,1)-realLoadPara(iCurStep(2),7)*pInt
			    
			 end if
			 
			 if ((intLoadPara(iCurStep(2),8).eq.3) .and.
     $		 (abs(pPlot(nPcon,1)-x1Wall(4)).le.2*meanDEle)) then
			 
			
			    iniFWall(4,2)=iniFWall(4,2)-realLoadPara(iCurStep(2),8)*pInt
			    
			 end if			
			 
			 if ((intLoadPara(iCurStep(2),7).ne.2).and.
     $		 (intLoadPara(iCurStep(2),8).ne.2)) then
			 
			    nPCon=nPCon-1
			 
			 end if
			 
		end if 
	
	end do ! iPx=1,nPx
      


	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!   Pressure from bottom     !!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	
	if ((intLoadPara(iCurStep(2),1).eq.2).or.
     $  	(intLoadPara(iCurStep(2),2).eq.2).or.
     $  	(intLoadPara(iCurStep(2),1).eq.3).or.
     $  	(intLoadPara(iCurStep(2),2).eq.3).or.
     $  	(intLoadPara(iCurStep(2),1).eq.4)) then

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
		
			 if (intLoadPara(iCurStep(2),1).eq.2) then
			
			    pPlot(nPcon,1)=xPy
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=1
			    
			    pPlot(nPcon,4)=realLoadPara(iCurStep(2),1)*pInt
			    FyC(iEleTemp)=FyC(iELeTemp)+realLoadPara(iCurStep(2),1)*pInt
			    
			 end if
			 
		     if (intLoadPara(iCurStep(2),2).eq.2) then
			
			    pPlot(nPcon,1)=xPy
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=1
			    
			    pPlot(nPcon,3)=realLoadPara(iCurStep(2),2)*pInt
			    FxC(iEleTemp)=FxC(iEleTemp)+realLoadPara(iCurStep(2),2)*pInt
c			    FMC(iEleTemp)=FMC(iEleTemp)+realLoadPara(iCurStep(2),2)*pInt
c     $			    *(pPlot(nPCon,2)-yEle(iEleTemp))  !-pX*pInt*(yPx-yEle(iEleTemp))
			    
			 end if
			 
			 
			 if ((intLoadPara(iCurStep(2),1).eq.3) .and.
     $		 (abs(pPlot(nPcon,2)-y1Wall(1)).le.2*meanDEle)) then
     
			    iniFWall(1,2)=iniFWall(1,2)+realLoadPara(iCurStep(2),1)*pInt
			    
			 end if
			 
			 if ((intLoadPara(iCurStep(2),2).eq.3) .and.
     $		 (abs(pPlot(nPcon,2)-y1Wall(1)).le.2*meanDEle)) then
			
			    iniFWall(1,1)=iniFWall(1,1)+realLoadPara(iCurStep(2),2)*pInt
			    
			 end if	
			 
			 
			 if ((intLoadPara(iCurStep(2),1).eq.3).or.
     $		 (intLoadPara(iCurStep(2),2).eq.3)) then
			 
			    nPCon=nPCon-1
			 
			 end if
			 
			 
			 if (intLoadPara(iCurStep(2),1).eq.4) then
			 
			    if (abs(pPlot(nPcon,2)-y1Wall(1)).gt.0.5*meanDEle) then
			    
			        pPlot(nPcon,1)=xPy
    			    
			        pairCon(nPCon,1)=iEleTemp
			        pairCon(nPCon,2)=1
    			    
			        pPlot(nPcon,4)=realLoadPara(iCurStep(2),5)*pInt
			        FyC(iEleTemp)=FyC(iEleTemp)+realLoadPara(iCurStep(2),5)*pInt
                else
                    nPCon=nPCon-1
                    
                end if
			    
			 end if  !(intLoadPara(iCurStep(2),1).eq.4)

			
		end if   !((FlagFound.eq.1))
	
	end do ! iPy=1,nPy
      
      end if
      
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!   Pressure from top		     !!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

     
	if ((intLoadPara(iCurStep(2),3).eq.2).or.
     $  	(intLoadPara(iCurStep(2),4).eq.2).or.
     $  	(intLoadPara(iCurStep(2),3).eq.3).or.
     $  	(intLoadPara(iCurStep(2),4).eq.3).or.
     $  	(intLoadPara(iCurStep(2),3).eq.4)) then

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
		
			 if (intLoadPara(iCurStep(2),3).eq.2) then
			
			    pPlot(nPcon,1)=xPy
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=2
			    
			    pPlot(nPcon,4)=-realLoadPara(iCurStep(2),3)*pInt
			    FyC(iEleTemp)=FyC(iELeTemp)-realLoadPara(iCurStep(2),3)*pInt
			    
			 end if
			 
		     if (intLoadPara(iCurStep(2),4).eq.2) then
			
			    pPlot(nPcon,1)=xPy
			    
			    pairCon(nPCon,1)=iEleTemp
			    pairCon(nPCon,2)=2
			    
			    pPlot(nPcon,3)=-realLoadPara(iCurStep(2),4)*pInt
			    FxC(iEleTemp)=FxC(iEleTemp)-realLoadPara(iCurStep(2),4)*pInt
c			    FMC(iEleTemp)=FMC(iEleTemp)-realLoadPara(iCurStep(2),4)*pInt
c     $			    *(pPlot(nPCon,2)-yEle(iEleTemp))  !-pX*pInt*(yPx-yEle(iEleTemp))
			    
			 end if
			 
			 if ((intLoadPara(iCurStep(2),3).eq.3) .and.
     $		 (abs(pPlot(nPcon,2)-y1Wall(2)).le.2*meanDEle)) then
			
			    iniFWall(2,2)=iniFWall(2,2)-realLoadPara(iCurStep(2),3)*pInt
			    
			 end if
			 
			 if ((intLoadPara(iCurStep(2),4).eq.3) .and.
     $		 (abs(pPlot(nPcon,2)-y1Wall(2)).le.2*meanDEle)) then
			
			    iniFWall(2,1)=iniFWall(2,1)-realLoadPara(iCurStep(2),4)*pInt
			    
			 end if	
			 
			 if ((intLoadPara(iCurStep(2),3).eq.3).or.
     $		 (intLoadPara(iCurStep(2),4).eq.3)) then
			 
			    nPCon=nPCon-1
			 
			 end if
			 
			 if (intLoadPara(iCurStep(2),3).eq.4) then
			 
			    if (abs(pPlot(nPcon,2)-y1Wall(2)).gt.0.5*meanDEle) then
			    
			        pPlot(nPcon,1)=xPy
    			    
			        pairCon(nPCon,1)=iEleTemp
			        pairCon(nPCon,2)=2
    			    
			        pPlot(nPcon,4)=-realLoadPara(iCurStep(2),5)*pInt
			        FyC(iEleTemp)=FyC(iEleTemp)-realLoadPara(iCurStep(2),5)*pInt
                else
                    nPCon=nPCon-1
                     
                end if
			    
			 end if  !(intLoadPara(iCurStep(2),3).eq.4)
		

		
		end if  !((FlagFound.eq.1))
	
	end do ! iPx=1,nPx
	
	end if


      vol=vol/(nPx*pInt)*(limitAll(4)-limitAll(3))  ! vol correction
      
      if ((intLoadPara(iCurStep(2),3).eq.3).and.
     $  (intLoadPara(iCurStep(2),1).eq.3)) then
        
        iniFWall(1,2)=max(iniFWall(1,2),-iniFWall(2,2))      
        iniFWall(2,2)=-iniFWall(1,2)      
      
      end if
      
      if ((intLoadPara(iCurStep(2),5).eq.3).and.
     $  (intLoadPara(iCurStep(2),7).eq.3)) then
        
        iniFWall(3,1)=max(iniFWall(3,1),-iniFWall(4,1))      
        iniFWall(4,1)=-iniFWall(3,1)      
      
      end if

	end subroutine
