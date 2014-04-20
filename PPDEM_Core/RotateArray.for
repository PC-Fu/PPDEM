	subroutine RotateArray(nMax,nEle,ang,x,y,Rx,Ry)
	implicit none
	
	 !DEC$ ATTRIBUTES DLLEXPORT :: RotateArray
	 !DEC$ ATTRIBUTES ALIAS:'RotateArray' :: RotateArray
	 !DEC$ ATTRIBUTES Reference :: 
     $  nMax,nEle,ang,x,y,Rx,Ry
 
      integer nMax, nEle
      double precision ang, cosAng, sinAng
      double precision x(nMax), y(nMax), Rx(nMax), Ry(nMax)
      
      integer iEle
      
      cosAng=dcos(ang)
      sinAng=dsin(ang)
      
      do iEle=1,nEle
        Rx(iEle) = x(iEle)*cosAng - y(iEle)*sinAng
        Ry(iEle) = x(iEle)*sinAng + y(iEle)*cosAng
      
      end do
      
      end subroutine
      