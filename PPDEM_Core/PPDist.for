	subroutine PPDist(nPA,xPA,yPA,nPB,xPB,yPB,
     $			maxGap,flagFrd)

	implicit none

	integer nPA,nPB,flagFrd

	double precision xPA(10),yPA(10),xPB(10),yPB(10),maxGap
	! If the distance between any vertex of polygon A and any vertex of polygon B,
	! or the distance between a vertex of a polygon and an edge of the other polygon
	! is smaller than maxGap, then return flagFrd=1

	integer iV,jV

	double precision x3,y3,dist

	flagFrd=0


	do iV=1,nPA
		do jV=1,nPB
			
			if (((xPA(iV)-xPB(jV))**2+(yPA(iV)-yPB(jV))**2).lt.maxGap**2) then
				flagFrd=1
				goto 5123
			end if

		end do
	end do
	
	do iV=1,nPA
		do jV=1, nPB

			call PtLine(xPA(iV),yPA(iV),xPB(jV),yPB(jV),xPB(jV+1),
     $			yPB(jV+1),x3,y3,dist)
				
			if ((x3.lt.max(xPB(jV),xPB(jV+1)))
     $			.and.(x3.gt.min(xPB(jV),xPB(jV+1)))
     $			.and.(y3.lt.max(yPB(jV),yPB(jV+1)))
     $			.and.(y3.gt.min(yPB(jV),yPB(jV+1)))
     $			.and.(dist.lt.maxGap)) then
				
				flagFrd=1
				goto 5123

			end if

		end do
	end do

	do iV=1,nPB
		do jV=1, nPA

			call PtLine(xPB(iV),yPB(iV),xPA(jV),yPA(jV),xPA(jV+1),
     $			yPA(jV+1),x3,y3,dist)
				
			if ((x3.lt.max(xPA(jV),xPA(jV+1)))
     $			.and.(x3.gt.min(xPA(jV),xPA(jV+1)))
     $			.and.(y3.lt.max(yPA(jV),yPA(jV+1)))
     $			.and.(y3.gt.min(yPA(jV),yPA(jV+1)))
     $			.and.(dist.lt.maxGap)) then
				
				flagFrd=1
				goto 5123

			end if

		end do
	end do


5123	end subroutine
