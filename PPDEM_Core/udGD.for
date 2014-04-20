      subroutine UdGD(nEle,xEle,yEle,qEle,nHLine,nVLine,
     $   nHPtGD,nVPtGD,iHElePtGD,iVElePtGD,rqiHPtGD,rqiVPtGD,
     $   xHPtGD,xVPtGD)
     
      Implicit none
      !DEC$ ATTRIBUTES DLLEXPORT :: UdGD
	!DEC$ ATTRIBUTES ALIAS:'UdGD' :: UdGD
	 !DEC$ ATTRIBUTES Reference :: 
     $ nEle,xEle,yEle,qEle,nHLine,nVLine,
     $   nHPtGD,nVPtGD,iHElePtGD,iVElePtGD,rqiHPtGD,rqiVPtGD,
     $   xHPtGD,xVPtGD
     
     
     
	integer nEle,nHLine,nVLine
	
	double precision xEle(nEle),yEle(nEle),qEle(nEle)

	integer nHPtGD(nHLine),nVPtGD(nVLine),
     $   iHElePtGD(nHLine,1000),iVElePtGD(nVLine,1000)
     
      double precision rqiHPtGD(nHLine,1000,2),rqiVPtGD(nVLine,1000,2),
     $   xHPtGD(nHLine,1000,2),xVPtGD(nVLine,1000,2)
     
      integer iLine,iPt,iEle
     
      do iLine=1,nHLine
         do iPt=1,nHPtGD(iLine)
            iEle=iHElePtGD(iLine,ipt)
            xHptGD(iLine,iPt,1)=xEle(iEle)+rqiHPtGD(iLine,iPt,1)*
     $       cos(qEle(iEle)+rqiHPtGD(iLine,iPt,2))
            xHptGD(iLine,iPt,2)=yEle(iEle)+rqiHPtGD(iLine,iPt,1)*
     $       sin(qEle(iEle)+rqiHPtGD(iLine,iPt,2))
      
         end do ! iPt
      end do ! iLine
      
      do iLine=1,nVLine
         do iPt=1,nVPtGD(iLine)
            iEle=iVElePtGD(iLine,ipt)
            xVptGD(iLine,iPt,1)=xEle(iEle)+rqiVPtGD(iLine,iPt,1)*
     $       cos(qEle(iEle)+rqiVPtGD(iLine,iPt,2))
            xVptGD(iLine,iPt,2)=yEle(iEle)+rqiVPtGD(iLine,iPt,1)*
     $       sin(qEle(iEle)+rqiVPtGD(iLine,iPt,2))
      
         end do ! iPt
      end do ! iLine

      end subroutine