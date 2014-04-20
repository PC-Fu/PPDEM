	subroutine Snapshot(nEle,nActEle,xEle,yEle,rEle,nVertex,xVertex,
     $	yVertex,CAC,nWall,x1Wall,x2Wall,y1Wall,y2Wall,Params,Filename,
     $  lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: Snapshot
	 !DEC$ ATTRIBUTES ALIAS:'Snapshot' :: Snapshot
	 !DEC$ ATTRIBUTES Reference :: 
     $	nEle,nActEle,xEle,yEle,rEle,nVertex,xVertex,
     $	yVertex,CAC,nWall,x1Wall,x2Wall,y1Wall,y2Wall,Params,Filename
	
	
	integer nEle,nActEle,nWall,iEle,iWall,iV,i,lName

	double precision xEle(nEle),yEle(nELe),rEle(nELe),
     $	xVertex(nEle,10),yVertex(nEle,10),Params(20),CAC(nEle,10),
     $	x1Wall(nWall),x2Wall(nWall),y1Wall(nWall),y2Wall(nWall)
	
	integer nVertex(nEle)


	CHARACTER*(lName) Filename

	open (100, file=filename)
	
	write (100, *) nActEle,1

	do iEle=1,nActEle
		if (nVertex(iELe).gt.2) then
			write (100,'(I10,100E25.16)')  nVertex(iEle), (xVertex(iEle,iV),
     $		yVertex(iEle,iV),iV=1,nVertex(iEle)),
     !      (CAC(iEle,iV),iV=1,nVertex(iEle))
		else
			write (100,'(I10,100E25.16)')  2, xEle(iEle),yEle(iELe),
     $		rEle(iEle),rEle(iELe),1,1
		end if
	end do
	write (100, *) nWall


	do iWall=1,nWall
		write (100,'(1000E25.16)')	x1Wall(iWall),y1Wall(iWall),
     $		x2Wall(iWall),y2Wall(iWall)
	end do ! iWall

      write (100,'(1000E25.16)') (Params(i),i=1,20)
      write (100,'(A15,100A25)') "dt","E","globDamping","alpha","beta",
     $   "maxGap","tanTheta","pX","pY","pInt","gX","gY",
     $   "xGravity","yGravity","CAC"
      


	
	close(100)
	
	end subroutine