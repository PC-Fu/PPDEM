      byte function toByte(RGBVB)
      
      ! The value of byte type is not the same in VB and Fortran
        integer RGBVB
        if (RGBVB.ge.128) then
            toByte=RGBVB-256
        else
            toByte=RGBVB
        end if
      
      
      return
      end function