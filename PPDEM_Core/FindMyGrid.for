      subroutine FindMyGrid(x1,y1,x2,y2,
     $              maxNGrid,x0Grid,lGrid,myGrid)
      implicit none
      integer maxNGrid(2), myGrid(2,2)
      double precision x1,y1,x2,y2,x0Grid(2,2),lGrid
      
      myGrid(1,1)=max(1,int((min(x1,x2)-x0Grid(1,1))/lGrid+1))
      myGrid(1,2)=min(maxNGrid(1),int((max(x1,x2)-x0Grid(1,1))/lGrid+1))
      myGrid(2,1)=max(1,int((min(y1,y2)-x0Grid(2,1))/lGrid+1))
      myGrid(2,2)=min(maxNGrid(2),int((max(y1,y2)-x0Grid(2,1))/lGrid+1))
      
      end subroutine