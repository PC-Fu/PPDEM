      Subroutine Value2Gray(relaValue,FRGB)
      implicit none 
      
      double precision relaValue
      Integer FRGB(3)

        FRGB=255-255*relaValue
      
      end subroutine