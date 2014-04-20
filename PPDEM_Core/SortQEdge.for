      subroutine SortQEdge(nVPA,nVPB,EdgePair,qPair)
      implicit none
      integer nVPA,nVPB,i,j
      integer EdgePair(nVPA*nVPB,2),tempPair(2)
      double precision qPair(nVPA*nVPB),qTemp
      
      do i=1,nVPA*NVPB-2
        do j=1,nVPA*NVPB-i
            if (qPair(j).gt.qPair(j+1)) then
                qtemp=qPair(j+1)
                qPair(j+1)=qPair(j)
                qPair(j)=qtemp
                tempPair(1)=EdgePair(j+1,1)
                tempPair(2)=EdgePair(j+1,2)
                EdgePair(j+1,1)=EdgePair(j,1)
                EdgePair(j+1,2)=EdgePair(j,2)
                EdgePair(j,1)=TempPair(1)
                EdgePair(j,2)=TempPair(2)

             end if
                
      
        end do
      end do
      
      end subroutine
      

