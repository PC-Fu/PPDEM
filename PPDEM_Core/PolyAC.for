	subroutine PolyAC(nVP,xVP,yVP,area,xCtd)
	! Calculate the Aera and Centroid and a Polygon
	implicit none
	integer nVP,iVP
	double precision xVP(10),yVP(10),area,xCtd(2)
	! xCtd=the coordinates of centroid

	
	area=0
	xCtd=0
	xVP(nVP+1)=xVP(1)
	yVP(nVP+1)=yVP(1)

	do iVP=1,nVP

		area=area+(xVP(iVP)*yVP(iVP+1)-xVP(iVP+1)*yVP(iVP))
	
	end do

	area=area/2.

	do iVP=1,nVP
	
		xCtd(1)=xCtd(1)+(xVP(iVP)+xVP(iVP+1))*
     $		(xVP(iVP)*yVP(iVP+1)-xVP(iVP+1)*yVP(iVP))
		xCtd(2)=xCtd(2)+(yVP(iVP)+yVP(iVP+1))*
     $		(xVP(iVP)*yVP(iVP+1)-xVP(iVP+1)*yVP(iVP))
	
	end do
	
	xCtd(1)=xCtd(1)/6/area
	xCtd(2)=xCtd(2)/6/area

	
	
	
	
	end subroutine