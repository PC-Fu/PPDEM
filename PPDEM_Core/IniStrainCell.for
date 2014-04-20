      subroutine IniStrainCell(numCell,iEleCell,rStrainCell,nEle,
     $ xEle,yEle,areaEle,limitAll,xGrid,nGridX,nGridY,nEleGrid,
     $ LEG,maxNEleGrid,eleStnCell,eleBuffer,nEleTop,wgtBuffer,
     $ flagEffCell)
       
      ! Find a triangle around the given elements.  
      ! The triangles should be optimized to 1) match the given sizes "rStrainCell" and 2) to be as close to regular triangle as possible.
     
      implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: IniStrainCell
	 !DEC$ ATTRIBUTES ALIAS:'IniStrainCell' :: IniStrainCell
	 !DEC$ ATTRIBUTES Reference :: 
     $	numCell,iEleCell,rStrainCell,nEle,xEle,yEle,
     $ areaEle,limitAll,xGrid,nGridX,nGridY,nEleGrid,LEG,maxNEleGrid,
     $  eleStnCell,eleBuffer,nEleTop,wgtBuffer,flagEffCell
     
       ! iEleCell is the element id where the strain cell (triangle) will be around.
       
      integer nEle,nGridX,nGridY,maxNEleGrid,numCell,
     $  eleStnCell(numCell,3)
	
	integer iEleCell(numCell),
     $	nEleGrid(nGridX,nGridY),lEG(nGridX,nGridY,maxNEleGrid)
	
	double precision rStrainCell,xGrid
	
      double precision xEle(nEle),yEle(nEle),areaEle(nEle),limitAll(4)
      
      integer iCol,iRow,iList,iEle,iCell,gridPt(2),nGridR,
     $ eleBuffer(10000),iBuffer,eleTemp,eleA,eleB,eleC,iSeed,nEleTop,
     $ iTop,iSort,flagEffCell(numCell)
      
      double precision distElePt,wgtBuffer(10000),wgtCell,maxWgt,
     $   iRand,wgtTemp,TriArea,tempD
     
      real ran
       
      iSeed=484392323
      
      ! flagEffCell has been initiated in AutoCellCenter
      ! =-1 if no element was the center was found (because the grid cell contains no element
      ! =0 if found
      do iCell=1,numCell
      
      if (flagEffCell(iCell).ge.0) then
      
          gridPt(1)=(xEle(iEleCell(iCell))-limitAll(1))/xGrid+1
          gridPt(2)=(yEle(iELeCell(iCell))-limitAll(3))/xGrid+1
          nGridR=rStrainCell*1.5/xGrid
          iBuffer=1  
          nEleTop=20
           
          
          !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
          !!!!!!!!!!!  Search all elements with a distance to Pt between 0.5rStrainCell and 1.5rStrainCell
          !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
          
          do iCol=max(1,gridPt(1)-nGridR),min(nGridX,gridPt(1)+nGridR)
          
            do iRow=max(1,gridPt(2)-nGridR),min(nGridY,gridPt(2)+nGridR)
                
                do iList=1,nEleGrid(iCol,iRow)
                
                if (iBuffer.le.10000) then 
                    
                    iEle=LEG(iCOl,iRow,iList)
                    distElePt=sqrt((xEle(iEle)-xEle(iEleCell(iCell)))**2
     $                        +(yEle(iEle)-yEle(iEleCell(iCell)))**2)
                    
                    if ( (distElePt.gt.(0.5*rStrainCell)) .and. 
     $               (distElePt.lt.(1.5*rStrainCell)) ) then
                    
                    eleBuffer(iBuffer)=iEle
                    wgtBuffer(iBuffer)=areaEle(iEle)**0.3
     $                      *(rStrainCell-abs(distElePt-rStrainCell))
                    iBuffer=iBuffer+1
                    
                    end if        
                    
                end if
                end do
                
            end do
          end do
          
          iBuffer=iBuffer-1
          
          !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
          !!!!!!!!! Sort the buffered element by wgtBuffer to get the top nEleTop  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
          !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
          
          if (nEleTop.lt.iBuffer) then   ! sorting
          
          
            do iTop=1,nEleTop
            
                do iSort=iTop+1,iBuffer
                    if (wgtBuffer(iSort).gt.wgtBuffer(iTop)) then
                        
                        eleTemp=eleBuffer(iTop)
                        wgtTemp=wgtBuffer(iTop)
                        eleBuffer(iTop)=eleBuffer(iSort)
                        wgtBuffer(iTop)=wgtBuffer(iSort)
                        eleBuffer(iSort)=eleTemp
                        wgtBuffer(iSort)=wgtTemp
                    
                    end if
                
                end do
            
            end do
          
          else
            nEleTop=iBuffer
          end if
          
          
          !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
          !!!!!!!!! Randomly generate a few triangular cells and pick the largest one !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
          !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
          
          maxWgt=0
          wgtCell=-1
          
          if (nEleTop.gt.0) then
          do iRand=1,3000
          
            eleA=eleBuffer(ran(iSeed)*nEleTop+1)
            eleB=eleBuffer(ran(iSeed)*nEleTop+1)
            eleC=eleBuffer(ran(iSeed)*nEleTop+1)
            
            wgtCell=TriArea(xEle(eleA),yEle(eleA),xEle(eleB),
     $          yEle(eleB),xEle(eleC),yEle(eleC))
         
            if (wgtCell.gt.maxWgt) then
            
                eleStnCell(iCell,1)=eleA
                eleStnCell(iCell,2)=eleB
                eleStnCell(iCell,3)=eleC
                maxWgt=wgtCell
                
                flagEffCell(iCell)=1
            end if
            
            
            
          end do
            !!!!!!!!!!!!!!!!!!!!!!!!!!!!
            !!! Sort the nodes 
            eleA=eleStnCell(iCell,1)
            eleB=eleStnCell(iCell,2)
            eleC=eleStnCell(iCell,3)

            tempD=xEle(eleA)*yEle(eleB)-xEle(eleB)*yEle(eleA)
     $      +xEle(eleB)*yEle(eleC)-xEle(eleC)*yEle(eleB)
     $      +xEle(eleC)*yEle(eleA)-xEle(eleA)*yEle(eleC)
         
            if (tempD.lt.0) then
                eleStnCell(iCell,2)=eleC
                eleStnCell(iCell,3)=eleB
            end if
          end if
      
      end if
      
      end do
      
      
      
      end subroutine IniStrainCell
      