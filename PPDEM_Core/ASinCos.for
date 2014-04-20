      double precision function ASinCos(cosA,signSinA)
      implicit none
      double precision cosA,signSinA
      ASinCos=Dacos(cosA)
      if (signSinA.lt.0) then
         ASinCos=6.283185307-ASinCos
      end if
      return
      end function