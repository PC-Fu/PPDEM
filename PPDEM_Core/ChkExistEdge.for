      subroutine ChkExistEdge(nMax,jPt,nEdgeiPt,
     $       iEdgeiPt,i2ndEnd,flagExist)
      
      implicit none
      
      integer nMax,jPt, nEdgeiPt, flagExist,
     $  i2ndEnd(nMax), iEdgeiPt(nMax)
      
      integer i
      
      flagExist=0
      
      do i=1, nEdgeiPt
        if (jPt.eq.i2ndEnd(i)) then
           flagExist=iEdgeiPt(i)
        end if
      end do
      
      end subroutine
      
      
      
      subroutine ChkEleEdge(maxEdgePEle, nEdgePEle, iPtEdgePEle, 
     $  iPt, jPt, flagExist)
      implicit none
      
      integer maxEdgePEle, nEdgePEle, iPtEdgePEle(maxEdgePEle, 2)
      integer iPt, jPt, flagExist, iEdge
      
      flagExist=0
      
      iEdge=0
      
      do while ((iEdge.lt.nEdgePEle).and.(flagExist.eq.0))
        iEdge=iEdge+1
        if ( (iPtEdgePEle(iEdge,1).eq.iPt) .and. 
     $       (iPtEdgePEle(iEdge,2).eq.jPt) )  then
            flagExist=iEdge
        end if
      end do
      
      end subroutine
      
      
      
      subroutine ChkGhostExist(maxConAll, x, nGstDlnBound, 
     $ iEffGstDlnBound, xEffCon, FlagExist)
      implicit none
      integer maxConAll, i
      integer nGstDlnBound, iEffGstDlnBound(12), flagExist
      double precision x(2), xEffCon(maxConAll*2,2), dist
      
      flagExist=0
      i=0
      do while ((flagExist.eq.0).and.(i.lt.nGstDlnBound)) 
        i=i+1
        dist=(x(1)-xEffCon(iEffGstDlnBound(i),1))**2+
     $       (x(2)-xEffCon(iEffGstDlnBound(i),2))**2
        if (dist.lt.1.0e-10) then
            flagExist=iEffGstDlnBound(i)
        end if
      end do
      
      
      end subroutine
      
      subroutine ChkPtExist(nMax, iPt, nExist, list, flagExist)
      implicit none
      integer nMax, iPt, nExist, list(nMax), flagExist
      integer i
      flagExist=0
      i=0
      do while ((flagExist.eq.0).and.(i.lt.nExist))
        i=i+1
        if (iPt.eq.list(i)) then
            flagExist=1
        end if
      end do
      
      end subroutine
      
!      subroutine ChkExistSldTriEdge(maxEdgePEle, 
!                            nSldTriEdgePEle,iSldTriEdge(iEle,:),
!                            flagExist)