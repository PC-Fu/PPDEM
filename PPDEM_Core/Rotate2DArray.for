	subroutine Rotate2DArray(nMax,maxChild,
     $  nEle,nChild,ang,x,y,Rx,Ry)
	implicit none
	
	 !DEC$ ATTRIBUTES DLLEXPORT :: Rotate2DArray
	 !DEC$ ATTRIBUTES ALIAS:'Rotate2DArray' :: Rotate2DArray
	 !DEC$ ATTRIBUTES Reference :: 
     $  nMax,maxChild,
     $  nEle,nChild,ang,x,y,Rx,Ry
 
	integer nMax, maxChild, nEle
	integer nChild(nMax)
	double precision ang, cosAng, sinAng
	double precision x(nMax,maxChild), y(nMax,maxChild), 
     $      Rx(nMax,maxChild), Ry(nMax,maxChild)
	
	integer iEle, i
	
	cosAng=dcos(ang)
	sinAng=dsin(ang)
	
	do iEle=1,nEle
		do i=1,nChild(iEle)+1
		Rx(iEle,i) = x(iEle,i)*cosAng - y(iEle,i)*sinAng
		Ry(iEle,i) = x(iEle,i)*sinAng + y(iEle,i)*cosAng
	  end do 
	end do
	
	end subroutine
	