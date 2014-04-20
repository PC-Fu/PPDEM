	subroutine	PWDist(nPA,xPA,yPA,x1,y1,x2,y2,maxGap,flagFrd)
	
	implicit none

	integer nPA,flagFrd

	double precision xPA(10),yPA(10),x1,y1,x2,y2,maxGap

	integer iVertex

	double precision x3,y3,dist

	flagFrd=0

	do iVertex=1,nPA
		
		call PtLine(xPA(iVertex),yPA(iVertex),x1,y1,x2,y2,x3,y3,dist)

		if	((x3.le.max(x1,x2)+1e-12).and.(x3.ge.min(x1,x2)-1e-12)
     $	.and.(y3.le.max(y1,y2)+1e-12).and.(y3.ge.min(y1,y2)-1e-12)
     $	.and.(dist.lt.maxGap)) then
			
				flagFrd=1
				goto 6432
			
		end if


	end do


6432	end subroutine
