	subroutine Initiate(nEle,nActEle,xEle,yEle,qEle,nVertex,xVertex,
     $	yVertex,qiVertex,rVertex,rEle,areaEle,MIEle,vxEle,vyEle,vqEle,
     $	nWall,x1Wall,x2Wall,y1Wall,y2Wall,dEleMax,flagPairCohe,
     $   alwNEleFrd,minREle,rqCE,xCE,hSector,flagNewTest,Params,CAC,
     $   volSld,FileName,lName)

	! nEle = define 
	! nActEle = number of element, including polygons and circles
	! xEle, yEle = coordinates of centroids of elements
	! nVertex = num. of vertexes of each element, 0 means circle
	! qVertex, rVertex = theta,r, local polar coordinates of vertexes of each element
	! rElem = radius of the bounding circle of each element
	!	nWall = num. of walls
	!	x1Wall,x2Wall,y1Wall,y2Wall = coordinates of walls
	! volSld = total solid volume of the assembly

	implicit none
	
	 !DEC$ ATTRIBUTES DLLEXPORT :: Initiate
	 !DEC$ ATTRIBUTES ALIAS:'Initiate' :: Initiate
	 !DEC$ ATTRIBUTES Reference :: 
     $	 nEle,nActEle,xEle,yEle,qEle,nVertex,xVertex,
     $	 yVertex,qiVertex,rVertex,rEle,areaEle,MIEle,vxEle,vyEle,vqEle,
     $	 nWall,x1Wall,x2Wall,y1Wall,y2Wall,dEleMax,flagPairCohe,
     $   alwNEleFrd,minREle,rqCE,xCE,hSector,flagNewTest,Params,CAC,
     $   volSld,FileName
	
	integer nEle,nWall,alwNEleFrd,nActEle,i,lName
	integer nVertex(nEle)
	integer iEle,iVertex,iWall

	double precision xEle(nEle),yEle(nEle),qEle(nEle),
     $	xVertex(nEle,10),yVertex(nEle,10),qiVertex(nEle,10),
     $	rVertex(nEle,10),rEle(nEle),dEleMax,minREle,scale,temp,
     $  Params(20),volSld

	double precision areaEle(nEle),MIEle(nEle)
	double precision vxEle(nEle),vyEle(nEle),vqEle(nEle)

	double precision x1Wall(nWall),x2Wall(nWall),
     $	y1Wall(nWall),y2Wall(nWall)

	double precision xVinP(10),yVinP(10)

	integer flagPairCohe(nEle*alwNEleFrd),flagNewTest
	
	double precision rqCE(nEle,10,4),xCE(nEle,10,2),
     $	CAC(nEle,10),hSector(nEle)
	! rqCE = polar coordinates of the edge curve centers.  
	! rqCE(,,1) is the r,rqCE(,,2) is the theta angle. Both are local polar coordinate of center of this circle.
	! rqCE(,,3) is the radius of this curve; rqCE(,,4)=start angle
	! xCE = Cartesian coordinates.  xCE needs to be updated at the end of every time step.
	
	
	CHARACTER*(lName) Filename
	
      if (flagNewTest.eq.1) then
	    xVertex=0
	    yVertex=0
	    CAC=0.001

	   flagPairCohe=0
	   Params=0

	   open (100, file=FileName)

	   read (100,*) temp,scale
   	
	   vxEle=0 
	   vyEle=0
	   vqEle=0
	   minREle=1e6

	   do iEle=1,nActEle

		   read (100,*) nVertex(iEle)
		   
		   backspace (100)
		   
		   if (nVertex(iEle).gt.2) then
		   
		      read (100,*) nVertex(iEle), (xVertex(iEle,iVertex),
     $		    yVertex(iEle,iVertex),iVertex=1,nVertex(iEle))  
     $          ,(CAC(iEle,iVertex),iVertex=1,nVertex(iEle))

  	
   	 	   else 
   	 	   
   	 	      read (100,*) nVertex(iEle), xEle(iEle),yEle(iEle),rEle(iEle)
   	 	      nVertex(iEle)=0


		   end if



	   end do ! iEle
   	
	   xVertex=xVertex/scale
	   yVertex=yVertex/scale
	   xEle=xEle/scale
	   yEle=yEle/scale
	   rEle=rEle/scale

	   read (100,*)  nWall

	   do iWall=1, nWall

		   read (100,*) x1Wall(iWall),y1Wall(iWall),
     $		x2Wall(iWall),y2Wall(iWall) 

	   end do ! iWall=1,nWall
   	
	   x1Wall=x1Wall/scale
	   x2Wall=x2Wall/scale
	   y1Wall=y1Wall/scale
	   y2Wall=y2Wall/scale
	   
	   Read (100,*) (Params(i),i=1,20)	
	   !CAC=Params(15)

	end if
	
	
	
	do iEle=1,nActEle
	   if (nVertex(iEle).gt.2) then
		   do iVertex=1,nVertex(iEle)
			   xVinP(iVertex)=xVertex(iEle,iVertex)
			   yVinP(iVertex)=yVertex(iEle,iVertex)
		   end do
		   !call sortVinP(xVinP,yVinP,nVertex(iEle))
		   do iVertex=1,nVertex(iEle)
			   xVertex(iEle,iVertex)=xVinP(iVertex)
			   yVertex(iEle,iVertex)=yVinP(iVertex)
		   end do

	   end if


	   xVertex(iEle,nVertex(iEle)+1)=xVertex(iEle,1)
	   yVertex(iEle,nVertex(iEle)+1)=yVertex(iEle,1)
	   

	end do

	call PolarEle(nEle,nActEle,xEle,yEle,qEle,nVertex,qiVertex,rVertex,
     $	rEle,areaEle,MIEle,xVertex,yVertex,rqCE,xCE,CAC,hSector)	
	
	dEleMax=maxval(rEle)*2
	
	volSld=0
	
	do iEle=1,nActEle
	   volSld=volSld+areaEle(iEle)
	   minREle=min(minREle,rEle(iEle))
	end do
	
	close (100)

	end subroutine 