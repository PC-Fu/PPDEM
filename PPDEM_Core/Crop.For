      subroutine Crop(nEle,nActEle,xEle,yELe,rEle,nVertex,
     $ xVertex,yVertex,CAC,flagEMask)
     
      implicit none
     
       !DEC$ ATTRIBUTES DLLEXPORT :: Crop
	 !DEC$ ATTRIBUTES ALIAS:'Crop' :: Crop
	 !DEC$ ATTRIBUTES Reference :: 
     $ nEle,nActEle,xEle,yELe,rEle,nVertex,
     $ xVertex,yVertex,CAC,flagEMask
     
     
     	integer nEle,nActEle,iEle,jEle
     $	
	double precision xEle(nEle),yEle(nEle),rEle(nEle),
     $  	xVertex(nEle,10),yVertex(nEle,10),CAC(nEle,10)
     
      
      integer nVertex(nEle),flagEMask(nEle)

	
	iEle=1
	jEle=1
	
	do while (jEle.le.nActEle)
	
	  do while ((jEle.le.nActEle).and.(flagEMask(jEle).eq.0))
	  
	      jEle=jEle+1
	  
	  end do
	  
	  
	  if (flagEMask(jEle).eq.1) then
	      nVertex(iEle)=nVertex(jEle)
	      xEle(iEle)=xEle(jEle)
	      yEle(iEle)=yEle(jEle)
	      rEle(iEle)=rEle(jEle)
	      xVertex(iEle,:)=xVertex(jEle,:)
	      yVertex(iEle,:)=yVertex(jEle,:)
	      CAC(iEle,:)=CAC(jEle,:)
    	  
	      iEle=iEle+1
	      jEle=jEle+1
	  
	  end if
	
	end do
	
	nActEle=iEle-1
	 
	end subroutine
