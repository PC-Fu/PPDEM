	subroutine EdgeCircle(x1,y1,x2,y2,x0,y0,r0,flagEC)
	implicit none

	double precision x1,y1,x2,y2,x0,y0,r0,x3,y3
	integer flagEC
	double precision dist

	flagEC=0

	if (((x1-x0)**2+(y1-y0)**2).lt.(r0**2)) then
		flagEC=1
		goto 4023
	end if

	if (((x2-x0)**2+(y2-y0)**2).lt.(r0**2)) then
		flagEC=1
		goto 4023
	end if

	call PtLine(x0,y0,x1,y1,x2,y2,x3,y3,dist)

	if (dist.gt.r0) then
		flagEC=0
		goto 4023
	end if

	if (abs(y2-y1).ge.abs(x2-x1)) then
		if ((y3.lt.max(y2,y1)).and.(y3.gt.min(y2,y1))) then
			flagEC=1
			goto 4023
		end if
	else
		if ((x3.lt.max(x2,x1)).and.(x3.gt.min(x2,x1))) then
			flagEC=1
			goto 4023
		end if

	end if
	

4023	end subroutine
