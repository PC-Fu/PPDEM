      subroutine MaskCrop(nEle,nActEle,xEle,yELe,
     $   flagEMask,xMaskCrop,nPtMask,nEleMasked)
     
      implicit none
     
       !DEC$ ATTRIBUTES DLLEXPORT :: MaskCrop
	 !DEC$ ATTRIBUTES ALIAS:'MaskCrop' :: MaskCrop
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,nActEle,xEle,yELe,
     $   flagEMask,xMaskCrop,nPtMask,nEleMasked
     
     
     	integer nEle,nActEle,iEle,iPt,nEleMasked
     $	
	double precision xEle(nEle),yEle(nEle),xMaskCrop(10,2),xPA(10),yPA(10),
     $   lTemp
     
      
      integer flagEMask(nEle),nPtMask
      
      flagEMask=0
      nEleMasked=0
      
      if (nPtMask.eq.0) then
      
        do iEle=1,nActEle
        
            lTemp=(xEle(iEle)-xMaskCrop(1,1))**2
     $         +(yEle(iEle)-xMaskCrop(1,2))**2
     
            if (lTemp.lt.(xMaskCrop(2,1)**2)) then
                flagEMask(iEle)=1
                nEleMasked=nEleMasked+1
            end if
        
        end do
      
      end if
      
      if (nPtMask.ge.3) then
        
        xPA=xMaskCrop(:,1)
        yPA=xMaskCrop(:,2)
        
        
        do iEle=1,nActEle
        
           call PtPoly(xEle(iEle),yEle(iEle),nPtMask,
     $        xPA,yPA,flagEMask(iEle))
           nEleMasked=nEleMasked+flagEMask(iEle)

        end do

      
      end if


	end subroutine
	 
