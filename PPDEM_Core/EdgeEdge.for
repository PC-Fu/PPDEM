	subroutine EdgeEdge (xA1,yA1,xA2,yA2,xB1,yB1,xB2,yB2,
     $	xtemp,ytemp,flagEE)

	implicit none

	double precision xA1,yA1,xA2,yA2,xB1,yB1,xB2,yB2,xtemp,ytemp

	double precision ua,ub,deno,numeA,numeB

	integer flagEE

	flagEE=0
	ua=10000
	ub=10000

	deno=(yB2-yB1)*(xA2-xA1)-(xB2-xB1)*(yA2-yA1)
	numeA=(xB2-xB1)*(yA1-yB1)-(yB2-yB1)*(xA1-xB1)
	numeB=(xA2-xA1)*(yA1-yB1)-(yA2-yA1)*(xA1-xB1)

	if (abs(deno).gt.1e-06) then
		ua=numeA/deno
		ub=numeB/deno
	end if

	if ((ua.gt.0).and.(ua.lt.1).and.(ub.gt.0).and.(ub.lt.1)) then
	
		flagEE=1
		xtemp=xA1+ua*(xA2-xA1)
		ytemp=yA1+ua*(yA2-yA1)
	
	end if





	end subroutine
