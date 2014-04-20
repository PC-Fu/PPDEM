      subroutine LineIntersect(x1,x2,x3,x4,x0,ua,flagInter)
      implicit none
      
      double precision x1(2),x2(2),x3(2),x4(2),x0(2),ua(2)
      integer flagInter
      double precision uan1,uan2, uad
      
      flagInter=0
      
      uan1=(x4(1)-x3(1))*(x1(2)-x3(2))-(x4(2)-x3(2))*(x1(1)-x3(1))
      uan2=(x2(1)-x1(1))*(x1(2)-x3(2))-(x2(2)-x1(2))*(x1(1)-x3(1))
      uad= (x4(2)-x3(2))*(x2(1)-x1(1))-(x4(1)-x3(1))*(x2(2)-x1(2))
      
      if (abs(uad).gt.1e-10) then
        ua(1)=uan1/uad
        ua(2)=uan2/uad
        
        if ( (ua(1).gt.0.001).and.(ua(1).lt.0.999).and.
     $       (ua(2).gt.0.001).and.(ua(2).lt.0.999) ) then
            flagInter=1
            x0=x1+ua(1)*(x2-x1)
        else
            flagInter=0
        end if
        
      end if
      
      
      
      
      
      end subroutine
      
      