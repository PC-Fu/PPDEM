	subroutine ReadAngFile(nAng,angSequence,FileName,lName)


	implicit none
	
	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadAngFile
	 !DEC$ ATTRIBUTES ALIAS:'ReadAngFile' :: ReadAngFile
	 !DEC$ ATTRIBUTES Reference :: nAng,angSequence,FileName
	 
      integer nAng,lName, iAng
      double precision angSequence(0:1000000)
      
	CHARACTER*(lName) Filename
      
      open (119, file=FileName)
      
      read (119,*) nAng
      
      
      do iAng=0,nAng-1
      
        read(119,*) angSequence(iAng)
     
      end do

	
      close (119)
      
      end subroutine