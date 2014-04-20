      subroutine AutoCellCenter(numCell,xPt,iEleCell,nEle,
     $ xEle,yEle,limitAll,xGrid,nGridX,nGridY,nEleGrid,
     $ LEG,maxNEleGrid,flagEffCell)
       
       ! Find the element closest to the given point. 
       ! Strain cells (triangles) will be constructed around this element in IniStrainCell.
       
       implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: AutoCellCenter
	 !DEC$ ATTRIBUTES ALIAS:'AutoCellCenter' :: AutoCellCenter
	 !DEC$ ATTRIBUTES Reference :: 
     $	numCell,xPt,iEleCell,nEle,
     $  xEle,yEle,limitAll,xGrid,nGridX,nGridY,nEleGrid,
     $  LEG,maxNEleGrid,flagEffCell
     
      integer nEle,nGridX,nGridY,maxNEleGrid,numCell
	
	integer iEleCell(numCell),
     $	nEleGrid(nGridX,nGridY),lEG(nGridX,nGridY,maxNEleGrid)
	
	double precision xGrid,xEle(nEle),yEle(nEle),limitAll(4)
      
      integer iCol,iRow,iList,iEle,iCell,flagEffCell(numCell)
      !,nGridR,eleBuffer(10000),iBuffer,eleTemp,eleA,eleB,eleC,iSeed,nEleTop,iTop,iSort,flagEffCell(numCell)
      
      double precision distElePt,xPt(numCell,2),minDist
     
      flagEffCell=-1
      
      do iCell=1,numCell
      
        iCol=(xPt(iCell,1)-limitAll(1))/xGrid+1
        iRow=(xPt(iCell,2)-limitAll(3))/xGrid+1
      
        minDist=sqrt((xPt(iCell,1)-xEle(1))**2
     $          +(xPt(iCell,2)-yEle(1))**2)

      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!!!  Search all elements in the same cell as the given point and find the closest one
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                  
        do iList=1,nEleGrid(iCol,iRow)
            
                    
            iEle=LEG(iCOl,iRow,iList)
            distElePt=sqrt((xPt(iCell,1)-xEle(iEle))**2
     $          +(xPt(iCell,2)-yEle(iEle))**2)
        
            if (distElePt.lt.minDist) then
                flagEffCell(iCell)=0
                minDist=distElePt
                iEleCell(iCell)=iEle
        
            end if        

        end do
      end do
      
      end subroutine