	subroutine RotatePPlot(nMax,nCon,ang,RpPlot,pPlot)
	implicit none
	
	 !DEC$ ATTRIBUTES DLLEXPORT :: RotatePPlot
	 !DEC$ ATTRIBUTES ALIAS:'RotatePPlot' :: RotatePPlot
	 !DEC$ ATTRIBUTES Reference :: 
     $  nMax,nEle,ang,RpPlot,pPlot
 
      integer nMax, nCon
      double precision ang, cosAng, sinAng
      double precision RpPlot(nMax*10,4), pPlot(nMax*10,4)
      
      integer iCon
      
      cosAng=dcos(ang)
      sinAng=dsin(ang)
      
      do iCon=1,nCon
        pPlot(iCon,1) = RpPlot(iCon,1)*cosAng - RpPlot(iCon,2)*sinAng
        pPlot(iCon,2) = RpPlot(iCon,1)*sinAng + RpPlot(iCon,2)*cosAng
        pPlot(iCon,3) = RpPlot(iCon,3)*cosAng - RpPlot(iCon,4)*sinAng
        pPlot(iCon,4) = RpPlot(iCon,3)*sinAng + RpPlot(iCon,4)*cosAng
      
      end do
      
      end subroutine
      