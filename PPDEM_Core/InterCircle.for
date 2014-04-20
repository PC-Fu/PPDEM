      subroutine InterCircle(x1,y1,r1,x2,y2,r2,flagCC,x3y3)
      implicit none
      double precision x1,y1,r1,x2,y2,r2,x3y3(2,2),
     $   x0,y0,a,b,d,d2,h
      integer flagCC
      d2=(x2-x1)**2+(y2-y1)**2
      if (d2.gt.(r1+r2)**2) then
         flagCC=0
      else
         flagCC=1
         d=dsqrt(d2)
         a=(r1**2-r2**2+d2)/2/d
         h=dsqrt(r1**2-a**2)
         x0=x1+a/d*(x2-x1)
         y0=y1+a/d*(y2-y1)
         x3y3(1,1)=x0+h/d*(y2-y1)
         x3y3(1,2)=y0-h/d*(x2-x1)
         x3y3(2,1)=x0-h/d*(y2-y1)
         x3y3(2,2)=y0+h/d*(x2-x1)
         
      end if
         
      end subroutine
      