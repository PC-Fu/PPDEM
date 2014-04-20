	subroutine sortVinP(xVinp, yVinP, nVinP)
      !use SVRGP_INT
	implicit none
	
	double precision xVinP(10),yVinP(10),cosq(10),sinq(10),
     $	xmid,ymid,tempx(10),tempy(10),q(10),qtemp
     

	integer nVinP,iPerm(10),iPt,i,j,iPermTemp

	xmid=0
	ymid=0
	
	
	do iPt=1,nVinP
	
		xmid=xmid+xVinP(iPt)
		ymid=ymid+yVinP(iPt)
	
	end do

	xmid=xmid/nVinP
	ymid=ymid/nVinP

	do iPt=1,nVinP
	
		cosq(iPt)=(xVinP(iPt)-xmid)/
     $		sqrt((xVinP(iPt)-xmid)**2+(yVinP(iPt)-ymid)**2)
		sinq(iPt)=(yVinP(iPt)-ymid)/
     $		sqrt((xVinP(iPt)-xmid)**2+(yVinP(iPt)-ymid)**2)
	
	end do

	q=10000.

	do iPt=1,nVinP

		q(iPt)=dsign(1.,sinq(iPt))*(-5-cosq(iPt))

	end do


	do iPt=1,10
		iPerm(iPt)=iPt
	end do


      do i=1,8
        do j=1,10-i
            if (q(j).gt.q(j+1)) then
                qtemp=q(j+1)
                q(j+1)=q(j)
                q(j)=qtemp
                iPermTemp=iPerm(j+1)
                iPerm(j+1)=iPerm(j)
                iPerm(j)=iPermTemp
             end if
                
      
        end do
      end do
        
	!call SVRGP(10,q,q,iPerm)

	tempx=xVinP
	tempy=yVinP
	
	xVinP=0
	yVinP=0

	do iPt=1,nVinP
		xVinP(iPt)=tempx(iPerm(iPt))
		yVinP(iPt)=tempy(iPerm(iPt))
	end do

	end subroutine


