	subroutine ReadTrace(nEle,nActEle,xEleTrace,yEleTrace,qEleTrace,
     $   nStep)
	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadTrace
	 !DEC$ ATTRIBUTES ALIAS:'ReadTrace' :: ReadTrace


	
	integer nEle,nActEle,iStep,nStep,nRcdStep,iSkip,iEle
	
	double precision xEleTrace(nEle,nStep),yEleTrace(nEle,nStep),
     $   qEleTrace(nEle,nStep)

      
      nRcdStep=18
      
      


      rewind(999)
      
      do iStep=1,nStep
         read (999) nActEle,(xEleTrace(iEle,iStep),iEle=1,nActEle)
         read (999) nActEle,(yEleTrace(iEle,iStep),iEle=1,nActEle)
         read (999) nActEle,(qEleTrace(iEle,iStep),iEle=1,nActEle)
         
         do iSkip=1,nRcdStep-3
            read (999)
         end do
     
      end do
      
         

      


      end subroutine