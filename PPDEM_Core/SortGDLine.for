	subroutine SortGDLine(nPtGD,iElePtGD,rqiPtGD,xPtGD,iMode)
      implicit none
      
      integer nPtGD,iElePtGD(1000),iMode,i,j,iTemp
      double precision rqiPtGD(1000,2),xPtGD(1000,2),dTemp2(2)
      
      do i=1,nPtGD-2
         do j=1,nPtGD-i
            if (xPtGD(j,iMode).gt.xPtGD(j+1,iMode)) then
               
               iTemp=iElePtGD(j)
               iElePtGD(j)=iElePtGD(j+1)
               iElePtGD(j+1)=iTemp
               
               dTemp2=rqiPtGD(j,:)
               rqiPtGD(j,:)=rqiPtGD(j+1,:)
               rqiPtGD(j+1,:)=dTemp2
               
               dTemp2=xPtGD(j,:)
               xPtGD(j,:)=xPtGD(j+1,:)
               xPtGD(j+1,:)=dTemp2
            
            end if
         end do
      end do
      
      end subroutine
      	
