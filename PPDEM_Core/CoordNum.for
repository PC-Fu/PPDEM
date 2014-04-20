      subroutine CoordNum(nEle,nActEle,nCon,flagConBoun,
     $ pairCon,numECon)
     
      implicit none
     
       !DEC$ ATTRIBUTES DLLEXPORT :: CoordNum
	 !DEC$ ATTRIBUTES ALIAS:'CoordNum' :: CoordNum
	 !DEC$ ATTRIBUTES Reference :: 
     $ nEle,nActEle,nCon,flagConBoun,
     $ pairCon,numECon
     
     
           integer nEle, nActEle,iCon,iEle,nCon
      
      integer flagConBoun(nEle*10),pairCon(nEle*10,2),numECon(nEle)
      
      numECon=0
      
      
      do iCon=1,nCon
      
        if (flagConBoun(iCon).eq.0) then
        
            numECon(pairCon(iCon,1))=numECon(pairCon(iCon,1))+1
            numECon(pairCon(iCon,2))=numECon(pairCon(iCon,2))+1
            
        else if (flagConBoun(iCon).eq.2) then
        
            numECon(pairCon(iCon,1))=numECon(pairCon(iCon,1))+1
            
        end if
      
      
      end do
      
      
      
      
      
      end subroutine CoordNum
      
