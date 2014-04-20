      subroutine MaskStrainCell(numCell,nActCell,nEle,
     $ xEle,yEle,eleStnCell,cellAct,flagEffCell,
     $ nNodeMask,Mask)
       
      ! Find a triangle around the given elements.  
      ! The triangles should be optimized to 1) match the given sizes "rStrainCell" and 2) to be as close to regular triangle as possible.
     
      implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: MaskStrainCell
	 !DEC$ ATTRIBUTES ALIAS:'MaskStrainCell' :: MaskStrainCell
	 !DEC$ ATTRIBUTES Reference :: 
     $ numCell,nActCell, nEle,
     $ xEle,yEle,eleStnCell,cellAct,flagEffCell,
     $ nNodeMask,Mask
	 
      integer nEle,numCell,eleStnCell(numCell,3),nActCell
	
	
      double precision xEle(nEle),yEle(nEle)
      
      integer flagEffCell(numCell),cellAct(nEle*2),nNodeMask,Mask(10)
      
      integer iNode,iEle,iCell,flagNdInMask(3)
      
      double precision xPA(10),yPA(10)
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!     
      !!!!!!!! Initialize the mask.                          !!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
         do iNode=1,nNodeMask
            xPA(iNode)=xEle(Mask(iNode))
            yPA(iNode)=yEle(Mask(iNode))
         end do
         xPA(nNodeMask+1)=xEle(Mask(1))
         yPA(nNodeMask+1)=yEle(Mask(1))
         
      cellAct=0
      nActCell=0
      do iCell=1,numCell
        if (flagEffCell(iCell).eq.1) then
            flagNdInMask=0
            do iNode=1,3
                iEle=eleStnCell(iCell,iNode)
                call PtPoly(xEle(iEle),yEle(iEle),nNodeMask,
     $              xPA,yPA,flagNdInMask(iNode))
            end do
            
            if ((flagNdInMask(1)+flagNdInMask(2)+
     $           flagNdInMask(3)).eq.3) then
                nActCell=nActCell+1
                cellAct(nActCell)=iCell-1
            end if
        end if
      end do      
      



      end subroutine