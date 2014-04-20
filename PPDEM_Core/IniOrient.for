      subroutine IniOrient(nEle,nActEle,xEle,yEle,nVertex,xVertex,
     $	yVertex,qiVertex,rVertex,rEle,qEle,hSector,rqCE,xCE,
     $   BoundEle,iniOri,eLong)
      implicit none
      
       !DEC$ ATTRIBUTES DLLEXPORT :: IniOrient
	 !DEC$ ATTRIBUTES ALIAS:'IniOrient' :: IniOrient
	 !DEC$ ATTRIBUTES Reference :: 
     $  nEle,nActEle,xEle,yEle,nVertex,xVertex,
     $	yVertex,qiVertex,rVertex,rEle,qEle,hSector,rqCE,xCE,
     $   BoundEle,iniOri,eLong
     
     
      integer nEle,nActEle
	integer nVertex(nEle)

	double precision xEle(nEle),yEle(nEle),qEle(nEle),
     $	xVertex(nEle,10),yVertex(nEle,10),qiVertex(nEle,10),
     $	rVertex(nEle,10),rEle(nEle),hSector(nEle),iniOri(nEle),
     $   rqCE(nEle,10,4),xCE(nEle,10,2),boundEle(nEle,4),
     $   Elong(nEle),tempElong
     
      integer iEle,iAngle
     
      iniOri=0
      Elong=1.
      hSector=hSector*0.7
      
      do iAngle=1,180
      
         qEle=(iAngle+0.0)/180*3.1415926
         
	   call udVertex(nEle,nActEle,xEle,yEle,qEle,qiVertex,rVertex,
     $			   nVertex,xVertex,yVertex,rqCE,xCE,1)  
     
	   call BoundBox(nEle,nActEle,xEle,yEle,rEle,nVertex,xVertex,yVertex,
     $	boundEle,hSector)
     
     
         do iEle=1,nActEle
            
            tempElong=abs((boundEle(iEle,2)-boundele(iEle,1))/
     $         (boundEle(iEle,4)-boundele(iEle,3)))
            if ((tempElong.gt.elong(iELe))
     $      .and.(nVertex(iEle)>0))then
     
               elong(iEle)=tempElong
               iniOri(iEle)=3.1415926-qEle(iEle)
                 
            end if
         
         end do
         
         
      end do
      
      qEle=0
         
	   call udVertex(nEle,nActEle,xEle,yEle,qEle,qiVertex,rVertex,
     $			   nVertex,xVertex,yVertex,rqCE,xCE,1)  

      hsector=hsector/0.7
      end subroutine