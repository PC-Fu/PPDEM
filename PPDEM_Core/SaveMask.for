	subroutine SaveMask(flagSave,nNodeMask,Mask,Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: SaveMask
	 !DEC$ ATTRIBUTES ALIAS:'SaveMask' :: SaveMask
	 !DEC$ ATTRIBUTES Reference :: 
     $	flagSave,nNodeMask,Mask,Filename
	
	
	integer flagSave,nNodeMask,Mask(10),lName,i
	
      CHARACTER*(lName) Filename

	open (187, file=filename)
	
	if (flagSave.eq.1) then    ! saving, otherwise importing
	  
	  write (187,*)  nNodeMask
	  
	  do i=1,nNodeMask
	  
	      write (187,*)  Mask(i)
	  
	  end do
      
      else
	
	  read (187,*)  nNodeMask
	  
	  do i=1,nNodeMask
	  
	      read (187,*)  Mask(i)
	  
	  end do
	  
	  do i=nNodeMask+1,10
	  
	      Mask(i)=Mask(1)
	      	  
	  end do
	  
	end if
	
	close (187)
	
	end subroutine SaveMask
