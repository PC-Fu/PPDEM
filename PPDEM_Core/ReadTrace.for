	subroutine ReadTrace(nEle,nActEle,nWall,xEleTrace,yEleTrace,qEleTrace,
     $   nStep,verRead,rSldTrace,qSldTrace,frSldTrace,normSldTrace,
     $   eleSldTrace,CBSldTrace,nConSldTrace,
     $   x1Wall,x2Wall,y1Wall,y2Wall,xCon,yCon,fricRatio,tanNorm,
     $   pairCon,flagConBoun)
	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadTrace
	 !DEC$ ATTRIBUTES ALIAS:'ReadTrace' :: ReadTrace
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,nActEle,nWall,xEleTrace,yEleTrace,qEleTrace,
     $   nStep,verRead,rSldTrace,qSldTrace,frSldTrace,
     $   eleSldTrace,CBSldTrace,nConSldTrace,
     $   x1Wall,x2Wall,y1Wall,y2Wall,xCon,yCon,fricRatio,tanNorm,
     $   pairCon,flagConBoun
	
	integer nEle,nActEle,iStep,nStep,nRcdStep,iSkip,iEle,verRead,nWall
	
	double precision xEleTrace(nEle,nStep),yEleTrace(nEle,nStep),
     $   qEleTrace(nEle,nStep)
     
c      real rSldTrace(nEle*6,nStep),qSldTrace(nEle*6,nStep)
c     $   ,frSldTrace(nEle*6,nStep),normSldTrace(nEle*6,nStep)
     
c      integer eleSldTrace(nEle*6,nStep),nConSldTrace(nStep),
c     $ CBSldTrace(nEle*6,nStep)


      real rSldTrace(1,1),qSldTrace(1,1)
     $   ,frSldTrace(1,1),normSldTrace(nEle*6,nStep)
    
      integer eleSldTrace(1,1),nConSldTrace(1),
     $ CBSldTrace(1,1)


      double precision     x1Wall(nWall),x2Wall(nWall),y1Wall(nWall),
     $	y2Wall(nWall),xCon(nEle*10),yCon(nEle*10),
     $	fricRatio(nEle*10),tanNorm(nEle*10),aSinCos

      integer flagConBoun(nEle*10),pairCon(nEle*10,2),
     $   iWall,iCon,nCon

      CBSldTrace=1       
       
       
      if (verRead.eq.1) then
        nRcdStep=19
      else if (verRead.eq.2) then
        nRcdStep=21
      else
        nRcdStep=18
      end if
      
      


      rewind(999)
      if (verRead.gt.0) then
        read(999)
      end if
 
      
      do iStep=1,nStep
         read (999) nActEle,(xEleTrace(iEle,iStep),iEle=1,nActEle)
         read (999) nActEle,(yEleTrace(iEle,iStep),iEle=1,nActEle)
         read (999) nActEle,(qEleTrace(iEle,iStep),iEle=1,nActEle)
                  
         read (999) nWall,(x1Wall(iWall),iWall=1,nWall)
         read (999) nWall,(y1Wall(iWall),iWall=1,nWall)
         read (999) nWall,(x2Wall(iWall),iWall=1,nWall)
         read (999) nWall,(y2Wall(iWall),iWall=1,nWall)
         
         read (999) nCon,(xCon(iCon),iCon=1,nCon)
         read (999) nCon,(yCon(iCon),iCon=1,nCon)
         read (999) 
         read (999) 
         read (999) 
         read (999) nCon,(fricRatio(iCon),iCon=1,nCon)
         if (verRead.eq.1) then
             read (999) 
         end if
         if (verRead.eq.2) then
             read (999) nCon,(tanNorm(iCon),iCon=1,nCon)
             read (999) nCon,(flagConBoun(iCon),iCon=1,nCon)
             read (999) nCon,((pairCon(iCon,1),pairCon(iCon,2)),
     $        iCon=1,nCon)
         end if
         
         do iSkip=1,5
            read (999)
         end do
         
         ! Temporarily disable this block to save memory
!         nConSldTrace(iStep)=nCon*2
!         
!         do iCon=1,nCon
!         
!            
!            if ((flagConBoun(iCon).eq.0).or.
!     $         (flagConBoun(iCon).eq.2)) then    ! For contact type 0 and 2, the first object is always an element
!                
!                eleSldTrace(iCon*2-1,iStep)=pairCon(iCon,1)
!                frSldTrace(iCon*2-1,iStep)=fricRatio(iCon)
!                rSldTrace(iCon*2-1,iStep)=sqrt(  
!     $              (xCon(iCon)-xEleTrace(pairCon(iCon,1),iStep))**2
!     $             +(yCon(iCon)-yEleTrace(pairCon(iCon,1),iStep))**2)
!     
!                qSldTrace(iCon*2-1,iStep)=aSinCos(
!     $              (xCon(iCon)-xEleTrace(pairCon(iCon,1),iStep))
!     $             /rSldTrace(iCon*2-1,iStep),
!     $              yCon(iCon)-yEleTrace(pairCon(iCon,1),iStep))  
!     $             -qEleTrace(pairCon(iCon,1),iStep)   
!     
!                CBSldTrace(iCon*2-1,iStep)=0 
!                
!                normSldTrace(iCon*2-1,iStep)=tanNorm(iCon)
!     
!            end if
!            
!              
!            if (flagConBoun(iCon).eq.0) then     ! For contact type 0, the second object is an element too
!                
!                eleSldTrace(iCon*2,iStep)=pairCon(iCon,2)
!                
!                frSldTrace(iCon*2,iStep)=fricRatio(iCon)
!                
!                rSldTrace(iCon*2,iStep)=sqrt(  
!     $              (xCon(iCon)-xEleTrace(pairCon(iCon,2),iStep))**2
!     $             +(yCon(iCon)-yEleTrace(pairCon(iCon,2),iStep))**2)
!     
!                qSldTrace(iCon*2,iStep)=aSinCos(
!     $              (xCon(iCon)-xEleTrace(pairCon(iCon,2),iStep))
!     $             /rSldTrace(iCon*2,iStep),
!     $              yCon(iCon)-yEleTrace(pairCon(iCon,2),iStep))  
!     $             -qEleTrace(pairCon(iCon,2),iStep)   
!     
!                CBSldTrace(iCon*2,iStep)=0
!                normSldTrace(iCon*2,iStep)=tanNorm(iCon)
!
!                
!            else if (flagConBoun(iCon).eq.2) then     ! For contact type 2, the second object is a wall, q is not used, r is the normalized distance to one end of the wall
!                
!                eleSldTrace(iCon*2,iStep)=pairCon(iCon,2)   ! The Wall number
!                
!                frSldTrace(iCon*2,iStep)=fricRatio(iCon)
!                
!                rSldTrace(iCon*2,iStep)=sqrt(  
!     $              (xCon(iCon)-x1Wall(pairCon(iCon,2)))**2
!     $             +(yCon(iCon)-y1Wall(pairCon(iCon,2)))**2)
!     $            /sqrt(   
!     $              (x2Wall(pairCon(iCon,2))-x1Wall(pairCon(iCon,2)))**2
!     $            +(y2Wall(pairCon(iCon,2))-y1Wall(pairCon(iCon,2)))**2)
!     
!                CBSldTrace(iCon*2,iStep)=2
!
!     
!            end if
!
!         
!         end do
         
         
     
      end do
      
      rewind(999)

      


      end subroutine