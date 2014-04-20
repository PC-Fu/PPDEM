      subroutine LineCircle(x1,y1,x2,y2,iV,xPACE,rqPACE,xCI,
     $   flagLineCirle)
      implicit none
      integer iV,flagLineCirle
      double precision x1,y1,x2,y2,xPACE(10,2),rqPACE(10,4),xCI(2,2),
     $dx,dy,dr2,D,delta,sqrtDelta
      
      dx=x2-x1
      dy=y2-y1
      dr2=dx**2+dy**2
      D=(x1-xPACE(iV,1))*(y2-xPACE(iV,2))-
     $ (x2-xPACE(iV,1))*(y1-xPACE(iV,2))
      delta=rqPACE(iV,3)**2*dr2-D**2
      sqrtDelta=sqrt(delta)
      
      if (delta.le.0) then
         flagLineCirle=0
      else 
         flagLineCirle=1
         xCI(1,1)=(D*dy+dsign(1.0,dy)*dx*sqrtDelta)/dr2+xPACE(iV,1)
         xCI(2,1)=(D*dy-dsign(1.0,dy)*dx*sqrtDelta)/dr2+xPACE(iV,1)
         xCI(1,2)=(-D*dx+abs(dy)*sqrtDelta)/dr2+xPACE(iV,2)
         xCI(2,2)=(-D*dx-abs(dy)*sqrtDelta)/dr2+xPACE(iV,2)
      
      end if
      
      
      end subroutine
      
      
     