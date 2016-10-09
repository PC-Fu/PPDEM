	subroutine ReadBatchLoad(intLoadPara,realLoadPara,FileName,lName)


	implicit none
	
	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadBatchLoad
	 !DEC$ ATTRIBUTES ALIAS:'ReadBatchLoad' :: ReadBatchLoad
	 !DEC$ ATTRIBUTES Reference :: intLoadPara,realLoadPara,FileName
	 
      integer intLoadPara(0:1000000,0:8),iLoad,iPara,lName
      double precision realLoadPara(0:1000000,8)
      
	CHARACTER*(lName) Filename
      
      open (113, file=FileName)
      
      read (113,*) intLoadPara(0,0)
      
      intLoadPara(0,0)=min(intLoadPara(0,0),1000000)
      read (113,*) ! Skip one line
      
      do iLoad=1,intLoadPara(0,0)
      
        read(113,*) (intLoadPara(iLoad,iPara),iPara=0,8),
     $              (realLoadPara(iLoad,iPara),iPara=1,8)
     
      end do

	
      close (113)
      
      end subroutine