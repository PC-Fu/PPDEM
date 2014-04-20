      subroutine SortCon2Ele (nEle, nCon, maxConPEle,
     $          pairCon, nConPEle, iConPEle, flagConBoun) 
      
      implicit none
      
      integer nEle, nActEle, nCon, maxConPEle
      
      
      integer pairCon(nEle*10,2), flagConBoun(nEle*10)
      
      integer nConPEle(nEle), iConPEle(nEle,maxConPEle)
      
      integer i,iEle, iCon
      
      nConPEle=0
      iConPEle=0
      
      do iCon=1,nCon
        if (flagConBoun(iCon).eq.0) then 
            do i=1,2
                iEle=PairCon(iCon,i)
                if (nConPEle(iEle).lt.maxConPEle) then
                    nConPEle(iEle)=nConPEle(iEle)+1
                    iConPEle(iEle, nConPEle(iEle))=iCon
                    
                end if
            end do
        else if (flagConBoun(iCon).eq.2) then 
            iEle=PairCon(iCon,1)
            if (nConPEle(iEle).lt.maxConPEle) then
                nConPEle(iEle)=nConPEle(iEle)+1
                iConPEle(iEle, nConPEle(iEle))=iCon
            end if
        end if
      end do
      
      
      end subroutine SortCon2Ele
      