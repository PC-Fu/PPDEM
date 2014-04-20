      subroutine FindOldPair(nEle,iEle,jEle,nEleFrd,
     $      oldPairIndex,oldIPair,alwNEleFrd)

      implicit none
      
      integer nEle,iEle,jEle,nEleFrd,alwNEleFrd
      integer  oldPairIndex(nEle,alwNEleFrd,2),oldIPair
      
      integer iEleFrd
      
      oldIPair=0
      iEleFrd=0
      
      do While ((iEleFrd.lt.nEleFrd).and.(oldIPair.eq.0))
      
         iEleFrd=iEleFrd+1
         if (oldPairIndex(iEle,iEleFrd,1).eq.jEle) then
            oldIPair=oldPairIndex(iEle,iEleFrd,2)
         end if
      
      end do
      
      
      end subroutine
      