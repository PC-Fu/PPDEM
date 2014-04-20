      subroutine ExportCon(nEle,nCon,
     $      FCon,fricRatio,qNorm,flagFMask,iStep)
     
      implicit none    
     
       !DEC$ ATTRIBUTES DLLEXPORT :: ExportCon
	 !DEC$ ATTRIBUTES ALIAS:'ExportCon' :: ExportCon
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,nCon,
     $   FCon,fricRatio,qNorm,flagFMask,iStep
      
      integer nEle, nCon, flagFMask(nEle*10), iStep, iCon
      double precision FCon(nEle*10), fricRatio(nEle*10),
     $  qNorm(nEle*10)
      
      character *256 fileOut
      write (fileOut,'(A7,I6.6,A4)') "vis/Con",iStep,".vtk"
     
      open (3838,file=fileOut)
     
      write (3838, '(4A13)') "x","y","z","FricRatio"
      do iCon=1,nCon
        if (flagFMask(iCon).eq.1) then
            write (3838,'(4E13.5)') fricRatio(iCon)*cos(qNorm(iCon)),
     $          fricRatio(iCon)*sin(qNorm(iCon)), FCon(iCon), 
     $          fricRatio(iCon)
            write (3838,'(4E13.5)') -fricRatio(iCon)*cos(qNorm(iCon)),
     $          -fricRatio(iCon)*sin(qNorm(iCon)), FCon(iCon), 
     $          fricRatio(iCon)
        
        end if
      
      end do
      close (3838)

      end subroutine
      
