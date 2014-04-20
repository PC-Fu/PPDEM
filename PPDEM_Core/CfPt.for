	Subroutine CfPt(xyP,iEle,nEle,xEle,yEle,rEle,
     $		nVertex,xVertex,yVertex,xCfPt,FlagPType,flagInter)					
	
	implicit none
	
	integer nEle,iEle,FlagPType,iPt,iVt,flagInter
	! FlagPType=1 if horizontal; =2 if vertical

	integer nVertex(nEle)

	double precision xEle(nEle),yEle(nEle),rEle(nEle),
     $	xVertex(nEle,10),yVertex(nEle,10),xyP

	double precision xCfPt(2,2),xtemp(2)

	iPt=0
	flagInter=0

	if (FlagPType.eq.1)	then  ! Horizontal pressure
	
		if (nVertex(iEle).eq.0) then
		
			xCfPt(1,1)=xEle(iEle)-sqrt(rEle(iEle)**2-(xyP-yEle(iEle))**2)
			xCfPt(2,1)=xEle(iEle)+sqrt(rEle(iEle)**2-(xyP-yEle(iEle))**2)
			flagInter=1

		else

			iVt=1
			do while ((iPt.lt.2).and.(iVt.le.nVertex(iEle)))
	
				if ((min(yVertex(iEle,iVt),yVertex(iEle,iVt+1)).lt.xyP).and.
     $				(max(yVertex(iEle,iVt),yVertex(iEle,iVt+1)).gt.xyP)) then
				   
				   flagInter=1
					iPt=iPt+1
					xtemp(iPt)=(xyP-yVertex(iEle,iVt))/
     $				(yVertex(iEle,iVt+1)-yVertex(iEle,iVt))*
     $				(xVertex(iEle,iVt+1)-xVertex(iEle,iVt))+xVertex(iEle,iVt)
			
				end if

				iVt=iVt+1
			end do
			
			xCfPt(1,1)=min(xTemp(1),xTemp(2))
			xCfPt(2,1)=max(xTemp(1),xTemp(2))


		end if   ! Circle or Polygon?

	xCfPt(1,2)=xyP
	xCfPt(2,2)=xyP


	else  ! FlagPType=2

		if (nVertex(iEle).eq.0) then
		
			xCfPt(1,2)=yEle(iEle)-sqrt(rEle(iEle)**2-(xyP-xEle(iEle))**2)
			xCfPt(2,2)=yEle(iEle)+sqrt(rEle(iEle)**2-(xyP-xEle(iEle))**2)
			flagInter=1

		else

			iVt=1
			do while ((iPt.lt.2).and.(iVt.le.nVertex(iEle)))
	
				if ((min(xVertex(iEle,iVt),xVertex(iEle,iVt+1)).lt.xyP).and.
     $				(max(xVertex(iEle,iVt),xVertex(iEle,iVt+1)).gt.xyP)) then
				
				   flagInter=1
					iPt=iPt+1
					xtemp(iPt)=(xyP-xVertex(iEle,iVt))/
     $				(xVertex(iEle,iVt+1)-xVertex(iEle,iVt))*
     $				(yVertex(iEle,iVt+1)-yVertex(iEle,iVt))+yVertex(iEle,iVt)
			
				end if

				iVt=iVt+1
			end do
			
			xCfPt(1,2)=min(xTemp(1),xTemp(2))
			xCfPt(2,2)=max(xTemp(1),xTemp(2))


		end if   ! Circle or Polygon?

	xCfPt(1,1)=xyP
	xCfPt(2,1)=xyP

	end if

	end subroutine