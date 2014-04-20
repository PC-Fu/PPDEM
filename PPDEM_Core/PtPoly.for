	subroutine  PtPoly(xB,yB,nVPA,xPA,yPA,flagPtPoly)
	implicit none
	
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
	!!! To check whether a point is inside of a polygon

	double precision xB,yB,xPA(10),yPA(10),xInter
	integer nVPA,flagPtPoly,nInter,iVertex
	! nInter=number of intersections between the horizontal ray (pointing right) and edges.  0 or 2 means outside.


	nInter=0
	flagPtPoly=0
	
	xPA(nVPA+1)=xPA(1)
	yPA(nVPA+1)=yPA(1)

	do iVertex=1,nVPA
		if (abs(yPA(iVertex)-yPA(iVertex+1)).gt.1e-12) then
		
			xInter=(yB-yPA(iVertex))/(yPA(iVertex+1)-yPA(iVertex))
     $			*(xPA(iVertex+1)-xPA(iVertex))+xPA(iVertex)

			if ((xInter.ge.min(xPA(iVertex+1),xPA(iVertex))).and.
     $			(xInter.le.max(xPA(iVertex+1),xPA(iVertex))).and.
     $			(xInter.gt.xB).and.
     $          (min(yPA(iVertex+1),yPA(iVertex)).lt.yB ).and.
     $          (yB.le.maxval(yPA(1:nVPA))).and.
     $          (yB.ge.minval(yPA(1:nVPA)))   ) then
				
				nInter=nInter+1
			end if
		
		end if
	end do

	if (nInter.eq.1) then
		flagPtPoly=1
	end if

	end subroutine