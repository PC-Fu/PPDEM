	subroutine PlotSldTrace(nEle,nActEle,nWall,iStep,jStep,
     $   nStep,xEle,yEle,qEle,rSldTrace,qSldTrace,frSldTrace,
     $   normSldTrace,eleSldTrace,CBSldTrace,nConSldTrace,
     $   x1Wall,x2Wall,y1Wall,y2Wall,nPlotSld,nPlotRol,
     $   xPlotSld,xPlotRol)
	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: PlotSldTrace
	 !DEC$ ATTRIBUTES ALIAS:'PlotSldTrace' :: PlotSldTrace
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,nActEle,nWall,iStep,jStep,
     $   nStep,xEle,yEle,qEle,rSldTrace,qSldTrace,frSldTrace,
     $   eleSldTrace,CBSldTrace,nConSldTrace,
     $   x1Wall,x2Wall,y1Wall,y2Wall,nPlotSld,nPlotRol,
     $   xPlotSld,xPlotRol


      integer nEle, nActEle,nWall,iStep,jStep,nStep,nPlotSld,nPlotRol
      
      double precision xEle(nEle),yEle(nEle),qEle(nEle),
     $   x1Wall(nWall),x2Wall(nWall),y1Wall(nWall),y2Wall(nWall)
      
c      integer eleSldTrace(nEle*6,nStep),CBSldTrace(nEle*6,nStep),
c     $  nConSldTrace(nStep)
      integer eleSldTrace(1,1),nConSldTrace(1),
     $ CBSldTrace(1,1)
     
c      real xPlotSld(4,nEle*6*nStep),xPlotRol(2,nEle*6*nStep),
c     $   rSldTrace(nEle*6,nStep),qSldTrace(nEle*6,nStep),
c     $   frSldTrace(nEle*6,nStep),normSldTrace(nEle*6,nStep)
      real xPlotSld(1,1),xPlotRol(1,1),
     $   rSldTrace(1,1),qSldTrace(1,1),
     $   frSldTrace(1,1),normSldTrace(1,1)
      
      ! xPlotSld(3:4,:) is the corredinate for plotting the norm direction, it does not rotate with the particles
      
      integer i,j
      
      
      nPlotSld=0
      nPlotRol=0
      
!      do i=min(iStep,jStep), max(iStep,jStep)
!      
!        do j=1,nConSldTrace(i)
!        
!            if ((frSldTrace(j,i).gt.0.9999999) 
!     $       .and. (CBSldTrace(j,i).eq.0)) then
!        
!                nPlotSld=nPlotSld+1
!                
!                xPlotSld(1,nPlotSld)=xEle(eleSldTrace(j,i))
!     $              +rSldTrace(j,i)*
!     $              cos(qEle(eleSldTrace(j,i))+qSldTrace(j,i))
!
!                xPlotSld(2,nPlotSld)=yEle(eleSldTrace(j,i))
!     $              +rSldTrace(j,i)*
!     $              sin(qEle(eleSldTrace(j,i))+qSldTrace(j,i))
!                
!                xPlotSld(3,nPlotSld)=xPlotSld(1,nPlotSld)
!     $              +sign(.0001/sqrt(1+normSldTrace(j,i)**2),
!     $              normSldTrace(j,i))
!     
!                xPlotSld(4,nPlotSld)=xPlotSld(2,nPlotSld)
!     $              +sign(.0001/sqrt(1+normSldTrace(j,i)**2),
!     $              normSldTrace(j,i))*normSldTrace(j,i)
!        
!            else if ((frSldTrace(j,i).gt.0.9999999) 
!     $       .and. (CBSldTrace(j,i).eq.2)) then
!     
!                nPlotSld=nPlotSld+1
!                
!                xPlotSld(1,nPlotSld)=x1Wall(eleSldTrace(j,i))
!     $              +rSldTrace(j,i)*
!     $              (x2Wall(eleSldTrace(j,i))-x1Wall(eleSldTrace(j,i)))
!
!                xPlotSld(2,nPlotSld)=y1Wall(eleSldTrace(j,i))
!     $              +rSldTrace(j,i)*
!     $              (y2Wall(eleSldTrace(j,i))-y1Wall(eleSldTrace(j,i)))
!     
!                xPlotSld(3,nPlotSld)=xPlotSld(1,nPlotSld)
!                xPlotSld(4,nPlotSld)=xPlotSld(2,nPlotSld)
!     
!        
!            else if ((frSldTrace(j,i).le.0.9999999) 
!     $       .and. (CBSldTrace(j,i).eq.0)) then
!     
!                nPlotRol=nPlotRol+1
!                
!                xPlotRol(1,nPlotRol)=xEle(eleSldTrace(j,i))
!     $              +rSldTrace(j,i)*
!     $              cos(qEle(eleSldTrace(j,i))+qSldTrace(j,i))
!
!                xPlotRol(2,nPlotRol)=yEle(eleSldTrace(j,i))
!     $              +rSldTrace(j,i)*
!     $              sin(qEle(eleSldTrace(j,i))+qSldTrace(j,i))
!        
!            else if ((frSldTrace(j,i).le.0.9999999) 
!     $       .and. (CBSldTrace(j,i).eq.2)) then
!            
!                nPlotRol=nPlotRol+1
!                
!                xPlotRol(1,nPlotRol)=x1Wall(eleSldTrace(j,i))
!     $              +rSldTrace(j,i)*
!     $              (x2Wall(eleSldTrace(j,i))-x1Wall(eleSldTrace(j,i)))
!
!                xPlotRol(2,nPlotRol)=y1Wall(eleSldTrace(j,i))
!     $              +rSldTrace(j,i)*
!     $              (y2Wall(eleSldTrace(j,i))-y1Wall(eleSldTrace(j,i)))
!            
!            end if
!        
!        end do
!      
!      
!      end do
!      
      end subroutine
