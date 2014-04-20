
      Subroutine BHSV2RGB(fricRatio,FRGB)
      implicit none  !http://en.wikipedia.org/wiki/HSL_and_HSV
      
      double precision fricRatio
      Byte FRGB(4),toByte
      double precision h,f,p,q,t,v
      integer hi
      
      FRGB(4)=-1 
      h=cos(fricRatio*3.14)
      h=dsign(abs(h)**.6,h)
      h=(h*0.5+.5)*240
      hi=h/60
      f=h/60-hi
      v=1.0
      if (h.lt.30) then
        v=.9+0.2*(h-30)/30
      else if (h.gt.210) then
        v=.9-0.2*(h-210)/30
      end if
      p=0
      q=(1-f)*v
      t=f*v
      if (hi.eq.0) then
         FRGB(3)=toByte(int(v*255))
         FRGB(2)=toByte(int(t*255))
         FRGB(1)=toByte(int(p*255)) 
      else if (hi.eq.1) then
         FRGB(3)=toByte(int(q*255))        
         FRGB(2)=toByte(int(v*255))
         FRGB(1)=toByte(int(p*255))
      else if (hi.eq.2) then
         FRGB(3)=toByte(int(p*255))         
         FRGB(2)=toByte(int(v*255))
         FRGB(1)=toByte(int(t*255))
      else if (hi.eq.3) then
         FRGB(3)=toByte(int(p*255))        
         FRGB(2)=toByte(int(q*255))
         FRGB(1)=toByte(int(v*255))
      else if (hi.eq.4) then
         FRGB(3)=toByte(int(t*255))        
         FRGB(2)=toByte(int(p*255))
         FRGB(1)=toByte(int(v*255))
      else if (hi.eq.5) then
         FRGB(3)=toByte(int(v*255))        
         FRGB(2)=toByte(int(p*255))
         FRGB(1)=toByte(int(q*255))
      end if
      end subroutine
      
      
      
