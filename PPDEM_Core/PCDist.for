	subroutine PCDist(xCA,yCA,rCA,nPB,xPB,yPB,
     $			maxGap,flagFrd)
	! A is always the circle and B is always the polygon
	implicit none

	integer nPB,flagFrd,iV

	double precision xCA,yCA,rCA,xPB(10),yPB(10),maxGap

	double precision x3,y3,dist

	flagFrd=0

	! Check whether these is a vertex within the circle
	
	do iV=1,nPB
			
		if (((xCA-xPB(iV))**2+(yCA-yPB(iV))**2).lt.(maxGap+rCA)**2) then
			flagFrd=1
			goto 5125
		end if

	end do
	
	! Check wheter there is a edge is close to the circle

	do iV=1,nPB

			call PtLine(xCA,yCA,xPB(iV),yPB(iV),xPB(iV+1),
     $			yPB(iV+1),x3,y3,dist)
				
			if ((x3.lt.max(xPB(iV),xPB(iV+1)))
     $			.and.(x3.gt.min(xPB(iV),xPB(iV+1)))
     $			.and.(y3.lt.max(yPB(iV),yPB(iV+1)))
     $			.and.(y3.gt.min(yPB(iV),yPB(iV+1)))
     $			.and.(dist.lt.(maxGap+rCA))) then
				
				flagFrd=1
				goto 5125

			end if

	end do



5125	end subroutine
