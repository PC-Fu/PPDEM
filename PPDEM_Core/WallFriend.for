	subroutine WallFrd(nEle,nActEle,xEle,yEle,rEle,nVertex,xVertex,yVertex,
     $			nWall,x1Wall,x2Wall,y1Wall,y2Wall,nWallFrd,lWallFrd,
     $			maxGap,hSector,flagDebug)
	!USE DFPORT 
      USE IFPORT

	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: WallFrd
	 !DEC$ ATTRIBUTES ALIAS:'WallFrd' :: WallFrd
	 !DEC$ ATTRIBUTES Reference :: 
     $          nEle,nActEle,xEle,yEle,rEle,nVertex,xVertex,yVertex,
     $			nWall,x1Wall,x2Wall,y1Wall,y2Wall,nWallFrd,lWallFrd,
     $			maxGap,hSector,flagDebug
     
     
	integer nEle,nActEle,nWall,flagDebug

	double precision xEle(nEle),yEle(nEle),rEle(nEle),
     $	xVertex(nEle,10),yVertex(nEle,10),maxGap,distWE,hSector(nEle)
	
	double precision x1Wall(nWall),x2Wall(nWall),
     $	y1Wall(nWall),y2Wall(nWall),x3,y3

	integer nVertex(nEle),nWallFrd,lWallFrd(nWall*nEle,2)

	integer iWall,iEle,iVertex,flagFrd

	integer nPA

	double precision xPA(10),yPA(10)
	
	double precision time111
	nWallFrd=0
      !call clockx(time111)
      !!write (10000,*) "strating wallFrd",time111

	do iWall=1,nWall
		do iEle=1,nActEle

			call PtLine(xEle(iEle),yELe(iEle),x1Wall(iWall),y1Wall(iWall),
     $			x2Wall(iWall),y2Wall(iWall),x3,y3,distWE)

			if ((x3.gt.max(x1Wall(iWall),x2Wall(iWall))+1e-12).or.
     $				(x3.lt.min(x1Wall(iWall),x2Wall(iWall))-1e-12).or.
     $				(y3.gt.max(y1Wall(iWall),y2Wall(iWall))+1e-12).or.
     $				(y3.lt.min(y1Wall(iWall),y2Wall(iWall))-1e-12).or.
     $				(distWE.gt.(rEle(iEle)+maxGap))) then

				! the outer bounding circle is too far away for the wall
				flagFrd=0
			
			else

				if (nVertex(iEle).eq.0) then
					nWallFrd=nWallFrd+1
					lWallFrd(nWallFrd,1)=iWall
					lWallFrd(nWallFrd,2)=iEle
					
				
				else if (nVertex(iEle).gt.2) then  ! check all the vertexes of this polygon
					
					nPA=nVertex(iEle)
					do iVertex=1,nPA+1
						xPA(iVertex)=xVertex(iEle,iVertex)
						yPA(iVertex)=yVertex(iEle,iVertex)
					end do
					
					call	PWDist(nPA,xPA,yPA,x1Wall(iWall),y1Wall(iWall),
     $					x2Wall(iWall),y2Wall(iWall),maxGap+hSector(iEle),flagFrd)
					
					if (flagFrd.eq.1) then
					   nWallFrd=nWallFrd+1
					   lWallFrd(nWallFrd,1)=iWall
					   lWallFrd(nWallFrd,2)=iEle
					end if

						
				end if  ! circle or polygon

			end if		! whether the bounding surface is far away
		end do ! iEle=1,nActEle

	end do  !iWall=1,nWall


	
	!call clockx(time111)
      !!write (10000,*) "finishing wallFrd",time111

	end subroutine