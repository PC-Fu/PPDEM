      subroutine WriteTime(timeNow,action)
      implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: WriteTime
	 !DEC$ ATTRIBUTES ALIAS:'WriteTime' :: WriteTime
      integer(4) timeNow
      character*(*) action
      write (1234,'(A30,I20)') action,timenow
      end subroutine