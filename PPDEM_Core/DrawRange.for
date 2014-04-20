      subroutine DrawRange(nEle,nActEle,limitAll,
     $   xGrid,nGridX,nGridY,xCanvas,nEleV,nConV,
     $   nCon,xCon,yCon,EleView,ConView,flagShowCon,
     $   nEleGrid,lEG,maxNEleGrid  )
      implicit none
      
      !DEC$ ATTRIBUTES DLLEXPORT :: DrawRange
	!DEC$ ATTRIBUTES ALIAS:'DrawRange' :: DrawRange
	!DEC$ ATTRIBUTES Reference :: 
     $   nEle,nActEle,limitAll,
     $   xGrid,nGridX,nGridY,xCanvas,nEleV,nConV,
     $   nCon,xCon,yCon,EleView,ConView,flagShowCon,
     $   nEleGrid,lEG,maxNEleGrid
     
     
	integer nEle,nActEle,nCon,nGridX,nGridY,flagShowCon,maxNEleGrid
	
	integer EleView(nEle),ConView(nEle*10),iEle,iCon,iGrid,jGrid,
     $  iList,gridL,gridR,gridB,gridT,nEleV,nConV,
     $	lEG(nGridX,nGridY,maxNEleGrid),nEleGrid(nGridX,nGridY)
     
     
	double precision xEle(nEle),yEle(nEle),limitAll(4),xGrid,
     $  xCanvas(4),xCon(nEle*10),yCon(nEle*10)


      if    (((xCanvas(1).lt.limitAll(1))
     $   .and.(xCanvas(2).gt.limitAll(2))
     $   .and.(xCanvas(3).lt.limitAll(3))
     $   .and.(xCanvas(4).gt.limitAll(4)))) then
     
        nEleV=nActEle
        
        do iEle=1,nActEle
        
        
            EleView(iEle)=iEle
        
        end do
        
        if (flagShowCon.eq.1) then
        
            nConV=nCon
            do iCon=1,nCon
        
                ConView(iCon)=iCon
            
            end do
        
        end if
        
      else
        
        nEleV=0
        
        
        gridL=min(max(int((xCanvas(1)-limitAll(1))/xGrid),1 ),nGridX )
        gridR=min(max(int((xCanvas(2)-limitAll(1))/xGrid+1),1 ),nGridX )
        gridB=min(max(int((xCanvas(3)-limitAll(3))/xGrid),1 ),nGridY )
        gridT=min(max(int((xCanvas(4)-limitAll(3))/xGrid+1),1 ),nGridY )
        
        do jGrid=gridB,GridT
            do iGrid=gridL,gridR


                do iList=1,nEleGrid(iGrid,jGrid)

                    nEleV=nEleV+1
                    eleView(nEleV)=LEG(iGrid,jGrid,iList)

                end do
            
            end do
        
        end do
        
        if (flagShowCon.eq.1) then
        
            nConV=0
            
            do iCon=1,nCon
            
                if ( (xCon(iCon).gt.xCanvas(1)).and.
     $               (xCon(iCon).lt.xCanvas(2)).and.
     $               (yCon(iCon).gt.xCanvas(3)).and.
     $               (yCon(iCon).lt.xCanvas(4))  ) then
                
                nConV=nConV+1
                ConView(nConV)=iCon
                
                end if
            
            end do
        
        end if
      
      end if


      end subroutine