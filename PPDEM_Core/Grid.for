	subroutine Grid(nEle,nActEle,nVertex,xEle,yEle,rEle,xVertex,yVertex,
     $   nGridX,nGridY,nEleGrid,lEG,xGrid,boundEle,
     $   limitAll,maxNEleGrid)
      USE IFPORT

	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: Grid
	 !DEC$ ATTRIBUTES ALIAS:'Grid' :: Grid
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,nActEle,nVertex,xEle,yEle,rEle,xVertex,yVertex,
     $   nGridX,nGridY,nEleGrid,lEG,xGrid,boundEle,
     $   limitAll,maxNEleGrid
     
	integer nEle,nActEle,nGridX,nGridY,maxNEleGrid
	integer nVertex(nEle)
	integer lEG(nGridX,nGridY,maxNEleGrid),nEleGrid(nGridX,nGridY)

	double precision xEle(nEle),yEle(nEle),rEle(nEle),xVertex(nEle,10)
     $	,yVertex(nELe,10),xGrid,boundEle(nEle,4),
     $	limitAll(4)
	! xEG= list of element in each cell
	! nEleGrid = number of element in each cell
	! lGrid=dimension of each grid
	! lEG=list of elements in each grid
	! boundEle = the bounding rectangle of the element in the sequence of xmin, xmax, ymin, ymax
	! limitAll = the bounding rectangle of the assembly of all elements


	integer iEle,iInt,jInt,iVertex
	
	double precision time111

      !call clockx(time111)
      !!write (10000,*) "strating Grid",time111

	nEleGrid=0
	lEG=0
 
	do iEle=1,nActEle
	
		iInt=min(max(int((xEle(iEle)-limitAll(1))/xGrid+1),1),nGridX)
		jInt=min(max(int((yEle(iEle)-limitAll(3))/xGrid+1),1),nGridY)
		! Sometimes location of certain particles goes wild, possibly due to memory error
		nEleGrid(iInt,jInt)=nEleGrid(iInt,jInt)+1
		lEG(iInt,jInt,nEleGrid(iInt,jInt))=iEle

	end do

      !call clockx(time111)
      !!write (10000,*) "finishing Grid",time111


	end subroutine