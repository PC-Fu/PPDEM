      subroutine PreInit(nActEle,nWall,FileName,lName)
      implicit none
      
      !DEC$ ATTRIBUTES DLLEXPORT :: PreInit
	!DEC$ ATTRIBUTES ALIAS:'PreInit' :: PreInit
	!DEC$ ATTRIBUTES REFERENCE :: nActEle,nWall,FileName

	integer nActEle,nWall,iEle,lName
	double precision temp
	
	
      CHARACTER*(lName) FileName
      
      open (132,file=FileName)
      
      read (132,*) nActEle
      
      do iEle=1,nActEle
         read (132,*) temp
      end do
      
      read (132,*) nWall
      end subroutine

      
      