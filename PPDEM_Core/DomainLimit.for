      subroutine DomainLimit(nEle,nActEle,xEle,yEle,rEle,nVertex,
     $   xVertex,yVertex,boundele,limitAll,hSector)
      implicit none
      
      !DEC$ ATTRIBUTES DLLEXPORT :: DomainLimit
	!DEC$ ATTRIBUTES ALIAS:'DomainLimit' :: DomainLimit
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,nActEle,xEle,yEle,rEle,nVertex,
     $   xVertex,yVertex,boundele,limitAll,hSector
     
     
      integer nEle,nActEle,nVertex(nEle),iEle,iVertex

	double precision xEle(nEle),yEle(nEle),rEle(nEle),xVertex(nEle,10)
     $	,yVertex(nELe,10),boundEle(nEle,4),limitAll(4),hSector(nEle)

	boundEle=0
    	call BoundBox(nEle,nActEle,xEle,yEle,rEle,nVertex,xVertex,yVertex,
     $	boundEle,hSector)

	limitAll(1)=xEle(1)
	limitALl(2)=xELe(1)
	limitAll(3)=yEle(1)
	limitALl(4)=yELe(1)

	do iEle=1,nActEle
	

	   if (boundEle(iEle,1).lt.limitAll(1)) then
		   limitAll(1)=boundEle(iEle,1)
	   end if
	   if (boundEle(iEle,2).gt.limitAll(2)) then
		   limitAll(2)=boundEle(iEle,2)
	   end if
	   if (boundEle(iEle,3).lt.limitAll(3)) then
		   limitAll(3)=boundEle(iEle,3)
	   end if
	   if (boundEle(iEle,4).gt.limitAll(4)) then
		   limitAll(4)=boundEle(iEle,4)
	   end if
		
	end do
	end subroutine