	subroutine  findCon(nVinP,xVinP,yVinP,xCA,yCA,xCB,yCB,
     $							xCon,yCon,cosB,sinB,aover,nPEE,xPEE,yPEE)
	
	implicit none

	integer nVinP,imax,jmax,ivertex,nPEE,iPEE,jPEE

	double precision xVinP(10),yVinP(10),xCA,yCA,xCB,yCB,
     $			xCon,yCon,cosB,sinB,aover,xPEE(10),yPEE(10)

	double precision cosAB,sinAB,cosVV,sinVV,sinABVV,maxABVV,lVV
	! AC connect the centers of the two circles.
	! VV connect any two of the vertexes.
	aOver=0
	xcon=0
	ycon=0

	do iVertex=1,nVinP
	
		aOver=aOver+(xVinP(iVertex)*yVinP(iVertex+1)
     $		-xVinP(iVertex+1)*yVinP(iVertex))
		
	end do

	aOver=0.5*aOver

	maxABVV=0
	
	cosAB=(xCB-xCA)/sqrt((xCB-xCA)**2+(yCB-yCA)**2)
	sinAB=(yCB-yCA)/sqrt((xCB-xCA)**2+(yCB-yCA)**2)

	do iPEE=1,nPEE-1
		do jPEE=iPEE+1,nPEE
		lVV=sqrt(((xPEE(jPEE)-xPEE(iPEE)))**2+
     $			((yPEE(jPEE)-yPEE(iPEE)))**2)
			
			cosVV=(xPEE(jPEE)-xPEE(iPEE))/lVV

			sinVV=(yPEE(jPEE)-yPEE(iPEE))/lVV

			sinABVV=sinAB*cosVV-cosAB*sinVV

			if (abs(sinABVV**2*lVV).gt.maxABVV) then
				
				maxABVV=abs(sinABVV**2*lVV)
				imax=iPEE
				jmax=jPEE
				cosB=cosVV
				sinB=sinVV

			end if
		end do
	end do


	
	
		do iVertex=1,nVinP
	
			xcon=xcon+(xVinP(iVertex)+xVinP(iVertex+1))*(xVinp(iVertex)
     $			*yVinP(iVertex+1)-xVinp(iVertex+1)*yVinP(iVertex))
			ycon=ycon+(yVinP(iVertex)+yVinP(iVertex+1))*(xVinp(iVertex)
     $			*yVinP(iVertex+1)-xVinp(iVertex+1)*yVinP(iVertex))
		
		end do
			xcon=xcon/6/aover
			ycon=ycon/6/aover


	end subroutine
