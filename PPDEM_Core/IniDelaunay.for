c23456789 123456789 123456789 123456789 123456789 123456789 123456789 12
*MAIN
c
c     main program to -
c
c     1. read/compute a Delaunay triangulation of a set of points;
c
c     2. insert a set of points and/or a set of line segments into
c        current Delaunay triangulation and obtain a Delaunay
c        triangulation that contains the inserted points and/or line
c        segments;
c
c     3. delete a set of points that are vertices in the current
c        Delaunay triangulation and obtain a Delaunay triangulation
c        that does not contain the deleted points;
c
c     4. compute circumcenters (Voronoi vertices) of triangles in
c        final Delaunay triangulation.
c        
c
c     Author: J. Bernal
c
c     Disclaimer:
c
c     This software was developed at the National Institute of Standards
c     and Technology by employees of the Federal Government in the
c     course of their official duties. Pursuant to title 17 Section 105
c     of the United States Code this software is not subject to
c     copyright protection and is in the public domain. This software is
c     experimental. NIST assumes no responsibility whatsoever for its
c     use by other parties, and makes no guarantees, expressed or
c     implied, about its quality, reliability, or any other
c     characteristic. We would appreciate acknowledgement if the
c     software is used.


c     By Pengcheng Fu
c     The code was modified into a module for PPDEM.  The current version only
c     compute Delaunay triangulation from a set of 2D poinits.  The additional
c     functionalities of the original code have been removed.
c
c**********************************************************************
c
c     Description of some of the variables and parameters used
c     --------------------------------------------------------
c    
c     nv     Number of points or vertices in triangulation including
c            duplicate and deleted points or vertices.
c
c     ivnxt  Number of triangles in triangulation.
c
c     nvmz   Set in program to the value -nvmax-1 (nvmax is described
c            below). See description of arrays is, icon for its use.
c
c     nvmv   Used when program reads information about an existing
c            triangulation from a file. Value is the value that nvmz
c            had during the execution of this program that created
c            the triangulation about which information is being read.
c
c     np     Number of points or vertices in xy input files that will
c            not be processed when computing initial triangulation
c            from scratch and/or inserting an additional set of
c            vertices into the current triangulation (see description
c            of array ip below).
c
c     nl     Number of line segments to be inserted.
c
c     nd     Number of vertices to be deleted from triangulation.
c
c     nmax   Parameter which is the dimension of arrays x, y, is
c            (described below). Value is the maximum allowed number
c            of points or vertices in triangulation. Value at least
c            that of nv.
c
c     nvmax  Parameter which is the second dimension of array icon
c            (described below) and the dimension of arrays id, vx, vy
c            (described below). Value is the maximum allowed  number
c            of triangles in triangulation. Value at least that of
c            ivnxt. Value at least two times that of nmax for most runs.
c
c     nlmax  Parameter which is the dimension of arrays xrg, yrg,
c            xds, yds (described below). Value is the maximum allowed
c            number of line segments to be inserted into triangulation.
c            Value at least that of nl.
c
c     ndmax  Parameter which is the dimension of arrays xdl, ydl
c            (described below). Value is the maximum allowed number
c            of vertices to be deleted from triangulation. Value at
c            least that of nd.
c
c     nfmax  Parameter which is the dimension of several arrays used
c            internally during the insertion of line segments and
c            deletion of vertices (see below). Value at some multiple
c            of the square root of nmax (described above) seems to work.
c
c     nhmax  Parameter which is the dimension of array ia used
c            internally (see below). Value at least the number of
c            triangles that are affected in triangulation every time
c            a line segment is inserted or a vertex is deleted.
c            Value at some multiple of the square root of nmax
c            (described above) seems to work.
c
c     nkmax  Parameter which is the dimension of array iaze used
c            internally (see below). Value equal to the number of
c            vertices that are deleted plus 1 works.
c
c     njmax  Parameter which is the dimension of array iave used
c            internally (see below). Value at two times that of nkmax
c            seems to work.
c
c     npmax  Parameter which is the dimension of array ip (described
c            below). Value at least equal to the number of points in xy
c            input files that will not be processed when computing the
c            initial triangulation from scratch and/or inserting an
c            additional set of points into the current triangulation.
c
c     epf    Tolerance used by the program to switch from floating
c            point arithmetic to exact arithmetic by testing against
c            this tolerance whether certain quantities are too close
c            to zero; setting it equal to numbers such as 0.1, 0.01
c            has worked well so far.
c
c     x      Array that contains x-coordinates of points or vertices 1
c            through nv. Values obtained by program from input files.
c            Each line of these input files corresponds to one point.
c            Two numbers are found in each line. The first number is
c            the x-coordinate of the point that corresponds to the
c            line. The second number is the y-coordinate of the point
c            (see description of array y below). nmax is the dimension
c            for this array.
c
c     y      Array that contains y-coordinates of points or vertices 1
c            through nv. Values obtained by program from input files
c            (see description of array x above). nmax is the dimension
c            for this array.
c
c     xrg    Array that contains x-coordinates of origin endpoints of
c            line segments 1 through nl. Values obtained by program
c            from input file. Each line of this input file corresponds
c            to one line segment. Four numbers are found in each line.
c            The 1st number is the x-coordinate of the origin endpoint
c            of the line segment that corresponds to the line. The 2nd
c            number is the y-coordinate of the origin endpoint of the
c            line segment, the 3rd number is the x-coordinate of the
c            destination endpoint of the line segment, and the 4th
c            number is the y-coordinate of the destination endpoint of
c            the line segment (see description of arrays yrg, xds, yds
c            below). nlmax is the dimension for this array.
c
c     yrg    Array that contains y-coordinates of origin endpoints of
c            line segments 1 through nl. Values obtained by program
c            from input file (see description of array xrg above).
c            nlmax is the dimension for this array.
c
c     xds    Array that contains x-coordinates of destination endpoints
c            of line segments 1 through nl. Values obtained by program
c            from input file (see description of array xrg above).
c            nlmax is the dimension for this array.
c
c     yds    Array that contains y-coordinates of destination endpoints
c            of line segments 1 through nl. Values obtained by program
c            from input file (see description of array xrg above).
c            nlmax is the dimension for this array.
c
c     xdl    Array that contains x-coordinates of points or vertices 1
c            through nd that are to be deleted from triangulation.
c            Values obtained by program from input file. Each line of
c            this input file corresponds to one point. Two numbers are
c            found in each line. The first number is the x-coordinate
c            of the point that corresponds to the line. The second
c            number is the y-coordinate of the point (see description
c            of array ydl below). ndmax is the dimension for this array.
c
c     ydl    Array that contains y-coordinates of points or vertices 1
c            through nd that are to be deleted from triangulation.
c            Values obtained by program from input file (see description
c            of array xdl above). ndmax is the dimension for this array.
c
c     vx     Array that contains on output x-coordinates of
c            circumcenters (Voronoi vertices) of triangles 1 through
c            ivnxt in final Delaunay triangulation. nvmax is the
c            dimension for this array.
c
c     vy     Array that contains on output y-coordinates of
c            circumcenters (Voronoi vertices) of triangles 1 through
c            ivnxt in final Delaunay triangulation. nvmax is the
c            dimension for this array.
c
c     is     Array with dimension nmax. From i = 1 to nv, is(i) is the
c            triangle number or index for a triangle in triangulation
c            with vertex i as one of its vertices. is(i) equals nvmz
c            if vertex i was not processed when it was its turn to be
c            inserted into current triangulation. Equals 0 if it was
c            deleted from the triangulation. Equals a negative integer
c            larger than nvmz if vertex i is a duplication of vertex
c            -is(i) which was a vertex in the triangulation when it was
c            the turn of vertex i to be inserted in the triangulation.
c            If vertex i is on the boundary of the convex hull of the
c            vertices in the triangulation then is(i) is the triangle
c            number or index for the triangle in the triangulation that
c            is the first triangle found in a counterclockwise
c            direction in the "fan" of triangles with vertex i as a
c            vertex.
c
c     icon   Two-dimensional array with 6 as its first dimension
c            and nvmax as its second. For j = 1, ..., ivnxt, icon(i,j),
c            i = 1, ..., 6, provides information about the j-th
c            triangle in the triangulation. For j = 1, ..., ivnxt,
c            icon(i,j), i = 1, 2, 3, are the triangle numbers or
c            indices for the three triangles adjacent to triangle j in
c            the order in which they appear in a counter-clockwise
c            direction around triangle j. Given i, i=1, 2, or 3, if
c            icon(i,j) is negative and not equal to nvmz, then
c            -icon(i,j) is the actual index for the ith adjacent
c            triangle to triangle j and the negativity of icon(i,j)
c            simply implies that the edge shared by triangle j and
c            triangle -icon(i,j) is part of an inserted line segment.
c            Given i, i=1, 2, or 3, if icon(i,j) equals either zero or
c            nvmz then the ith adjcent triangle to triangle j does not
c            exist and the edge of triangle j that triangle j would
c            share with that triangle if it existed is part of the
c            boundary of the convex hull of the vertices in the
c            triangulation. If in addition icon(i,j) equals nvmz then
c            the aforementioned edge is part of an inserted line
c            segment. For j = 1, ..., ivnxt, icon(i,j), i = 4, 5, 6,
c            are the vertex numbers or indices for the three vertices
c            of triangle j in the order in which they appear in a
c            counterclockwise direction around triangle j. In addition,
c            assuming without any loss of generality that for i=1, 2,
c            3, icon(i,j) is positive, for i=4, 5, 6, icon(i,j) is the
c            vertex number for the vertex of triangle j that is not a
c            vertex for triangle icon(i-3,j).
c
c     id     Array with dimension nvmax. For i = 1,..., ivnxt, id(i)
c            will equal 1 if the size of Voronoi vertex i is not
c            considered to be too large. If the size of vertex i is
c            considered to be too large id(i) will equal 0.
c
c     ix
c     iy
c     ix2
c     iy2    Arrays of dimension nmax used internally.
c
c     ia     Array of dimension nhmax used internally.
c
c     iave   Array of dimension njmax used internally.
c
c     iaze   Array of dimension nkmax used internally.
c
c     ifun
c     irun
c     isun
c     izun
c     igun
c     iwun   Arrays of dimension nfmax used internally.
c
c     ip     Array that contains indices of points or vertices in xy
c            input files that will not be processed when computing
c            initial triangulation from scratch and/or inserting an
c            additional set of points into the current triangulation.
c            For i = 1, ..., np, ip(i) is the i-th point not to be
c            processed. Values obtained by program from an input file.
c            npmax is the dimension of this array.
c
c***********************************************************************
c
      subroutine IniDelaunay(nMax, nActEle, x, y, 
     $      numCell, eleStnCell, flagEffCell,
     $      nVMax, nFMax, nHMax, nKMax, nJMax, nPMax, 
     $      ix, iy, ix2, iy2, is, icon, id, iave, iaze )
       
       ! Find the element closest to the given point. 
       ! Strain cells (triangles) will be constructed around this element in IniStrainCell.
       
       implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: IniDelaunay
	 !DEC$ ATTRIBUTES ALIAS:'IniDelaunay' :: IniDelaunay
	 !DEC$ ATTRIBUTES Reference :: 
     $	    nMax, nActEle, x, y, 
     $      numCell, eleStnCell, flagEffCell,
     $      nVMax, nFMax, nHMax, nKMax, nJMax, nPMax, 
     $      ix, iy, ix2, iy2, is, icon, id, iave, iaze
     
c
      integer nMax, nVMax, nActEle, numCell
      integer eleStnCell(nVMax,3), flagEffCell(nVMax)
      integer nfmax, nhmax, nkmax, njmax, npmax, iPt
c      parameter (nmax = 160000, nvmax = 2.1*nmax)
c      parameter (nfmax = 5 * 400, nhmax = 5 * 400)
c      parameter (nkmax = ndmax+1, njmax = 2 * nkmax, npmax = 10000)
c
      double precision x(nMax), y(nMax)
      integer ix(nMax), iy(nMax), ix2(nMax), iy2(nMax)
      integer is(nMax), icon(6,nVMax), id(nVMax)
      integer iave(nJMax), iaze(nKMax)
      integer n, nv, ivnxt, nvmz,np
      integer icsfig, mhalf, mfull, isclp(2)
      double precision epf
      double precision r215, deps, dscle, dfull, dfill
c
      logical vnflg, vsflg, voflg, lsflg, dlflg,
     *        toflg, ccflg, npflg, trflg
c
      integer i, j, nvmn, nvmp, iase, ileft, iabe, idupl, inpro
      double precision xcor, ycor, xmax, xmin, ymax, ymin
      double precision PtDist, lEdge1,lEdge2,lEdge3,TriArea,area

      
      vnflg=.false.
      vsflg=.false.
      voflg=.false.
      lsflg=.false.
      dlflg=.false.
      toflg=.false.
      ccflg=.false.
      npflg=.false.
      trflg=.false.

      do 25 i = 1, nmax
         is(i) = 0
   25 continue

c  30 format(a1)
   50 format(a30)

      icsfig=7



 
      nvmz = -nvmax - 1
      nvmn = nvmz - 1
      nvmp = -nvmn
c
      epf = 0.01d0

c
c*****************************************************************
c
c     read points file
c
      nv=nActEle
      
      xmax=x(1)
      xmin=x(1)
      ymax=y(1)
      ymin=y(1)

      do iPt=1,nActEle
        xMax=max(xMax,x(iPt))
        xMin=min(xMin,x(iPt))
        yMax=max(yMax,y(iPt))
        yMin=min(yMin,y(iPt))
      end do



      n=nv
      iase=1
      iaze(1)=nv+1


      np = 0
c
c*****************************************************************
c
c     transform coordinates into integer decomposition
c

      call transf(x, y, ix, iy, ix2, iy2, xmin, ymin, xmax, ymax,
     *            nv, icsfig, mhalf, mfull, isclp, r215, deps,
     *            dscle, dfull, dfill, epf)

c
      call tricmp(x, y, ix, iy, ix2, iy2, is, icon, iave, iaze,
     *            epf, mhalf, mfull, isclp, nvmz, nv, iabe, iase,
     *            nmax, nvmax, ivnxt, idupl, inpro, r215, deps, ileft)
c
c
c**********************************************************************
c
c     save information about final Delaunay triangulation
c
      flagEffCell=0
      flagEffCell(1:ivnxt)=1

      do iPt=1,ivnxt
        eleStnCell(iPt,1:3)=iCon(4:6,iPt)
        lEdge1=Dsqrt( PtDist( x(iCon(4,iPt)), y(iCon(4,iPt)),
     $                        x(iCon(5,iPt)), y(iCon(5,iPt))))
        lEdge2=Dsqrt( PtDist( x(iCon(4,iPt)), y(iCon(4,iPt)),
     $                        x(iCon(6,iPt)), y(iCon(6,iPt))))
        lEdge3=Dsqrt( PtDist( x(iCon(6,iPt)), y(iCon(6,iPt)),
     $                        x(iCon(5,iPt)), y(iCon(5,iPt))))
        
        area=TriArea( x(iCon(4,iPt)), y(iCon(4,iPt)),
     $                x(iCon(5,iPt)), y(iCon(5,iPt)),
     $                x(iCon(6,iPt)), y(iCon(6,iPt)) )
        
        if ( ((lEdge1+lEdge2+lEdge3)/3)**2*0.433.gt.
     $       area*5.0) then
            flagEffCell(iPt)=0
        end if
        
      end do

      end
*TRANSF
c
c     subroutine transf to -
c
c     transform double precision coordinates into integer decomposition
c 
      subroutine transf(x, y, ix, iy, ix2, iy2, xmin, ymin, xmax, ymax,
     *                  nv, icsfig, mhalf, mfull, isclp, r215, deps,
     *                  dscle, dfull, dfill, epf)
c
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer nv, icsfig
      integer mhalf, mfull, ibsfig, itsfig
      double precision epf, wbig
      integer isclp(*)
      double precision xmin, xmax, ymin, ymax
      double precision dscle, dfull, dfill, decml, deps, r215
      integer i, isclu, isgcl
c
c     initialize word lengths
c
      mhalf=32768
      mfull=1073741824
      if(mfull.ne.mhalf**2) stop 280
      deps = dble(0.9)
      r215 = dble(mhalf)
c
c     test # of significant figures of nondecimal part of coordinates
c
      wbig = 0.0d0
      if(wbig .lt. dabs(xmax)) wbig = dabs(xmax)
      if(wbig .lt. dabs(xmin)) wbig = dabs(xmin)
      if(wbig .lt. dabs(ymax)) wbig = dabs(ymax)
      if(wbig .lt. dabs(ymin)) wbig = dabs(ymin)
      wbig = wbig + epf
c     WRITE(*,*)'COORDINATES WBIG=',WBIG
      ibsfig = 0
  180 continue
      ibsfig = ibsfig+1
      wbig = wbig/10.0d0
      if(wbig .ge. 1.0d0) go to 180
      if(ibsfig.gt.9) then
         write(*,*)'Number of significant figures of largest ',
     *             'nondecimal part of'
         write(*,*)'a point coordinate appears to be greater than 9.'
         write(*,*)'Program is terminated.'
         stop 285
      endif
      itsfig = ibsfig + icsfig
c     WRITE(*,*)'ITSFIG=',ITSFIG,' IBSFIG=',IBSFIG,' ICSFIG=',ICSFIG
      if(itsfig.gt.14) then
         write(*,*)' '
         write(*,*)'For this execution of the program the largest ',
     *             'total number of'
         write(*,*)'significant figures ',
     *             'that a coordinate requires appears to be ',itsfig
         write(*,*)'Since the maximum allowed is 14, the number of ',
     *             'significant figures'
         write(*,*)'of the decimal part of the point coordinates for ',
     *             'this run is '
         write(*,*)'decreased accordingly.'
         icsfig = 14 - ibsfig
         write(*,*)' '
      endif
c
c     test number of significant figures of decimal part of coordinates
c
      if(icsfig.lt.0 .or. icsfig.gt.9) stop 290
      isclu = 1
      dscle = 1.0d0
      if(icsfig.eq.0) go to 220
      do 210 i = 1, icsfig
         isclu = 10*isclu
         dscle = 10.0d0*dscle
  210 continue
  220 continue
      if(iabs(isclu).ge.mfull) stop 295
      call decomp(isclp, isgcl, isclu, mhalf)
      if(isgcl.ne.1) stop 297
c
c     test lengths of x, y-coordinates, shift and make them integers
c
      dfull = dble(mfull)
      if(dscle.lt.deps) stop 300
      dfill=dfull/dscle
      do 235 i = 1, nv
         ix2(i) = 0
         iy2(i) = 0
         if(dabs(x(i)).lt.dfill) then
            ix(i) = idnint(dscle*x(i))
            if(iabs(ix(i)).lt.mfull) then
               x(i) = dble(ix(i))/dscle
               go to 225
            endif
         endif
         if(dabs(x(i)).ge.dfull) stop 305
         ix(i) = idint(x(i))
         if(iabs(ix(i)).ge.mfull) stop 310
         decml = (x(i) - dint(x(i)))*dscle
         if(dabs(decml).ge.dfull) stop 312
         ix2(i) = idnint(decml)
         if(iabs(ix2(i)).ge.mfull) stop 315
         if(iabs(ix2(i)).eq.0) then
            x(i) = dble(ix(i))
            ix2(i) = mfull
         else
            x(i) = dble(ix(i)) + (dble(ix2(i))/dscle)
         endif
  225    continue
         if(dabs(y(i)).lt.dfill) then
            iy(i) = idnint(dscle*y(i))
            if(iabs(iy(i)).lt.mfull) then
               y(i) = dble(iy(i))/dscle
               go to 235
            endif
         endif
         if(dabs(y(i)).ge.dfull) stop 320
         iy(i) = idint(y(i))
         if(iabs(iy(i)).ge.mfull) stop 325
         decml = (y(i) - dint(y(i)))*dscle
         if(dabs(decml).ge.dfull) stop 327
         iy2(i) = idnint(decml)
         if(iabs(iy2(i)).ge.mfull) stop 330
         if(iabs(iy2(i)).eq.0) then
            y(i) = dble(iy(i))
            iy2(i) = mfull
         else
            y(i) = dble(iy(i)) + (dble(iy2(i))/dscle)
         endif
  235 continue
c
      return
      end
*PNTDEC
c
c     subroutine pntdec -
c
c     to decompose double precision coordinates of one point
c     into integers
c
c
      subroutine pntdec(xi, yi, x, y, x2, y2, n, mfull, icsfig,
     *                  dscle, dfull, dfill, epf)
c
      double precision xi(*), yi(*)
      integer x(*), y(*), x2(*), y2(*)
      integer n, mfull, icsfig, ibsfig, itsfig
      double precision xdes, ydes, wbig, epf
      double precision dscle, dfull, dfill, decml
c
c     test # of significant figures of nondecimal part of coordinates
c
      xdes = xi(n)
      ydes = yi(n)
      wbig = 0.0d0
      if(wbig .lt. dabs(xdes)) wbig = dabs(xdes)
      if(wbig .lt. dabs(xdes)) wbig = dabs(xdes)
      if(wbig .lt. dabs(ydes)) wbig = dabs(ydes)
      if(wbig .lt. dabs(ydes)) wbig = dabs(ydes)
      wbig = wbig + epf
c     WRITE(*,*)'COORDINATES WBIG=',WBIG
      ibsfig = 0
  180 continue
      ibsfig = ibsfig+1
      wbig = wbig/10.0d0
      if(wbig .ge. 1.0d0) go to 180
      if(ibsfig.gt.9) then
         write(*,*)'Number of significant figures of nondecimal',
     *             'part of a'
         write(*,*)'new point coordinate appears to be greater than 9.'
         write(*,*)'Program is terminated.'
         stop 335
      endif
      itsfig = ibsfig + icsfig
c     WRITE(*,*)'ITSFIG=',ITSFIG,' IBSFIG=',IBSFIG,' ICSFIG=',ICSFIG
      if(itsfig.gt.14) then
         write(*,*)'Total number of significant figures of a new ',
     *             'point coordinate'
         write(*,*)'appears to be greater than 14.'
         stop 340
      endif
c
      x2(n) = 0
      y2(n) = 0
      if(dabs(xi(n)).lt.dfill) then
         x(n) = idnint(dscle*xi(n))
         if(iabs(x(n)).lt.mfull) then
            xi(n) = dble(x(n))/dscle
            go to 1110
         endif
      endif
      if(dabs(xi(n)).ge.dfull) stop 350
      x(n) = idint(xi(n))
      if(iabs(x(n)).ge.mfull) stop 355
      decml = (xi(n) - dint(xi(n)))*dscle
      if(dabs(decml).ge.dfull) stop 360
      x2(n) = idnint(decml)
      if(iabs(x2(n)).ge.mfull) stop 365
      if(iabs(x2(n)).eq.0) then
         xi(n) = dble(x(n))
         x2(n) = mfull
      else
         xi(n) = dble(x(n)) + (dble(x2(n))/dscle)
      endif
 1110 continue
      if(dabs(yi(n)).lt.dfill) then
         y(n) = idnint(dscle*yi(n))
         if(iabs(y(n)).lt.mfull) then
            yi(n) = dble(y(n))/dscle
            go to 1120
         endif
      endif
      if(dabs(yi(n)).ge.dfull) stop 370
      y(n) = idint(yi(n))
      if(iabs(y(n)).ge.mfull) stop 375
      decml = (yi(n) - dint(yi(n)))*dscle
      if(dabs(decml).ge.dfull) stop 380
      y2(n) = idnint(decml)
      if(iabs(y2(n)).ge.mfull) stop 385
      if(iabs(y2(n)).eq.0) then
         yi(n) = dble(y(n))
         y2(n) = mfull
      else
         yi(n) = dble(y(n)) + (dble(y2(n))/dscle)
      endif
 1120 continue
c
      return
      end
*TRICMP
c
c     driver subroutine tricmp to -
c
c     compute a Delaunay triangulation from scratch
c
      subroutine tricmp(x, y, ix, iy, ix2, iy2, is, icon, iave, iaze,
     *                  epf, mhalf, mfull, isclp, nvmz, nv, iabe, iase,
     *                  nmax, nvmax, ivnxt, idupl, inpro, r215, deps,
     *                  ileft)
c
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer is(*), icon(6,*), iave(*), iaze(*)
      double precision epf, r215, deps
      integer mhalf, mfull, nvmz, nv, iabe, iase, nmax, nvmax, ivnxt
      integer isclp(*)
c
      integer nkmax
      parameter (nkmax = 30)
      integer iax(nkmax), iay(nkmax), isgax, isgay, ikax, ikay
      integer iox(nkmax), ioy(nkmax), isgox, isgoy, ikox, ikoy
      integer isga
      double precision xtemp, ytemp, delx, dely
      double precision xmax, xmin, dotx, dnux, dot
      integer i, i1, i2, i3, it, ileft, iright, insrt, isst
      integer idupl, inpro, isite, itype, ipoint
c
c     obtain initial triangle
c
      do 95 i = 1, nv
         if(is(i).eq.0) go to 98
   95 continue
      stop 400
c
   98 continue
      i1 = i
      i2 = i
      xmin = x(i1)
      xmax = x(i2)
      do 100 i = 1, nv
         if(is(i).ne.0) go to 100
         if(x(i) .lt. xmin) then
            i1 = i
            xmin = x(i1)
         endif
         if(x(i) .gt. xmax) then
            i2 = i
            xmax = x(i2)
         endif
  100 continue
      if(i1.eq.i2) stop 410
c
      call prpvec(ix, iy, ix2, iy2, i1, i2, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay)
      if(isgay.le.0) stop 420
      call doubnm(iax, isgax, ikax, r215, delx)
      call doubnm(iay, isgay, ikay, r215, dely)
      dnux = dmax1(dabs(delx),dabs(dely))
      if(dnux.lt.deps) stop 430
      delx = delx/dnux
      dely = dely/dnux
c
      i3 = 0
      dotx = 0.0d0
      do 350 i = 1, nv
         if(i.eq.i1 .or. i.eq.i2 .or. is(i).ne.0) go to 350
         call vectrd(ix, iy, ix2, iy2, i1, i, mhalf, mfull, isclp,
     *               iox, isgox, ikox, ioy, isgoy, ikoy)
         call doubnm(iox, isgox, ikox, r215, xtemp)
         call doubnm(ioy, isgoy, ikoy, r215, ytemp)
         dot = delx*xtemp + dely*ytemp
c        WRITE(*,*)'I=',I,' DOT =',DOT
         if(dabs(dot).gt.dotx) then
            dotx = dabs(dot)
            i3 = i
         endif
  350 continue
c
      if(i3 .eq. 0) stop 440
c
      call distsn(ix, iy, ix2, iy2, i1, i3, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay, isga)
c
      if(isga .eq. 0) stop 450
      if(isga .gt. 0) go to 400
      it = i2
      i2 = i3
      i3 = it
c
  400 continue
c     write(*,*)' '
c     write(*,*)'Initial triangle has vertices:',i1,i2,i3
      ivnxt = 1
      if(ivnxt.gt.nvmax) stop 460
c
      icon(1,1) = 0
      icon(2,1) = 0
      icon(3,1) = 0
      icon(4,1) = i1
      icon(5,1) = i2
      icon(6,1) = i3
c
      is(i1) = 1
      is(i2) = 1
      is(i3) = 1
c
c     insert other points
c
      iabe=1
      iave(1)=ivnxt+1
      ileft=i1
      insrt=1
      idupl=0
      inpro=0
      if(nv.eq.3) go to 480
c
      write(*,*)' '
      do 450 isst = 1, nv
         isite = isst
         if(is(isite).eq.nvmz) inpro=inpro+1
         if(is(isite).ne.0) go to 450
         ipoint = isite
c        WRITE(*,*)'IPOINT=',IPOINT
         call pntins(x, y, ix, iy, ix2, iy2, is, icon, iave, iaze,
     *               epf, mhalf, mfull, isclp, nvmz, ileft, iright,
     *               nv, iabe, iase, isite, nmax, nvmax, ivnxt,
     *               insrt, itype, ipoint)
         if(itype.eq.1.or.itype.eq.-1) then
            is(isite) = -iright
            idupl=idupl+1
         endif
c
         ileft = iright
         if(isite.le.(isite/10000)*10000)
     *      write(*,*)'Number of points inserted =',isite
  450 continue
c
  480 continue
      return
      end
*TRIADD
c
c     driver subroutine triadd to -
c
c     insert additional points into current Delaunay triangulation
c
      subroutine triadd(x, y, ix, iy, ix2, iy2, is, icon, ip, iave,
     *                 iaze, epf, icsfig, mhalf, mfull, isclp, nvmz,
     *                 n, nv, np, iabe, iase, nmax, nvmax, ivnxt,
     *                 idupl, inpro, ileft, dscle, dfull, dfill)
c
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer is(*), icon(6,*), ip(*), iave(*), iaze(*)
      double precision epf, dscle, dfull, dfill
      integer icsfig, mhalf, mfull, isclp(*)
      integer nvmz, n, nv, np, iabe, iase, nmax, nvmax, ivnxt
c
      integer ileft, iright, insrt, isst
      integer idupl, inpro, isite, itype, i, ipoint
c
      if(np.gt.0)then
         do 575 i=1,np
            if(ip(i).lt.n+1.or.ip(i).gt.nv) go to 575
            is(ip(i))=nvmz
  575    continue
      endif

      insrt=1
      idupl=0
      inpro=0
c
      write(*,*)' '
      do 580 isst = n+1, nv
         isite = isst
         if(is(isite).eq.nvmz) inpro=inpro+1
         if(is(isite).ne.0) go to 580
         ipoint = isite
         call pntdec(x, y, ix, iy, ix2, iy2, ipoint, mfull, icsfig,
     *               dscle, dfull, dfill, epf)
         call pntins(x, y, ix, iy, ix2, iy2, is, icon, iave, iaze,
     *               epf, mhalf, mfull, isclp, nvmz, ileft, iright,
     *               nv, iabe, iase, isite, nmax, nvmax, ivnxt,
     *               insrt, itype, ipoint)
         if(itype.eq.1.or.itype.eq.-1) then
            is(isite) = -iright
            idupl=idupl+1
         endif
c
         ileft = iright
         if(isite.le.(isite/10000)*10000)
     *      write(*,*)'Number of points inserted =',isite
  580 continue
      return
      end
*LININS
c
c     driver subroutine linins to -
c
c     insert line segments into Delaunay triangulation and maintain
c     Delaunay property
c
      subroutine linins(x, y, xrg, yrg, xds, yds, ix, iy, ix2, iy2, is,
     *                  icon, iave, iaze, ia, ifun, irun, isun, izun,
     *                  igun, iwun, epf, icsfig, mhalf, mfull, isclp,
     *                  nvmz, nv, nl, iabe, iase, nmax, nvmax, nfmax,
     *                  nhmax, ivnxt, nvmp, nvmn, nls, nlp, ileft,
     *                  dscle, dfull, dfill)
c
      double precision x(*), y(*), xrg(*), yrg(*), xds(*), yds(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer is(*), icon(6,*), iave(*), iaze(*), ia(*)
      integer ifun(*), irun(*), isun(*), izun(*)
      integer igun(*), iwun(*)
      double precision epf, dscle, dfull, dfill
      integer icsfig, mhalf, mfull, isclp(*)
      integer nvmz, nv, nl, iabe, iase, nmax, nvmax, ivnxt
      integer nfmax, nhmax, nvmp, nvmn, ileft, iright
      integer nls, nlp
c
      integer i, insrt, isite, itype, ipoint
c
      insrt=1
      nls=0
      nlp=0
      write(*,*)' '
      do 600 i = 1, nl
         isite=0
         ipoint = nv + 1
         if(ipoint.gt.nmax) stop 500
         x(ipoint) = xrg(i)
         y(ipoint) = yrg(i)
         call pntdec(x, y, ix, iy, ix2, iy2, ipoint, mfull, icsfig,
     *               dscle, dfull, dfill, epf)
         call pntins(x, y, ix, iy, ix2, iy2, is, icon, iave, iaze,
     *               epf, mhalf, mfull, isclp, nvmz, ileft, iright,
     *               nv, iabe, iase, isite, nmax, nvmax, ivnxt,
     *               insrt, itype, ipoint)
c
         ileft = iright
         isite=0
         ipoint = nv + 1
         if(ipoint.gt.nmax) stop 510
         x(ipoint) = xds(i)
         y(ipoint) = yds(i)
         call pntdec(x, y, ix, iy, ix2, iy2, ipoint, mfull, icsfig,
     *               dscle, dfull, dfill, epf)
         call pntins(x, y, ix, iy, ix2, iy2, is, icon, iave, iaze,
     *               epf, mhalf, mfull, isclp, nvmz, ileft, iright,
     *               nv, iabe, iase, isite, nmax, nvmax, ivnxt,
     *               insrt, itype, ipoint)
c
         call reconc(x, y, ix, iy, ix2, iy2, is, icon, ifun, irun,
     *               isun, izun, igun, iwun, ia, epf, mhalf, mfull,
     *               isclp, nfmax, nhmax, nvmz, nvmp, nvmn,
     *               ileft, iright, nv)
c
         if(ileft .ne. iright) then
            ileft = iright
            nls=nls+1
         else
            nlp=nlp+1
         endif
         if(i.le.(i/1000)*1000)
     *      write(*,*)'Number of line segments inserted =',i
  600 continue
c
      return
      end
*PNTDEL
c
c     driver subroutine pntdel to -
c
c     delete points or vertices in current Delaunay triangulation
c
      subroutine pntdel(x, y, xdl, ydl, ix, iy, ix2, iy2, is, icon,
     *                  iave, iaze, ia, ifun, irun, isun, izun, igun,
     *                  iwun, epf, icsfig, mhalf, mfull, isclp, nvmz,
     *                  nv, nd, iabe, iase, nmax, nvmax, nfmax, nhmax,
     *                  njmax, nkmax, ivnxt, nvmp, nvmn, ndl, nde, ndv,
     *                  nds, ileft, dscle, dfull, dfill)
c
      double precision x(*), y(*), xdl(*), ydl(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer is(*), icon(6,*), iave(*), iaze(*), ia(*)
      integer ifun(*), irun(*), isun(*), izun(*)
      integer igun(*), iwun(*)
      double precision epf, dscle, dfull, dfill
      integer icsfig, mhalf, mfull, isclp(*)
      integer nvmz, nv, nd, iabe, iase
      integer nmax, nvmax, nfmax, nhmax, njmax, nkmax
      integer ivnxt, nvmp, nvmn, ndl, nde, ndv, nds
c
      integer ileft, iright, insrt
      integer isite, itype, i, isucs, isnew, ipoint
c
      insrt = 0
      isite = 0
      ndl=0
      nde=0
      ndv=0
      nds=0
      ipoint = nv + 1
      if(ipoint.gt.nmax) stop 600
c
      write(*,*)' '
      do 720 i = 1, nd
         x(ipoint) = xdl(i)
         y(ipoint) = ydl(i)
         call pntdec(x, y, ix, iy, ix2, iy2, ipoint, mfull, icsfig,
     *               dscle, dfull, dfill, epf)
         isucs = -1
         call pntins(x, y, ix, iy, ix2, iy2, is, icon, iave, iaze,
     *               epf, mhalf, mfull, isclp, nvmz, ileft, iright,
     *               nv, iabe, iase, isite, nmax, nvmax, ivnxt,
     *               insrt, itype, ipoint)
c
         if(itype .eq. 1 .or. itype .eq. -1) then
            call deleli(x, y, ix, iy, ix2, iy2, is, icon, ifun, irun,
     *                  isun, izun, igun, iwun, ia, iave, iaze, epf,
     *                  mhalf, mfull, isclp, nfmax, nhmax, njmax,
     *                  nkmax, nvmz, nvmp, nvmn, iright, nv, isucs,
     *                  isnew, iabe, iase)
         endif
c
         if(isucs .eq. 1) then
            ndl=ndl+1
            ileft = isnew
         elseif(isucs .eq. 0) then
            nde=nde+1
         elseif(isucs .eq. -1) then
            ndv=ndv+1
         else
            nds=nds+1
         endif
         if(i.le.(i/1000)*1000)
     *      write(*,*)'Number of points deleted =',i
  720 continue
c
      return
      end
*VORCMP
c
c     This subroutine computes Voronoi vertices.
c 
c
      subroutine vorcmp(ix, iy, ix2, iy2, xp, yp, icon, ifl, nt,
     *                  dscle, mhalf, mfull, isclp)
c
      integer ix(*), iy(*), ix2(*), iy2(*)
      double precision xp(*), yp(*)
      integer icon(6,*), ifl(*)
      integer nt, mhalf, mfull, nkmax, isclp(*)
      parameter(nkmax=30)
      integer io(nkmax), inx(nkmax), iny(nkmax)
      double precision r215, dnom, xnum, ynum
      double precision deps, dscle, dscl2, dfull
c
      integer ng, i, ifir, isec, ithi, isgo, iko
      integer isgnx, isgny, iknx, ikny
c
c     compute vertices
c
      ng = 0
      dfull = dble(mfull)
      r215 = dble(mhalf)
      deps = dble(0.9)
      if(dscle.lt.deps) stop 620
      dscl2 = 2.0d0*dscle
      write(*,*)' '
      do 1000 i = 1, nt
         if(i.le.(i/10000)*10000)
     *   write(*,*)'Number of computed vertices =',i
         ifir = icon(4,i)
         isec = icon(5,i)
         ithi = icon(6,i)
         if(ifir.le.ng .or. isec.le.ng .or. ithi.le.ng) stop 640
         call numden(ix, iy, ix2, iy2, ifir, isec, ithi, mhalf, mfull,
     *               isclp, io, isgo, iko, inx, iny, isgnx, isgny,
     *               iknx, ikny)
         if(isgo.le.0) stop 660
         call doubnm(io, isgo, iko, r215, dnom)
         if(dnom.lt.deps) stop 680
         call doubnm(inx, isgnx, iknx, r215, xnum)
         call doubnm(iny, isgny, ikny, r215, ynum)
         xp(i) = (xnum/dnom)/dscl2
         yp(i) = (ynum/dnom)/dscl2
         ifl(i) = 1
 1000 continue
c
c     identify vertices whose sizes are too big
c
      do 1600 i = 1, nt
         dnom = dmax1(dabs(xp(i)),dabs(yp(i)))
         if(dnom.gt.dfull) ifl(i) = 0
 1600 continue
c
      return
      end
*PNTINS
c
c     subroutine pntins to -
c
c     insert a point into a Delaunay triangulation and obtain a
c     Delaunay triangulation that contains the inserted point
c
c     February 11, 1991
c
      subroutine pntins(x, y, ix, iy, ix2, iy2, is, icon, iave, iaze,
     *                  epf, mhalf, mfull, isclp, nvmz, ileft, iright,
     *                  n, iabe, iase, isite, nmax, nvmax, ivnxt,
     *                  insrt, itype, ipoint)
c
      integer mhalf, mfull, isclp(*)
      integer nvmz, ileft, iright, n, iabe, iase, isite
      integer nmax, nvmax, ivnxt, insrt, itype, ipoint
      double precision epf
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer is(*), icon(6,*), iave(*), iaze(*)
c
      integer ivfnd, ivcur, ivaft
c
c     find position of point in triangulation
c
      call gettri(x, y, ix, iy, ix2, iy2, is, icon, epf,
     *            mhalf, mfull, isclp, nvmz, ileft, iright,
     *            n, itype, ivfnd, ipoint)
c
c     insert point
c
c     WRITE(*,*)'ISITE=',ISITE,' ITYPE=',ITYPE
      if(itype .eq. -1 .or. itype .eq. 1) go to 400
      if(insrt .eq. 0) go to 400
      if(isite.ne.0) go to 200
      isite = iaze(iase)
      if(iase .eq. 1) then
          n = isite
          if(n. gt. nmax) stop 700
          iaze(1) = n + 1
      else
          iase = iase - 1
      endif
      x(isite) = x(ipoint)
      y(isite) = y(ipoint)
      ix(isite) = ix(ipoint)
      iy(isite) = iy(ipoint)
      ix2(isite) = ix2(ipoint)
      iy2(isite) = iy2(ipoint)
  200 continue
      if(itype .eq. 2) then
          call edgint(icon, is, iave, ivnxt, nvmax, nvmz, ivfnd, isite,
     *                iright, iabe)
      elseif(itype .eq. 3) then
          call intins(icon, is, iave, ivnxt, nvmax, nvmz, ivfnd, isite,
     *                iabe)
      else
          call outhul(x, y, ix, iy, ix2, iy2, icon, is, iave,
     *                ivnxt, nvmax, nvmz, mhalf, mfull, isclp,
     *                ivfnd, isite, iright, iabe, epf)
      endif
      iright = isite
c
c     optimize triangulation with respect to isite
c
      ivcur = ivfnd
  300 continue
      ivaft = icon(2,ivcur)
      call opttri(x, y, ix, iy, ix2, iy2, icon, is, epf,
     *            ivcur, isite, nvmz, mhalf, mfull, isclp)
      if(ivaft .eq. 0 .or. ivaft .eq. nvmz) go to 400
      ivcur = iabs(ivaft)
      if(ivcur .ne. ivfnd) go to 300
c
  400 continue
c
      return
      end
*GETTRI
c
c     subroutine gettri to -
c
c     obtain position in a triangulation for
c     a point (xdes,ydes) by moving through the triangulation from
c     a known vertex (ileft) in the triangulation to the point
c
c     the following holds on output: 
c
c     if itype equals -1 then (xdes,ydes) is exactly the vertex with
c     index ileft
c
c     if itype equals 0 then (xdes,ydes) is a point outside the convex
c     hull of the triangulation and iright is a vertex of the convex
c     hull visible from (xdes,ydes)
c
c     if itype equals 1 then (xdes,ydes) is exactly the vertex in the
c     triangulation with index iright and iright is different from
c     ileft
c
c     if itype equals 2 then (xdes,ydes) is a point in the interior of
c     a side of the triangle in the triangulation with index ivfnd and
c     iright is the first vertex of this triangle which is found when
c     moving from the point in a counterclockwise direction around the
c     boundary of the triangle
c
c     if itype equals 3 then (xdes,ydes) is a point in the interior of
c     the triangle in the triangulation with index ivfnd
c
c     February 6, 1991
c
      subroutine gettri(x, y, ix, iy, ix2, iy2, is, icon, epf,
     *                  mhalf, mfull, isclp, nvmz, ileft,
     *                  iright, n, itype, ivfnd, ipoint)
c
      integer mhalf, mfull, isclp(*), ipoint
      integer nvmz, ileft, iright, n, itype, ivfnd
      double precision epf, xdes, ydes
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer is(*), icon(6,*)
c
      integer nkmax
      parameter (nkmax=30)
      integer iax(nkmax), iay(nkmax), isgax, isgay, ikax, ikay
      integer iox(nkmax), ioy(nkmax), isgox, isgoy, ikox, ikoy
      integer isi1, isi2, isi3, iloft, iperp, nsgax, isga, i
      integer ivini, ivcur, ivadj, ivfol, ivpre, ivlst
      double precision delx, dely, xtemp, ytemp, dls1, dls2, dls3
      double precision xtamp, ytamp, dlg1, dlg2, dlg3, dlen, daf
      double precision dot1, dot2, dot3, dut2
      double precision xtump, ytump, dalx, daly
c
c     compute direction parameters
c
      if(ileft .lt. 1 .or. ileft .gt. n) stop 800
      iperp = 0
      xdes = x(ipoint)
      ydes = y(ipoint)
      delx = y(ileft) - ydes
      dely = xdes - x(ileft)
      dlen = dsqrt(delx**2 + dely**2)
      if(dlen .lt. epf) iperp = 1
      call prpvec(ix, iy, ix2, iy2, ileft, ipoint, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay)
      if(isgax.eq.0 .and. isgay.eq.0) then
         itype = -1
         iright = ileft
         go to 2000
      endif
      nsgax = -isgax
      isi2 = ileft
      itype = 0
c
  100 continue
      iloft = isi2
      ivini = is(iloft)
      ivcur = ivini
      if(icon(4,ivcur) .eq. iloft) then
         ivlst = icon(3,ivcur)
      elseif(icon(5,ivcur) .eq. iloft) then
         ivlst = icon(1,ivcur)
      elseif(icon(6,ivcur) .eq. iloft) then
         ivlst = icon(2,ivcur)
      else
          stop 805
      endif
c
c     test current triangle
c
  200 continue
      if(icon(4,ivcur) .eq. iloft) then
         ivadj = icon(2,ivcur)
         ivfol = icon(1,ivcur)
         isi2 = icon(5,ivcur)
         isi1 = icon(6,ivcur)
      elseif(icon(5,ivcur) .eq. iloft) then
         ivadj = icon(3,ivcur)
         ivfol = icon(2,ivcur)
         isi2 = icon(6,ivcur)
         isi1 = icon(4,ivcur)
      elseif(icon(6,ivcur) .eq. iloft) then
         ivadj = icon(1,ivcur)
         ivfol = icon(3,ivcur)
         isi2 = icon(4,ivcur)
         isi1 = icon(5,ivcur)
      else
         stop 810
      endif
c
      xtemp = x(isi2) - xdes
      ytemp = y(isi2) - ydes
      dls2 = dsqrt(xtemp**2 + ytemp**2)
      if(dls2 .ge. epf) go to 220
      call vectrd(ix, iy, ix2, iy2, ipoint, isi2, mhalf, mfull,
     *            isclp, iox, isgox, ikox, ioy, isgoy, ikoy)
      if(isgox.ne.0 .or. isgoy.ne.0) go to 220
      itype = 1
      iright = isi2
      go to 2000
  220 continue
      if(iperp.eq.1) go to 240
      xtamp = x(isi2) - x(iloft)
      ytamp = y(isi2) - y(iloft)
      dlg2 = dsqrt(xtamp**2 + ytamp**2)
      if(dlg2 .lt. epf) go to 240
      dot2 = (delx * xtamp + dely * ytamp)/dlen
      if(dot2.ge.epf .or. dot2.le.-epf) go to 260
  240 continue
c     WRITE(*,*)'GETTRI 1 DISTSN'
      call distsn(ix, iy, ix2, iy2, iloft, isi2, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay, isga)
      if(isga.gt.0) then
         dot2 = 10.0d0
      elseif(isga.lt.0) then
         dot2 =-10.0d0
      else
         dot2 = 0.0d0
      endif
  260 continue
      if(dot2 .ge. epf) go to 500
      if(dot2 .le.-epf) go to 320
      if(iperp.eq.1) go to 280
      if(dlg2 .lt. epf) go to 280
      dut2 = (dely * xtamp - delx * ytamp)/dlen
      if(dut2.ge.epf .or. dut2.le.-epf) go to 300
  280 continue
      call distsn(ix, iy, ix2, iy2, iloft, isi2, mhalf, mfull, isclp,
     *            iay, isgay, ikay, iax, nsgax, ikax, isga)
      if(isga.gt.0) then
         dut2 = 10.0d0
      elseif(isga.lt.0) then
         dut2 =-10.0d0
      else
         stop 815
      endif
  300 continue
      if(dut2 .ge. epf) go to 400
      dot1 = -10.0
      go to 500
  320 continue
      xtump = x(isi1) - xdes
      ytump = y(isi1) - ydes
      dls1 = dsqrt(xtump**2 + ytump**2)
      if(dls1 .ge. epf) go to 340
      call vectrd(ix, iy, ix2, iy2, ipoint, isi1, mhalf, mfull,
     *            isclp, iox, isgox, ikox, ioy, isgoy, ikoy)
      if(isgox.ne.0 .or. isgoy.ne.0) go to 340
      itype = 1
      iright = isi1
      go to 2000
  340 continue
      if(iperp.eq.1) go to 360
      xtamp = x(isi1) - x(iloft)
      ytamp = y(isi1) - y(iloft)
      dlg1 = dsqrt(xtamp**2 + ytamp**2)
      if(dlg1 .lt. epf) go to 360
      dot1 = (delx * xtamp + dely * ytamp)/dlen
      if(dot1.ge.epf .or. dot1.le.-epf) go to 380
  360 continue
c     WRITE(*,*)'GETTRI 2 DISTSN'
      call distsn(ix, iy, ix2, iy2, iloft, isi1, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay, isga)
      if(isga.gt.0) then
         dot1 = 10.0d0
      elseif(isga.lt.0) then
         dot1 =-10.0d0
      else
         dot1 = 0.0d0
      endif
  380 continue
      if(dot1 .lt. epf) go to 500
      if(dot2 .gt. -epf) stop 820
      go to 900
  400 continue
      if(iperp.eq.1) go to 420
      if(dls2 .lt. epf) go to 420
      dot3 = (-dely * xtemp + delx * ytemp)/dlen
      if(dot3.ge.epf .or. dot3.le.-epf) go to 440
  420 continue
      call distsn(ix, iy, ix2, iy2, isi2, ipoint, mhalf, mfull, isclp,
     *            iay, isgay, ikay, iax, nsgax, ikax, isga)
      if(isga.gt.0) then
         dot3 = 10.0d0
      elseif(isga.lt.0) then
         dot3 =-10.0d0
      else
         stop 825
      endif
  440 continue
      if(dot3 .ge. epf) go to 100
      itype = 2
      iright = isi2
      ivfnd = ivcur
      go to 2000
c
  500 continue
      ivpre = ivcur
      ivcur = iabs(ivadj)
      if(ivcur .eq. ivini) stop 830
      if(ivadj .ne. 0 .and. ivadj .ne. nvmz) go to 200
      if(ivlst .ne. 0 .and. ivlst .ne. nvmz) stop 835
      iright = iloft
      if(dot2 .ge. epf) go to 2000
      if(dot1 .le. -epf) go to 2000
      if(dot2 .gt. -epf .or. dot1 .ge. epf) stop 840
      if(iperp.eq.1) go to 620
      if(dls1 .lt. epf) go to 620
      dot3 = (-dely * xtump + delx * ytump)/dlen
      if(dot3.ge.epf .or. dot3.le.-epf) go to 640
  620 continue
      call distsn(ix, iy, ix2, iy2, isi1, ipoint, mhalf, mfull, isclp,
     *            iay, isgay, ikay, iax, nsgax, ikax, isga)
      if(isga.gt.0) then
         dot3 = 10.0d0
      elseif(isga.lt.0) then
         dot3 =-10.0d0
      else
         stop 845
      endif
  640 continue
      isi2 = isi1
      if(dot3 .ge. epf) go to 100
      itype = 2
      ivfnd = ivpre
      go to 2000
c
  900 continue
      if(dls2.lt.epf) go to 920
      dalx = y(isi2) - y(isi1)
      daly = x(isi1) - x(isi2)
      daf = dsqrt(dalx**2 + daly**2)
      if(daf .lt. epf) go to 920
      dot3 = (dalx * xtemp + daly * ytemp)/daf
      if(dot3.ge.epf .or. dot3.le.-epf) go to 940
  920 continue
      call innsgn(ix, iy, ix2, iy2, isi1, isi2, ipoint, mhalf, mfull,
     *            isclp, isga)
      if(isga.gt.0) then
         dot3 = 10.0d0
      elseif(isga.lt.0) then
         dot3 =-10.0d0
      else
         dot3 = 0.0d0
      endif
  940 continue
      if(dot3 .ge. epf) go to 1100
      if(dot3 .le. -epf) go to 1000
      itype = 2
      iright = isi1
      ivfnd = ivcur
      go to 2000
 1000 continue
      itype = 3
      ivfnd = ivcur
      go to 2000
c
c     test next triangle
c
 1100 continue
      iright = isi2
      if(ivfol .eq. 0 .or. ivfol .eq. nvmz) go to 2000
      ivcur = iabs(ivfol)
      if(icon(4,ivcur) .eq. isi2) then
          isi3 = icon(5,ivcur)
          ivadj = icon(1,ivcur)
          ivpre = icon(3,ivcur)
      elseif(icon(5,ivcur) .eq. isi2) then
          isi3 = icon(6,ivcur)
          ivadj = icon(2,ivcur)
          ivpre = icon(1,ivcur)
      elseif(icon(6,ivcur) .eq. isi2) then
          isi3 = icon(4,ivcur)
          ivadj = icon(3,ivcur)
          ivpre = icon(2,ivcur)
      else
          stop 850
      endif
      xtemp = x(isi3) - xdes
      ytemp = y(isi3) - ydes
      dls3 = dsqrt(xtemp**2 + ytemp**2)
      if(dls3 .ge. epf) go to 1200
      call vectrd(ix, iy, ix2, iy2, ipoint, isi3, mhalf, mfull,
     *            isclp, iox, isgox, ikox, ioy, isgoy, ikoy)
      if(isgox.ne.0 .or. isgoy.ne.0) go to 1200
      itype = 1
      iright = isi3
      go to 2000
 1200 continue
      if(iperp.eq.1) go to 1220
      xtamp = x(isi3) - x(iloft)
      ytamp = y(isi3) - y(iloft)
      dlg3 = dsqrt(xtamp**2 + ytamp**2)
      if(dlg3 .lt. epf) go to 1220
      dot3 = (delx * xtamp + dely * ytamp)/dlen
      if(dot3.ge.epf .or. dot3.le.-epf) go to 1240
 1220 continue
      call distsn(ix, iy, ix2, iy2, iloft, isi3, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay, isga)
      if(isga.gt.0) then
         dot3 = 10.0d0
      elseif(isga.lt.0) then
         dot3 =-10.0d0
      else
         dot3 = 0.0d0
      endif
 1240 continue
      if(dot3 .ge. epf) go to 1400
      if(dot3 .le. -epf) go to 1700
      if(iperp.eq.1) go to 1260
      if(dls3 .lt. epf) go to 1260
      dot3 = (-dely * xtemp + delx * ytemp)/dlen
      if(dot3.ge.epf .or. dot3.le.-epf) go to 1280
 1260 continue
      call distsn(ix, iy, ix2, iy2, isi3, ipoint, mhalf, mfull, isclp,
     *            iay, isgay, ikay, iax, nsgax, ikax, isga)
      if(isga.gt.0) then
         dot3 = 10.0d0
      elseif(isga.lt.0) then
         dot3 =-10.0d0
      else
         stop 855
      endif
 1280 continue
      isi2 = isi3
      if(dot3 .ge. epf) go to 100
      itype = 3
      ivfnd = ivcur
      go to 2000
c
 1400 continue
      if(dls3.lt.epf) go to 1420
      dalx = y(isi3) - y(isi2)
      daly = x(isi2) - x(isi3)
      daf = dsqrt(dalx**2 + daly**2)
      if(daf .lt. epf) go to 1420
      dot3 = (dalx * xtemp + daly * ytemp)/daf
      if(dot3.ge.epf .or. dot3.le.-epf) go to 1440
 1420 continue
      call innsgn(ix, iy, ix2, iy2, isi2, isi3, ipoint, mhalf, mfull,
     *            isclp, isga)
      if(isga.gt.0) then
         dot3 = 10.0d0
      elseif(isga.lt.0) then
         dot3 =-10.0d0
      else
         dot3 = 0.0d0
      endif
 1440 continue
      if(dot3 .le. -epf) go to 1600
      if(dot3 .ge. epf) go to 1500
      itype = 2
      iright = isi3
      ivfnd = ivcur
      go to 2000
 1500 continue
      itype = 3
      ivfnd = ivcur
      go to 2000
 1600 continue
      isi1 = isi3
      ivfol = ivpre
      go to 1100
c
 1700 continue
      if(dls3.lt.epf) go to 1720
      dalx = y(isi3) - y(isi1)
      daly = x(isi1) - x(isi3)
      daf = dsqrt(dalx**2 + daly**2)
      if(daf .lt. epf) go to 1720
      dot3 = (dalx * xtemp + daly * ytemp)/daf
      if(dot3.ge.epf .or. dot3.le.-epf) go to 1740
 1720 continue
      call innsgn(ix, iy, ix2, iy2, isi1, isi3, ipoint, mhalf, mfull,
     *            isclp, isga)
      if(isga.gt.0) then
         dot3 = 10.0d0
      elseif(isga.lt.0) then
         dot3 =-10.0d0
      else
         dot3 = 0.0d0
      endif
 1740 continue
      if(dot3 .ge. epf) go to 1900
      if(dot3 .le. -epf) go to 1800
      itype = 2
      iright = isi1
      ivfnd = ivcur
      go to 2000
 1800 continue
      itype = 3
      ivfnd = ivcur
      go to 2000
 1900 continue
      isi2 = isi3
      ivfol = ivadj
      go to 1100
c
c     test position of point
c
 2000 continue
c     WRITE(*,*)'IPOINT=',IPOINT,' ITYPE=',ITYPE
      if(itype .eq. -1 .or. itype. eq. 1) then
         if(itype .eq. -1 .and. ileft .ne. iright) stop 860
         if(itype .eq.  1 .and. ileft .eq. iright) stop 865
         call vectrd(ix, iy, ix2, iy2, ipoint, iright, mhalf, mfull,
     *               isclp, iox, isgox, ikox, ioy, isgoy, ikoy)
         if(isgox.ne.0 .or. isgoy.ne.0) stop 870
      elseif(itype .eq. 0) then
         ivcur = is(iright)
         if(icon(4,ivcur) .eq. iright) then
            ivlst = icon(3,ivcur)
            isi2 = icon(5,ivcur)
         elseif(icon(5,ivcur) .eq. iright) then
            ivlst = icon(1,ivcur)
            isi2 = icon(6,ivcur)
         elseif(icon(6,ivcur) .eq. iright) then
            ivlst = icon(2,ivcur)
            isi2 = icon(4,ivcur)
         else
            stop 875
         endif
         if(ivlst .ne. 0 .and. ivlst .ne. nvmz) stop 880
         iperp = 0
         delx = y(ipoint) - y(iright)
         dely = x(iright) - x(ipoint)
         dlen = dsqrt(delx**2+dely**2)
         if(dlen .lt. epf) go to 2020
         xtemp = x(isi2) - x(iright)
         ytemp = y(isi2) - y(iright)
         dls2 = dsqrt(xtemp**2+ytemp**2)
         if(dls2 .lt. epf) go to 2020
         dot2 = (delx * xtemp + dely * ytemp)/dlen
         if(dot2.ge.epf .or. dot2.le.-epf) go to 2040
 2020    continue
         iperp = 1
         call prpvec(ix, iy, ix2, iy2, ipoint, iright, mhalf, mfull,
     *               isclp, iax, isgax, ikax, iay, isgay, ikay)
         if(isgax.eq.0 .and. isgay.eq.0) stop 885
         call distsn(ix, iy, ix2, iy2, iright, isi2, mhalf, mfull,
     *               isclp, iax, isgax, ikax, iay, isgay, ikay, isga)
         if(isga.gt.0) then
            dot2 = 10.0d0
         elseif(isga.lt.0) then
            dot2 =-10.0d0
         else
            dot2 = 0.0d0
         endif
 2040    continue
         if(dot2.le.-epf) go to 3000
c
         ivini = ivcur
 2060    continue
         if(icon(4,ivcur) .eq. iright) then
            ivadj = icon(2,ivcur)
            isi1 = icon(6,ivcur)
         elseif(icon(5,ivcur) .eq. iright) then
            ivadj = icon(3,ivcur)
            isi1 = icon(4,ivcur)
         elseif(icon(6,ivcur) .eq. iright) then
            ivadj = icon(1,ivcur)
            isi1 = icon(5,ivcur)
         else
            stop 890
         endif
         ivcur = iabs(ivadj)
         if(ivcur.eq.ivini) stop 895
         if(ivadj .ne. 0 .and. ivadj .ne. nvmz) go to 2060
         if(dlen .lt. epf) go to 2080
         xtemp = x(isi1) - x(iright)
         ytemp = y(isi1) - y(iright)
         dls2 = dsqrt(xtemp**2+ytemp**2)
         if(dls2 .lt. epf) go to 2080
         dot2 = (delx * xtemp + dely * ytemp)/dlen
         if(dot2.ge.epf .or. dot2.le.-epf) go to 2100
 2080    continue
         if(iperp.eq.1) go to 2090
         call prpvec(ix, iy, ix2, iy2, ipoint, iright, mhalf, mfull,
     *               isclp, iax, isgax, ikax, iay, isgay, ikay)
         if(isgax.eq.0 .and. isgay.eq.0) stop 898
 2090    continue
         call distsn(ix, iy, ix2, iy2, iright, isi1, mhalf, mfull,
     *               isclp, iax, isgax, ikax, iay, isgay, ikay, isga)
         if(isga.gt.0) then
            dot2 = 10.0d0
         elseif(isga.lt.0) then
            dot2 =-10.0d0
         else
            dot2 = 0.0d0
         endif
 2100    continue
         if(dot2.lt.epf) stop 900
      elseif(itype .eq. 2 .or. itype .eq. 3) then
         isi2 = icon(6,ivfnd)
         do 2300 i=4,6
            isi1 = icon(i,ivfnd)
            xtemp = x(isi2) - xdes
            ytemp = y(isi2) - ydes
            dls2 = dsqrt(xtemp**2 + ytemp**2)
            if(dls2.lt.epf) go to 2220
            dalx = y(isi2) - y(isi1)
            daly = x(isi1) - x(isi2)
            daf = dsqrt(dalx**2 + daly**2)
            if(daf .lt. epf) go to 2220
            dot3 = (dalx * xtemp + daly * ytemp)/daf
            if(dot3.ge.epf .or. dot3.le.-epf) go to 2240
 2220       continue
            call innsgn(ix, iy, ix2, iy2, isi1, isi2, ipoint, mhalf,
     *                  mfull, isclp, isga)
            if(isga.gt.0) then
               dot3 = 10.0d0
            elseif(isga.lt.0) then
               dot3 =-10.0d0
            else
               dot3 = 0.0d0
            endif
 2240       continue
            if(itype .eq. 2) then
               if(iright.eq.isi1) then
                  if(dot3.ge.epf .or. dot3.le.-epf) stop 905
               else
                  if(dot3.gt.-epf) stop 910
               endif
            else
               if(dot3.gt.-epf) stop 915
            endif
            isi2 = isi1
 2300    continue
      else
         stop 920
      endif
c
 3000 continue
      return
      end
*EDGINT
c
c     subroutine edgint to -
c
c     insert a point into current triangulation when point is in the
c     interior of an edge of a triangle
c
c     January 31, 1991
c
      subroutine edgint(icon, is, iave, ivnxt, nvmax, nvmz, ivcur,
     *                  isite, islt, iabe)
c
      integer ivnxt, nvmax, nvmz, ivcur, isite, islt, iabe
      integer icon(6,*), is(*), iave(*)
c
      integer it1, it2, it3, it4, iv1, iv2, iv3, iv4
      integer isrt, isad, ivadj, isop, ivodj
c
      it1 = ivcur
      if(icon(4,ivcur) .eq. islt) then
          isrt = icon(6,ivcur)
          isad = icon(5,ivcur)
          ivadj = icon(2,ivcur)
          iv1 = icon(3,ivcur)
          iv2 = icon(1,ivcur)
      elseif(icon(5,ivcur) .eq. islt) then
          isrt = icon(4,ivcur)
          isad = icon(6,ivcur)
          ivadj = icon(3,ivcur)
          iv1 = icon(1,ivcur)
          iv2 = icon(2,ivcur)
      elseif(icon(6,ivcur) .eq. islt) then
          isrt = icon(5,ivcur)
          isad = icon(4,ivcur)
          ivadj = icon(1,ivcur)
          iv1 = icon(2,ivcur)
          iv2 = icon(3,ivcur)
      else
          stop 930
      endif
c
      it3 = iabs(ivadj)
      it4 = it3
      if(ivadj .eq. 0 .or. ivadj .eq. nvmz) go to 100
      if(icon(4,it4) .eq. islt) then
          isop = icon(6,it4)
          iv3 = icon(1,it4)
          iv4 = icon(2,it4)
      elseif(icon(5,it4) .eq. islt) then
          isop = icon(4,it4)
          iv3 = icon(2,it4)
          iv4 = icon(3,it4)
      elseif(icon(6,it4) .eq. islt) then
          isop = icon(5,it4)
          iv3 = icon(3,it4)
          iv4 = icon(1,it4)
      else
          stop 935
      endif
c
  100 continue
      it2 = iave(iabe)
      if(iabe .eq. 1) then
          ivnxt = it2
          if(ivnxt .gt. nvmax) stop 940
          iave(1) = ivnxt + 1
      else
          iabe = iabe - 1
      endif
      if(ivadj .eq. 0 .or. ivadj .eq. nvmz) go to 200
      it3 = iave(iabe)
      if(iabe .eq. 1) then
          ivnxt = it3
          if(ivnxt .gt. nvmax) stop 945
          iave(1) = ivnxt + 1
      else
          iabe = iabe - 1
      endif
c
  200 continue
      is(isite) = it1
      if(is(isad) .eq. it1) is(isad) = it2
      if(is(isrt) .eq. it1) is(isrt) = it2
      if(is(isrt) .eq. it4) is(isrt) = it3
c
c     create new triangles
c
      icon(1,it1) = iv1
      icon(2,it1) = it2
      icon(3,it1) = it4
      icon(4,it1) = isite
      icon(5,it1) = islt
      icon(6,it1) = isad
c
      icon(1,it2) = iv2
      icon(2,it2) = it3
      icon(3,it2) = it1
      icon(4,it2) = isite
      icon(5,it2) = isad
      icon(6,it2) = isrt
c
      if(islt.eq.isad.or.isrt.eq.isad.or.isite.eq.islt.or.
     *   isite.eq.isrt.or.isite.eq.isad) stop 950
c
      if(ivadj .lt. 0) then
          icon(3,it1) = -it4
          icon(2,it2) = -it3
      endif
c
      if(ivadj .eq. 0 .or. ivadj .eq. nvmz) go to 300
      icon(1,it3) = iv3
      icon(2,it3) = it4
      icon(3,it3) = it2
      icon(4,it3) = isite
      icon(5,it3) = isrt
      icon(6,it3) = isop
c
      icon(1,it4) = iv4
      icon(2,it4) = it1
      icon(3,it4) = it3
      icon(4,it4) = isite
      icon(5,it4) = isop
      icon(6,it4) = islt
c
      if(islt.eq.isop.or.isrt.eq.isop.or.isite.eq.isop) stop 955
c
      if(ivadj .lt. 0) then
          icon(3,it3) = -it2
          icon(2,it4) = -it1
      endif
c
c     update neighboring triangles
c
  300 continue
      if(iv2 .eq. 0 .or. iv2 .eq. nvmz) go to 400
      ivodj = it1
      if(iv2 .lt. 0) then
          iv2 = -iv2
          it2 = -it2
          ivodj = -ivodj
      endif
c
      if(icon(1,iv2) .eq. ivodj) then
          icon(1,iv2) = it2
      elseif(icon(2,iv2) .eq. ivodj) then
          icon(2,iv2) = it2
      elseif(icon(3,iv2) .eq. ivodj) then
          icon(3,iv2) = it2
      else
          stop 960
      endif
  400 continue
c
      if(ivadj .eq. 0 .or. ivadj .eq. nvmz) go to 500
      if(iv3 .eq. 0 .or. iv3 .eq. nvmz) go to 500
      ivodj = it4
      if(iv3 .lt. 0) then
          iv3 = -iv3
          it3 = -it3
          ivodj = -ivodj
      endif
c
      if(icon(1,iv3) .eq. ivodj) then
          icon(1,iv3) = it3
      elseif(icon(2,iv3) .eq. ivodj) then
          icon(2,iv3) = it3
      elseif(icon(3,iv3) .eq. ivodj) then
          icon(3,iv3) = it3
      else
          stop 970
      endif
  500 continue
c
      return
      end
*INTINS
c
c     subroutine intins to -
c
c     insert a point into current triangulation when point is in
c     the interior of a triangle
c
c     January 31, 1991
c
      subroutine intins(icon, is, iave, ivnxt, nvmax, nvmz, ivcur,
     *                  isite, iabe)
c
      integer ivnxt, nvmax, nvmz, ivcur, isite, iabe
      integer icon(6,*), is(*), iave(*)
c
      integer it1, it2, it3, iv1, iv2, iv3, is4, is5, is6, ivadj
c
      it1 = ivcur
      it2 = iave(iabe)
      if(iabe .eq. 1) then
          ivnxt = it2
          if(ivnxt .gt. nvmax) stop 1000
          iave(1) = ivnxt + 1
      else
          iabe = iabe - 1
      endif
      it3 = iave(iabe)
      if(iabe .eq. 1) then
          ivnxt = it3
          if(ivnxt .gt. nvmax) stop 1010
          iave(1) = ivnxt + 1
      else
          iabe = iabe - 1
      endif
c
      iv1 = icon(1,ivcur)
      iv2 = icon(2,ivcur)
      iv3 = icon(3,ivcur)
c
      is4 = icon(4,ivcur)
      is5 = icon(5,ivcur)
      is6 = icon(6,ivcur)
c
      if(is4.eq.is5.or.is4.eq.is6.or.is5.eq.is6.or.isite.eq.is4.or.
     *   isite.eq.is5.or.isite.eq.is6) stop 1020
c
      is(isite) = it1
      if(is(is4) .eq. ivcur) is(is4) = it3
      if(is(is6) .eq. ivcur) is(is6) = it2
c
c     create new triangles
c
      icon(1,it1) = iv1
      icon(2,it1) = it2
      icon(3,it1) = it3
      icon(4,it1) = isite
      icon(5,it1) = is5
      icon(6,it1) = is6
c
      icon(1,it2) = iv2
      icon(2,it2) = it3
      icon(3,it2) = it1
      icon(4,it2) = isite
      icon(5,it2) = is6
      icon(6,it2) = is4
c
      icon(1,it3) = iv3
      icon(2,it3) = it1
      icon(3,it3) = it2
      icon(4,it3) = isite
      icon(5,it3) = is4
      icon(6,it3) = is5
c
c     update neighboring triangles
c
      if(iv2 .eq. 0 .or. iv2 .eq. nvmz) go to 100
      ivadj = ivcur
      if(iv2 .lt. 0) then
          iv2 = -iv2
          it2 = -it2
          ivadj = -ivadj
      endif
c
      if(icon(1,iv2) .eq. ivadj) then
          icon(1,iv2) = it2
      elseif(icon(2,iv2) .eq. ivadj) then
          icon(2,iv2) = it2
      elseif(icon(3,iv2) .eq. ivadj) then
          icon(3,iv2) = it2
      else
          stop 1030
      endif
  100 continue
c
      if(iv3 .eq. 0 .or. iv3 .eq. nvmz) go to 200
      ivadj = ivcur
      if(iv3 .lt. 0) then
          iv3 = -iv3
          it3 = -it3
          ivadj = -ivadj
      endif
c
      if(icon(1,iv3) .eq. ivadj) then
          icon(1,iv3) = it3
      elseif(icon(2,iv3) .eq. ivadj) then
          icon(2,iv3) = it3
      elseif(icon(3,iv3) .eq. ivadj) then
          icon(3,iv3) = it3
      else
          stop 1040
      endif
  200 continue
c
      return
      end
*OUTHUL
c
c     subroutine outhul to -
c
c     insert a point that lies outside current triangulation
c
c     February 20, 1991
c
      subroutine outhul(x, y, ix, iy, ix2, iy2, icon, is, iave,
     *                  ivnxt, nvmax, nvmz, mhalf, mfull, isclp,
     *                  ivfnd, isite, islt, iabe, epf)
c
      integer ivnxt, nvmax, nvmz, mhalf, mfull, isclp(*)
      integer ivfnd, isite, islt, iabe
      double precision epf
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer icon(6,*), is(*), iave(*)
c
      integer ivcur, isrt, ivadj, isfn, ivlst, indx, ivcar, ivfad
      integer ivfin, ivnow, ivout, ivini, isga
      double precision delx, dely, dif, xtemp, ytemp, dlst, dot
c
c     search for first visible site from isite
c
      ivcur = is(islt)
      ivini = ivcur
  100 continue
      if(icon(4,ivcur) .eq. islt) then
          isrt = icon(6,ivcur)
          ivadj = icon(2,ivcur)
      elseif(icon(5,ivcur) .eq. islt) then
          isrt = icon(4,ivcur)
          ivadj = icon(3,ivcur)
      elseif(icon(6,ivcur) .eq. islt) then
          isrt = icon(5,ivcur)
          ivadj = icon(1,ivcur)
      else
          stop 1100
      endif
c
      if(ivadj .eq. 0 .or. ivadj .eq. nvmz) go to 200
      ivcur = iabs(ivadj)
      if(ivcur.eq.ivini) stop 1105
      go to 100
c
  200 continue
      delx = y(isite) - y(isrt)
      dely = x(isrt) - x(isite)
      dif = dsqrt(delx ** 2 + dely ** 2)
      if(dif .lt. epf) go to 220
      xtemp = x(islt) - x(isite)
      ytemp = y(islt) - y(isite)
      dlst=dsqrt(xtemp**2+ytemp**2)
      if(dlst .lt. epf) go to 220
      dot = (delx * xtemp + dely * ytemp)/dif
c     WRITE(*,*)'1 ISITE=',ISITE,' ISRT=',ISRT,' ISLT=',ISLT,' DOT=',DOT
      if(dot.ge.epf .or. dot.le.-epf) go to 240
  220 continue
c     WRITE(*,*)'OUTHUL INNSGN 1'
      call innsgn(ix, iy, ix2, iy2, isite, isrt, islt, mhalf, mfull,
     *            isclp, isga)
      if(isga.gt.0) then
         dot = 10.0d0
      elseif(isga.lt.0) then
         dot =-10.0d0
      else
         dot = 0.0d0
      endif
  240 continue
      if(dot .gt. -epf) go to 300
      islt = isrt
      go to 100
c
c     generate triangles with isite as a vertex
c
  300 continue
      isfn = islt
      ivlst = 0
  400 continue
      ivcur = is(islt)
      isrt = islt
      if(icon(4,ivcur) .eq. isrt) then
          indx = 3
          islt = icon(5,ivcur)
          ivadj = icon(3,ivcur)
      elseif(icon(5,ivcur) .eq. isrt) then
          indx = 1
          islt = icon(6,ivcur)
          ivadj = icon(1,ivcur)
      elseif(icon(6,ivcur) .eq. isrt) then
          indx = 2
          islt = icon(4,ivcur)
          ivadj = icon(2,ivcur)
      else
          stop 1120
      endif
      if(ivadj .ne. 0 .and. ivadj .ne. nvmz) stop 1130
c
      delx = y(isite) - y(isrt)
      dely = x(isrt) - x(isite)
      dif = dsqrt(delx ** 2 + dely ** 2)
      if(dif .lt. epf) go to 420
      xtemp = x(islt) - x(isite)
      ytemp = y(islt) - y(isite)
      dlst=dsqrt(xtemp**2+ytemp**2)
      if(dlst .lt. epf) go to 420
      dot = (delx * xtemp + dely * ytemp)/dif
c     WRITE(*,*)'2 ISITE=',ISITE,' ISRT=',ISRT,' ISLT=',ISLT,' DOT=',DOT
      if(dot.ge.epf .or. dot.le.-epf) go to 440
  420 continue
c     WRITE(*,*)'OUTHUL INNSGN 2'
      call innsgn(ix, iy, ix2, iy2, isite, isrt, islt, mhalf, mfull,
     *            isclp, isga)
      if(isga.gt.0) then
         dot = 10.0d0
      elseif(isga.lt.0) then
         dot =-10.0d0
      else
         dot = 0.0d0
      endif
  440 continue
      if(dot .gt. -epf) go to 500
c
      ivfnd = iave(iabe)
      if(iabe .eq. 1) then
          ivnxt = ivfnd
          if(ivnxt .gt. nvmax) stop 1150
          iave(1) = ivnxt + 1
      else
          iabe = iabe - 1
      endif
c
      ivcar = ivcur
      ivfad = ivfnd
      if(ivadj .eq. nvmz) then
          ivcar = -ivcar
          ivfad = -ivfad
      endif
      icon(indx,ivcur) = ivfad
      icon(1,ivfnd) = ivcar
      icon(2,ivfnd) = ivlst
      icon(4,ivfnd) = isite
      icon(5,ivfnd) = islt
      icon(6,ivfnd) = isrt
c
      if(islt.eq.isrt.or.isite.eq.islt.or.isite.eq.isrt) stop 1160
c
      if(ivlst .ne. 0) icon(3,ivlst) = ivfnd
      ivlst = ivfnd
      if(isrt .ne. isfn) then
          if(ivadj .eq. nvmz) go to 400
          ivfin = icon(2,ivfnd)
          ivnow = ivcur
  450     continue
          if(icon(4,ivnow) .eq. isrt) then
              ivout = icon(2,ivnow)
          elseif(icon(5,ivnow) .eq. isrt) then
              ivout = icon(3,ivnow)
          elseif(icon(6,ivnow) .eq. isrt) then
              ivout = icon(1,ivnow)
          else
              stop 1170
          endif
          if(ivout .lt. 0) then
              is(isrt) = -ivout
              go to 400
          endif
          if(ivout .eq. ivfin) go to 400
          ivnow = ivout
          go to 450
      else
          is(isrt) = ivfnd
          go to 400
      endif
c
  500 continue
      if(ivlst .eq. 0) stop 1180
      icon(3,ivlst) = 0
      is(isite) = ivfnd
c
      return
      end
*OPTTRI
c
c     subroutine opttri to -
c
c     optimize triangulation by edge swapping with respect to a point,
c     in the direction of a triangle that has the point as a vertex
c
c     February 15, 1991
c
      subroutine opttri(x, y, ix, iy, ix2, iy2, icon, is, epf,
     *                 ivcur, isite, nvmz, mhalf, mfull, isclp)
c
      integer ivcur, isite, nvmz, mhalf, mfull, isclp(*)
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer icon(6,*), is(*)
      double precision zlamb, dot2, dot, dat, dif1, dif2, dif3
      double precision delx1, dely1, delx2, dely2, delx3, dely3
      double precision epf, vx, vy, tdist
      integer ishat, isadj, iscur, isfin, ivadj
      integer ivout, ivcar, ivodj, itide
c
c     initialize
c
      isadj = icon(5,ivcur)
      iscur = icon(6,ivcur)
      isfin = isadj
c
      if(isite.eq.isadj.or.isite.eq.iscur.or.isadj.eq.iscur) stop 1200
c
  100 continue
      if(icon(1,ivcur) .le. 0) go to 500
      ivadj = icon(1,ivcur)
c
      if(icon(2,ivadj) .eq. ivcur) go to 150
      if(icon(1,ivadj) .eq. ivcur) then
          icon(1,ivadj) = icon(3,ivadj)
          icon(3,ivadj) = icon(2,ivadj)
          icon(5,ivadj) = icon(4,ivadj)
      elseif(icon(3,ivadj) .eq. ivcur) then
          icon(3,ivadj) = icon(1,ivadj)
          icon(1,ivadj) = icon(2,ivadj)
          icon(5,ivadj) = icon(6,ivadj)
      else
          stop 1210
      endif
      icon(2,ivadj) = ivcur
      icon(4,ivadj) = isadj
      icon(6,ivadj) = iscur
  150 continue
      ishat = icon(5,ivadj)
c
      if(ishat.eq.isite.or.ishat.eq.isadj.or.ishat.eq.iscur) stop 1220
c
c     compute center of circumcircle for triangle isite-isadj-iscur
c
      delx1 = x(ishat) - x(isite)
      dely1 = y(ishat) - y(isite)
      dif1 = dsqrt(delx1**2 + dely1**2)
      if(dif1 .lt. epf) go to 300
c
      delx2 = y(isadj) - y(iscur)
      dely2 = x(iscur) - x(isadj)
      dif2 = dsqrt(delx2**2 + dely2**2)
      if(dif2 .lt. epf) go to 300
c
      delx3 = x(isite) - x(isadj)
      dely3 = y(isite) - y(isadj)
      dif3 = dsqrt(delx3**2 + dely3**2)
      if(dif3 .lt. epf) go to 300
c
      delx1 = x(isite) - x(iscur)
      dely1 = y(isite) - y(iscur)
      dif1 = dsqrt(delx1**2 + dely1**2)
      if(dif1 .lt. epf) go to 300
c
      dot = delx2*delx1 + dely2*dely1
      if(dot.lt.epf .and. dot.gt.-epf) go to 300
      dot2 = dot/dif2
      if(dot2.lt.epf .and. dot2.gt.-epf) go to 300
      dat = delx1*delx3 + dely1*dely3
      zlamb = dat/dot
      vx = .5*(x(isadj)+x(iscur) + zlamb*delx2)
      vy = .5*(y(isadj)+y(iscur) + zlamb*dely2)
      call biscrc (x, y, ishat, isite, epf, vx, vy, tdist)
      if(tdist.le.-epf) go to 500
      if(tdist.ge.epf) go to 400
  300 continue
      call circsn(ix, iy, ix2, iy2, isite, isadj, iscur, ishat,
     *            mhalf, mfull, isclp, itide)
      if(itide .ge. 0) go to 500
c
c     switch diagonals of quadrilateral
c
  400 continue
      icon(1,ivcur) = icon(3,ivadj)
      icon(3,ivadj) = ivcur
      icon(2,ivadj) = icon(2,ivcur)
      icon(2,ivcur) = ivadj
      icon(6,ivcur) = ishat
      icon(4,ivadj) = isite
      ivout = icon(1,ivcur)
      if(ivout .eq. 0 .or. ivout .eq. nvmz) go to 470
      ivcar = ivcur
      ivodj = ivadj
      if(ivout .lt. 0) then
          ivout = -ivout
          ivcar = -ivcar
          ivodj = -ivodj
      endif
      if(icon(1,ivout) .eq. ivodj) then
          icon(1,ivout) = ivcar
      elseif(icon(2,ivout) .eq. ivodj) then
          icon(2,ivout) = ivcar
      elseif(icon(3,ivout) .eq. ivodj) then
          icon(3,ivout) = ivcar
      else
          stop 1260
      endif
  470 continue
      ivout = icon(2,ivadj)
      if(ivout .eq. 0 .or. ivout .eq. nvmz) go to 480
      ivodj = ivadj
      if(ivout .lt. 0) then
          ivout = -ivout
          ivodj = -ivodj
      endif
      icon(3,ivout) = ivodj
  480 continue
c
      if(is(isadj) .eq. ivadj) is(isadj) = ivcur
      if(is(iscur) .eq. ivcur) is(iscur) = ivadj
c
      ivcur = ivadj
      isadj = ishat
      go to 100
c
c     move to next triangle with isite as a vertex
c
  500 continue
      if(isadj .eq. isfin) go to 900
      ivadj = icon(3,ivcur)
      ivcur = ivadj
      iscur = isadj
      isadj = icon(5,ivcur)
      go to 100
c
  900 continue
      return
      end
*BISCRC
c
c This subroutine will compute the distance from center of circle to
c bisector line between vertex of triangle and ishat
c
      subroutine biscrc (x, y, ishat, ivrt, epf, xctr, yctr, tdist)
c
      double precision x(*), y(*), norm
      integer ishat, ivrt
      double precision epf, xctr, yctr, tdist
c
      double precision xm, ym, xu, yu, xd, yd, dif, dmax
c
c     find midpoint of edge from ishat to ivrt
c
      xm = (x(ishat) + x(ivrt)) / 2.0d0
      ym = (y(ishat) + y(ivrt)) / 2.0d0
c
c     find vector from ivrt to ishat
c
      xu = x(ishat) - x(ivrt)
      yu = y(ishat) - y(ivrt)
c 
      norm = dsqrt (xu**2 + yu**2)
      if (norm .lt. epf) stop 1270
c
      xd = xctr-xm
      yd = yctr-ym
      dif = dsqrt(xd**2 + yd**2)
c
      dmax = dmax1(norm,dif)
c
c     compute distance
c
      tdist = (xd*xu + yd*yu)/dmax
c
      return
      end
*RECONC
c
c     subroutine reconc to -
c
c     reconcile a line segment with current triangulation so as to
c     obtain a Delaunay triangulation constrained by the line segments
c     that have been reconciled with the triangulation so far
c
c     November 30, 1987
c
      subroutine reconc(x, y, ix, iy, ix2, iy2, is, icon, ifun, irun,
     *                  isun, izun, igun, iwun, ia, epf, mhalf, mfull,
     *                  isclp, nfmax, nhmax, nvmz, nvmp, nvmn,
     *                  ileft, iright, n)
c
      integer mhalf, mfull, isclp(*)
      integer nfmax, nhmax, nvmz, nvmp, nvmn, ileft, iright, n
      double precision epf
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer is(*), icon(6,*), ia(*)
      integer ifun(*), irun(*), isun(*), izun(*)
      integer igun(*), iwun(*)
c
      integer nkmax, iperp
      parameter (nkmax=30)
      integer iax(nkmax), iay(nkmax), isgax, isgay, ikax, ikay, isga
      double precision delx, dely, dif, xtemp, ytemp, dot1, dot2, dot
      double precision dlg, dlg1, dlg2
      integer iloft, ivini, ivcur, ivadj, ivpre, ivfol, isi1, isi2, isi3
      integer indx, indy, lf, lr, ian, ivpro, l, isam, mslop, mintr
      integer iam, iopt, j, ial, iap, iflg
c
c     test nvmn and nvmp values
c
      if(nvmn .ne. nvmz - 1 .or. nvmp .ne. -nvmn) stop 1310
c
c     compute endpoints parameters
c
      if(ileft.lt.1.or.iright.lt.1.or.ileft.gt.n.or.iright.gt.n)
     *   stop 1320
      if(ileft .eq. iright) go to 600
      iperp = 0
      delx = y(ileft) - y(iright)
      dely = x(iright) - x(ileft)
      dif = dsqrt(delx**2 + dely**2)
      if(dif .lt. epf) iperp = 1
      call prpvec(ix, iy, ix2, iy2, ileft, iright, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay)
      if(isgax.eq.0 .and. isgay.eq.0) stop 1330
      iloft = ileft
c
   50 continue
      ivini = is(iloft)
      ivcur = ivini
c
c     test vertices of current triangle
c
  100 continue
      if(icon(4,ivcur) .eq. iloft) then
          ivadj = icon(2,ivcur)
          ivpre = icon(3,ivcur)
          ivfol = icon(1,ivcur)
          isi2 = icon(5,ivcur)
          isi1 = icon(6,ivcur)
          indx = 3
          indy = 2
      elseif(icon(5,ivcur) .eq. iloft) then
          ivadj = icon(3,ivcur)
          ivpre = icon(1,ivcur)
          ivfol = icon(2,ivcur)
          isi2 = icon(6,ivcur)
          isi1 = icon(4,ivcur)
          indx = 1
          indy = 3
      elseif(icon(6,ivcur) .eq. iloft) then
          ivadj = icon(1,ivcur)
          ivpre = icon(2,ivcur)
          ivfol = icon(3,ivcur)
          isi2 = icon(4,ivcur)
          isi1 = icon(5,ivcur)
          indx = 2
          indy = 1
      else
          stop 1340
      endif
c
      if(iperp.eq.1) go to 110
      xtemp = x(isi2) - x(iloft)
      ytemp = y(isi2) - y(iloft)
      dlg2 = dsqrt(xtemp**2 + ytemp**2)
      if(dlg2 .lt. epf) go to 110
      dot2 = (delx * xtemp + dely * ytemp)/dif
      if(dot2.ge.epf .or. dot2.le.-epf) go to 120
  110 continue
      call distsn(ix, iy, ix2, iy2, iloft, isi2, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay, isga)
      if(isga.gt.0) then
         dot2 = 10.0d0
      elseif(isga.lt.0) then
         dot2 =-10.0d0
      else
         dot2 = 0.0d0
      endif
  120 continue
      if(dot2 .ge. epf) go to 200
c
      if(iperp.eq.1) go to 130
      xtemp = x(isi1) - x(iloft)
      ytemp = y(isi1) - y(iloft)
      dlg1 = dsqrt(xtemp**2 + ytemp**2)
      if(dlg1 .lt. epf) go to 130
      dot1 = (delx * xtemp + dely * ytemp)/dif
      if(dot1.ge.epf .or. dot1.le.-epf) go to 140
  130 continue
      call distsn(ix, iy, ix2, iy2, iloft, isi1, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay, isga)
      if(isga.gt.0) then
         dot1 = 10.0d0
      elseif(isga.lt.0) then
         dot1 =-10.0d0
      else
         dot1 = 0.0d0
      endif
  140 continue
      if(dot1 .lt. epf) go to 200
      if(dot2 .le. -epf) go to 150
      if(ivpre .lt. 0) go to 500
      if(ivpre .eq. 0) then
          icon(indx,ivcur) = nvmz
          go to 500
      endif
      icon(indx,ivcur) = -ivpre
      if(icon(1,ivpre) .eq. ivcur) then
          icon(1,ivpre) = -ivcur
      elseif(icon(2,ivpre) .eq. ivcur) then
          icon(2,ivpre) = -ivcur
      elseif(icon(3,ivpre) .eq. ivcur) then
          icon(3,ivpre) = -ivcur
      else
          stop 1350
      endif
      go to 500
  150 continue
      if(isi2 .eq. iright) stop 1355
      if(2 .gt. nfmax) stop 1360
      ifun(1) = iloft
      ifun(2) = isi2
      irun(1) = iloft
      irun(2) = isi1
      lf = 2
      lr = 2
      isun(1) = ivpre
      izun(1) = ivadj
      icon(4,ivcur) = -1
      ian = 1
      if(1 .gt. nhmax) stop 1370
      ia(1) = ivcur
      go to 300
c
  200 continue
      ivpro = ivcur
      ivcur = iabs(ivadj)
      if(ivcur .eq. ivini) stop 1380
      if(ivadj .ne. 0 .and. ivadj .ne. nvmz) go to 100
      if(dot2.gt.-epf .or. dot1.le.-epf) stop 1385
      isi2 = isi1
      if(ivadj .eq. nvmz) go to 500
      icon(indy,ivpro) = nvmz
      go to 500
c
c     find vertex for next triangle
c
  300 continue
      if(ivfol .le. 0) then
          write(*,*)' reconc: inappropriate crossing of line segments'
          write(*,*)' endpoints of first segment are'
          write(*,*)' ( ',x(isi1),' , ',y(isi1),' ) and ( ',
     *                    x(isi2),' , ',y(isi2),' )'
          write(*,*)' endpoints of second segment are'
          write(*,*)' ( ',x(ileft),' , ',y(ileft),' ) and ( ',
     *                    x(iright),' , ',y(iright),' )'
          write(*,*)' program terminated'
          stop 1390
      endif
      if(icon(4,ivfol) .eq. isi2) then
          isi3 = icon(5,ivfol)
          ivadj = icon(1,ivfol)
          ivpre = icon(3,ivfol)
      elseif(icon(5,ivfol) .eq. isi2) then
          isi3 = icon(6,ivfol)
          ivadj = icon(2,ivfol)
          ivpre = icon(1,ivfol)
      elseif(icon(6,ivfol) .eq. isi2) then
          isi3 = icon(4,ivfol)
          ivadj = icon(3,ivfol)
          ivpre = icon(2,ivfol)
      else
          stop 1400
      endif
c
      if(iperp.eq.1) go to 330
      xtemp = x(isi3) - x(iloft)
      ytemp = y(isi3) - y(iloft)
      dlg = dsqrt(xtemp**2 + ytemp**2)
      if(dlg .lt. epf) go to 330
      dot = (delx * xtemp + dely * ytemp)/dif
      if(dot.ge.epf .or. dot.le.-epf) go to 340
  330 continue
      call distsn(ix, iy, ix2, iy2, iloft, isi3, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay, isga)
      if(isga.gt.0) then
         dot = 10.0d0
      elseif(isga.lt.0) then
         dot =-10.0d0
      else
         dot = 0.0d0
      endif
  340 continue
      icon(4,ivfol) = -1
      ian = ian + 1
      if(ian .gt. nhmax) stop 1410
      ia(ian) = ivfol
      if((dot .le. -epf .or.  dot .ge. epf) .and. isi3 .eq. iright)
     *   stop 1415
      if(dot .gt. -epf .and. dot .lt. epf) then
          lf = lf + 1
          lr = lr + 1
          if(lf .gt. nfmax) stop 1420
          if(lr .gt. nfmax) stop 1430
          ifun(lf) = isi3
          irun(lr) = isi3
          isun(lf-1) = ivpre
          izun(lr-1) = ivadj
          isi2 = isi3
          go to 400
      elseif(dot .ge. epf) then
          lr = lr + 1
          if(lr .gt. nfmax) stop 1440
          irun(lr) = isi3
          izun(lr-1) = ivadj
          ivfol = ivpre
          isi1 = isi3
      else
          lf = lf + 1
          if(lf .gt. nfmax) stop 1450
          ifun(lf) = isi3
          isun(lf-1) = ivpre
          ivfol = ivadj
          isi2 = isi3
      endif
      go to 300
c
c     retriangulate
c
  400 continue
c
c     test for eliminated adjacent triangles
c
      do 410 l = 1, lf - 1
          isam = isun(l)
          if(isam .eq. 0 .or. isam .eq. nvmz) go to 410
          if(icon(4,iabs(isam)) .ne. -1) go to 410
          if(isam .gt. 0) then
              isun(l) = nvmp
          else
              isun(l) = nvmn
          endif
  410 continue
      do 420 l = 1, lr - 1
          isam = izun(l)
          if(isam .eq. 0 .or. isam .eq. nvmz) go to 420
          if(icon(4,iabs(isam)) .ne. -1) go to 420
          if(isam .gt. 0) then
              izun(l) = nvmp
          else
              izun(l) = nvmn
          endif
  420 continue
c
c     triangulate 'right' edge star-shaped polygon
c
      mslop = 1
      mintr = 0
      iam = 0
      iopt = 3
c
      call edgstr(x, y, ix, iy, ix2, iy2, icon, ifun, igun, iwun,
     *            ia, epf, mhalf, mfull, isclp, lf,
     *            ian, iam, mslop, mintr, j, iopt)
c
      if(j .ne. 2) stop 1460
      ial = iwun(1)
      iap = ial
c
c     reconcile new triangles with rest of triangulation
c
      iflg = 0
      call mattri(is, icon, ifun, isun, ial, lf, nvmz, nvmp, nvmn, iflg)
c
c     triangulate 'left' edge star-shaped polygon
c
      lf = lr
      do 480 l = 1, lr - 1
          ifun(l) = irun(lr + 1 - l)
          isun(l) = izun(lr - l)
  480 continue
      ifun(lr) = irun(1)
      mslop = -1
      mintr = ian + iam + 1
c
      call edgstr(x, y, ix, iy, ix2, iy2, icon, ifun, igun, iwun,
     *            ia, epf, mhalf, mfull, isclp, lf,
     *            ian, iam, mslop, mintr, j, iopt)
c
      if(j .ne. 2) stop 1470
      ial = iwun(1)
      icon(2,ial) = -iap
      icon(2,iap) = -ial
c
c     reconcile new triangles with rest of triangulation
c
      iflg = 1
      call mattri(is, icon, ifun, isun, ial, lf, nvmz, nvmp, nvmn, iflg)
c
c     reinitialize to reconcile next portion of line segment
c
  500 continue
      if(isi2 .eq. iright) go to 600
      iloft = isi2
      go to 50
c
  600 continue
      return
      end
*EDGSTR
c
c     subroutine edgsrt to -
c
c     compute a (Delaunay) triangulation for a subset of the boundary
c     of one or more adjacent edge star-shaped simple polygons
c     constrained by their boundaries
c
c     December 4, 1987
c
      subroutine edgstr(x, y, ix, iy, ix2, iy2, icon, ifun, igun, iwun,
     *                  ia, epf, mhalf, mfull, isclp, lf,
     *                  ian, iam, mslop, mintr, j, iopt)
c
      integer mhalf, mfull, isclp(*)
      integer lf, ian, iam, mslop, mintr, j, iopt
      double precision epf
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer icon(6,*), ia(*)
      integer ifun(*), igun(*), iwun(*)
c
      integer i, iq1, iq2, iq3, ial, isga
      double precision dulx, duly, dif, dlst, xtemp, ytemp, dot
c
      iwun(1) = 0
      igun(1) = ifun(1)
      igun(2) = ifun(2)
      i = 2
      j = 2
c
  100 continue
      if(i .eq. lf) go to 400
      iwun(j) = 0
      i = i + 1
      if(i .eq. lf .and. iopt .eq. 4) iopt = 1
      j = j + 1
      igun(j) = ifun(i)
      iq1 = igun(j-2)
      iq2 = igun(j-1)
      iq3 = igun(j)
c
  200 continue
      if(i .eq. lf .and. iopt .gt. 0) go to 300
      dulx = y(iq1) - y(iq2)
      duly = x(iq2) - x(iq1)
      dif = dsqrt(dulx**2 + duly**2)
      if(dif .lt. epf) go to 220
      xtemp = x(iq3) - x(iq1)
      ytemp = y(iq3) - y(iq1)
      dlst = dsqrt(xtemp**2 + ytemp**2)
      if(dlst .lt. epf) go to 220
      dot = (dulx * xtemp + duly * ytemp)/dif
      if(dot.ge.epf .or. dot.le.-epf) go to 240
  220 continue
      call innsgn(ix, iy, ix2, iy2, iq1, iq2, iq3, mhalf, mfull,
     *            isclp, isga)
      if(isga.gt.0) then
         dot = 10.0d0
      elseif(isga.lt.0) then
         dot =-10.0d0
      else
         dot = 0.0d0
      endif
  240 continue
      if(dot .lt. epf) go to 100
c
  300 continue
      iam = iam + 1
      if(iam .gt. ian) stop 1500
      ial = ia(mslop*iam+mintr)
      icon(3,ial) = iwun(j-2)
      icon(1,ial) = iwun(j-1)
      icon(2,ial) = 0
      icon(4,ial) = iq1
      icon(5,ial) = iq2
      icon(6,ial) = iq3
      if(iwun(j-2) .ne. 0) icon(2,iwun(j-2)) = ial
      if(iwun(j-1) .ne. 0) icon(2,iwun(j-1)) = ial
c
c     update triangulation to obtain a Delaunay triangulation of the
c     union of the triangles obtained so far inside the polygon
c
      if(iopt .gt. 1) call updtri(x, y, ix, iy, ix2, iy2, icon, epf,
     *                mhalf, mfull, isclp, ial, iq1, iq2, iq3)
c
      j = j - 1
      iwun(j-1) = ial
      igun(j) = iq3
c
      if(j .eq. 2) go to 100
      iq1 = igun(j-2)
      iq2 = igun(j-1)
      go to 200
c
  400 continue
c
      return
      end
*MATTRI
c
c     subroutine mattri to -
c
c     reconcile triangulation of an edge star-shaped polygon with
c     rest of triangulation
c
c     December 8, 1987
c
      subroutine mattri(is, icon, ifun, isun, ial, lf, nvmz, nvmp,
     *                  nvmn, iflg)
c
      integer ial, lf, nvmz, nvmp, nvmn, iflg
      integer is(*), icon(6,*), ifun(*), isun(*)
c
      integer ivcur, l, isite, ivadj, index, ivout, ivabs, ivpre
      integer ind1, ind2, isadj, isnxt, ivnow, l1, l2, ivini
c
c     reconcile triangulation with triangles outside polygon
c
      ivcur = ial
      do 400 l = 1, lf-1
          isite = ifun(l)
  100     continue
          if(icon(4,ivcur) .eq. isite) then
              ivadj = icon(3,ivcur)
              index = 3
          elseif(icon(5,ivcur) .eq. isite) then
              ivadj = icon(1,ivcur)
              index = 1
          elseif(icon(6,ivcur) .eq. isite) then
              ivadj = icon(2,ivcur)
              index = 2
          else
              stop 1600
          endif
          if(ivadj .eq. 0) go to 200
          ivcur = ivadj
          go to 100
c
  200     continue
          is(isite) = ivcur
          ivout = isun(l)
          if(ivout .eq. nvmp .or. ivout .eq. nvmn) go to 300
          isun(l) = 0
          icon(index,ivcur) = ivout
          if(ivout .eq. 0 .or. ivout .eq. nvmz) go to 400
          ivadj = ivcur
          if(ivout .lt. 0) ivadj = -ivcur
          ivabs = iabs(ivout)
          if(icon(4,ivabs) .eq. isite) then
              icon(2,ivabs) = ivadj
          elseif(icon(5,ivabs) .eq. isite) then
              icon(3,ivabs) = ivadj
          elseif(icon(6,ivabs) .eq. isite) then
              icon(1,ivabs) = ivadj
          else
              stop 1610
          endif
          go to 400
c
  300     continue
          isun(l) = ivcur
          if(ivout .eq. nvmn) isun(l) = -ivcur
c
  400 continue
c
c     reconcile triangulation with triangles inside polygon
c
      do 600 l = 1, lf-1
          if(isun(l) .eq. 0) go to 600
          ivout = isun(l)
          ivcur = iabs(ivout)
          isite = ifun(l)
          if(icon(4,ivcur) .eq. isite) then
              ivpre = icon(3,ivcur)
              ind1 = 3
          elseif(icon(5,ivcur) .eq. isite) then
              ivpre = icon(1,ivcur)
              ind1 = 1
          elseif(icon(6,ivcur) .eq. isite) then
              ivpre = icon(2,ivcur)
              ind1 = 2
          else
              stop 1620
          endif
          if(ivpre .ne. 0) stop 1630
          if(ivcur .ne. is(isite)) go to 600
          isadj = ifun(l+1)
c
          ivadj = ivcur
  500     continue
          ivnow = iabs(ivadj)
          if(icon(4,ivnow) .eq. isite) then
              ivadj = icon(2,ivnow)
              ind2 = 2
              isnxt = icon(6,ivnow)
          elseif(icon(5,ivnow) .eq. isite) then
              ivadj = icon(3,ivnow)
              ind2 = 3
              isnxt = icon(4,ivnow)
          elseif(icon(6,ivnow) .eq. isite) then
              ivadj = icon(1,ivnow)
              ind2 = 1
              isnxt = icon(5,ivnow)
          else
              stop 1640
          endif
          if(ivadj .ne. 0) go to 500
          if(isadj .ne. isnxt) stop 1650
          icon(ind1,ivcur) = ivnow
          if(ivout .lt. 0) icon(ind1,ivcur) = -ivnow
          icon(ind2,ivnow) = ivout
c
  600 continue
c
c     update array is
c
      if(iflg .eq. 0) then
          l1 = 2
          l2 = lf - 1
      else
          l1 = 1
          l2 = lf
      endif
      do 900 l = l1, l2
          isite = ifun(l)
          ivcur = is(isite)
          ivini = ivcur
  700     continue
          if(icon(4,ivcur) .eq. isite) then
              ivadj = icon(3,ivcur)
          elseif(icon(5,ivcur) .eq. isite) then
              ivadj = icon(1,ivcur)
          elseif(icon(6,ivcur) .eq. isite) then
              ivadj = icon(2,ivcur)
          else
              stop 1660
          endif
          if(ivadj .eq. 0 .or. ivadj .eq. nvmz) go to 800
          if(ivadj .lt. 0) is(isite) = ivcur
          ivcur = iabs(ivadj)
          if(ivcur .eq. ivini) go to 900
          go to 700
  800     continue
          is(isite) = ivcur
  900 continue
c
      return
      end
*UPDTRI
c
c     subroutine updtri to -
c
c     update a triangulation of a generalized multiply-connected
c     polygonal region to obtain a Delaunay triangulation
c     of the region
c
c     December 10, 1987
c
      subroutine updtri(x, y, ix, iy, ix2, iy2, icon, epf,
     *                  mhalf, mfull, isclp, ial, iq1, iq2, iq3)
c
      integer mhalf, mfull, isclp(*)
      integer ial, iq1, iq2, iq3
      double precision epf
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer icon(6,*)
c
      integer ivcur, isadj, iscur, isite, ivadj, ishat, itide
      double precision delx2, dely2, delx3, dely3, delx1, dely1
      double precision dif1, dif2, dif3, tdist
      double precision zlamb, vx, vy, dat, dot, dot2
c
c     initialize
c
      ivcur = ial
      isadj = iq1
      iscur = iq2
      isite = iq3
c
  100 continue
      if(icon(3,ivcur) .eq. 0) go to 500
      ivadj = icon(3,ivcur)
      ishat = icon(5,ivadj)
c
c     compute center of circumcircle for triangle isadj-iscur-iq3
c
      delx1 = x(ishat) - x(isite)
      dely1 = y(ishat) - y(isite)
      dif1 = dsqrt(delx1**2 + dely1**2)
      if(dif1 .lt. epf) go to 300
c
      delx2 = y(isadj) - y(iscur)
      dely2 = x(iscur) - x(isadj)
      dif2 = dsqrt(delx2**2 + dely2**2)
      if(dif2 .lt. epf) go to 300
c
      delx3 = x(isite) - x(isadj)
      dely3 = y(isite) - y(isadj)
      dif3 = dsqrt(delx3**2 + dely3**2)
      if(dif3 .lt. epf) go to 300
c
      delx1 = x(isite) - x(iscur)
      dely1 = y(isite) - y(iscur)
      dif1 = dsqrt(delx1**2 + dely1**2)
      if(dif1 .lt. epf) go to 300
c
      dot = delx2*delx1 + dely2*dely1
      if(dot.lt.epf .and. dot.gt.-epf) go to 300
      dot2 = dot/dif2
      if(dot2.lt.epf .and. dot2.gt.-epf) go to 300
      dat = delx1*delx3 + dely1*dely3
      zlamb = dat/dot
      vx = .5*(x(isadj)+x(iscur) + zlamb*delx2)
      vy = .5*(y(isadj)+y(iscur) + zlamb*dely2)
      call biscrc (x, y, ishat, isite, epf, vx, vy, tdist)
      if(tdist.le.-epf) go to 500
      if(tdist.ge.epf) go to 400
  300 continue
      call circsn(ix, iy, ix2, iy2, isite, isadj, iscur, ishat,
     *            mhalf, mfull, isclp, itide)
      if(itide .ge. 0) go to 500
c
c     switch diagonals of quadrilateral
c
  400 continue
      icon(3,ivcur) = icon(3,ivadj)
      icon(3,ivadj) = icon(1,ivadj)
      icon(1,ivadj) = icon(1,ivcur)
      icon(1,ivcur) = ivadj
      icon(5,ivcur) = ishat
      icon(4,ivadj) = ishat
      icon(5,ivadj) = iscur
      icon(6,ivadj) = iq3
      if(icon(3,ivcur) .ne. 0) icon(2,icon(3,ivcur)) = ivcur
      if(icon(1,ivadj) .ne. 0) icon(2,icon(1,ivadj)) = ivadj
c
      ivcur = ivadj
      isadj = ishat
      go to 100
c
c     move to next triangle with iq3 as a vertex
c
  500 continue
      if(isadj .eq. iq1) go to 600
      ivadj = icon(2,ivcur)
      ivcur = ivadj
      iscur = isadj
      isadj = icon(4,ivcur)
      go to 100
c
  600 continue
c
      return
      end
*DELELI
c
c     subroutine deleli to -
c
c     eliminate a vertex from a Delaunay triangulation so as to obtain
c     a Delaunay triangulation that does not include the vertex
c     (vertex can not be in an inserted edge)
c
c     February 28, 1991
c
      subroutine deleli(x, y, ix, iy, ix2, iy2, is, icon, ifun, irun,
     *                  isun, izun, igun, iwun, ia, iave, iaze, epf,
     *                  mhalf, mfull, isclp, nfmax, nhmax, njmax,
     *                  nkmax, nvmz, nvmp, nvmn, isite, n, isucs,
     *                  isnew, iabe, iase)
c
      integer mhalf, mfull, isclp(*)
      integer nfmax, nhmax, njmax, nkmax, nvmz, nvmp, nvmn
      integer isite, n, isucs, isnew, iabe, iase
      double precision epf
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer is(*), icon(6,*), ia(*)
      integer ifun(*), irun(*), isun(*), izun(*)
      integer igun(*), iwun(*), iave(*), iaze(*)
c
      integer mkmax, iperp
      parameter (mkmax=30)
      integer iax(mkmax), iay(mkmax), isgax, isgay, ikax, ikay, isga
      integer ivini, ivpre, ispre, ivout, ivadj, isadj, lf, lr, ian, i
      integer ivcur, ivtro, l, isam, mslop, mintr, iam, iopt, jr, ial
      integer iflg, ivabs, iscor, indx, lg, j, jf, isnow, iscur, iel
      double precision delx, dely, dif, dlg, xtemp, ytemp, dot
c
c     test nvmn and nvmp values
c
      if(nvmn .ne. nvmz - 1 .or. nvmp .ne. -nvmn) stop 1800
c
c     obtain 'right' side information
c
      isucs = 1
      if(n - iase + 1 .le. 3) then
          isucs = -2
          go to 2300
      endif
      if(isite .lt. 1 .or. isite .gt. n) stop 1810
      ivini = is(isite)
      if(icon(4,ivini) .eq. isite) then
          ivpre = icon(1,ivini)
          ispre = icon(5,ivini)
          ivout = icon(3,ivini)
          ivadj = icon(2,ivini)
          isadj = icon(6,ivini)
      elseif(icon(5,ivini) .eq. isite) then
          ivpre = icon(2,ivini)
          ispre = icon(6,ivini)
          ivout = icon(1,ivini)
          ivadj = icon(3,ivini)
          isadj = icon(4,ivini)
      elseif(icon(6,ivini) .eq. isite) then
          ivpre = icon(3,ivini)
          ispre = icon(4,ivini)
          ivout = icon(2,ivini)
          ivadj = icon(1,ivini)
          isadj = icon(5,ivini)
      else
          stop 1820
      endif
c
      lf = 0
      if(ivout .lt. 0) then
          isucs = 0
          go to 2300
      endif
c
c     compute 'splitting' vector
c
      iperp = 0
      delx = y(ispre) - y(isite)
      dely = x(isite) - x(ispre)
      dif = dsqrt(delx ** 2 + dely ** 2)
      if(dif .lt. epf) iperp = 1
      call prpvec(ix, iy, ix2, iy2, ispre, isite, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay)
      if(isgax.eq.0 .and. isgay.eq.0) stop 1830
c
c     eliminate first triangle
c
      lr = 2
      if(lr .gt. nfmax) stop 1840
      irun(1) = ispre
      irun(2) = isadj
      izun(1) = ivpre
      icon(4,ivini) = -1
      ian = 1
      if(ian .gt. nhmax) stop 1850
      ia(1) = ivini
c
c     analyze next triangle if any
c
  200 continue
      if(ivadj .lt. 0) then
          isucs = 0
          go to 2300
      endif
      if(ivadj .eq. 0) go to 700
      ivcur = ivadj
      if(icon(4,ivcur) .eq. isite) then
          ivpre = icon(1,ivcur)
          ivadj = icon(2,ivcur)
          isadj = icon(6,ivcur)
      elseif(icon(5,ivcur) .eq. isite) then
          ivpre = icon(2,ivcur)
          ivadj = icon(3,ivcur)
          isadj = icon(4,ivcur)
      elseif(icon(6,ivcur) .eq. isite) then
          ivpre = icon(3,ivcur)
          ivadj = icon(1,ivcur)
          isadj = icon(5,ivcur)
      else
          stop 1860
      endif
c
c     ascertain which side new vertex is on
c
      if(isadj .eq. ispre) go to 400
      if(iperp.eq.1) go to 210
      xtemp = x(isadj) - x(ispre)
      ytemp = y(isadj) - y(ispre)
      dlg = dsqrt(xtemp**2 + ytemp**2)
      if(dlg .lt. epf) go to 210
      dot = (delx * xtemp + dely * ytemp)/dif
      if(dot.ge.epf .or. dot.le.-epf) go to 220
  210 continue
      call distsn(ix, iy, ix2, iy2, ispre, isadj, mhalf, mfull, isclp,
     *            iax, isgax, ikax, iay, isgay, ikay, isga)
      if(isga.gt.0) then
         dot = 10.0d0
      elseif(isga.lt.0) then
         dot =-10.0d0
      else
         dot = 0.0d0
      endif
  220 continue
      if(dot .ge. epf) go to 400
c
c     add next vertex for 'right' side
c
      if(lf .ne. 0) stop 1865
      lr = lr + 1
      if(lr .gt. nfmax) stop 1870
      irun(lr) = isadj
      izun(lr-1) = ivpre
      icon(4,ivcur) = -1
      ian = ian + 1
      if(ian .gt. nhmax) stop 1880
      ia(ian) = ivcur
      go to 200
c
c     obtain 'left' side information
c
  400 continue
      if(ivout.eq.0) stop 1890
      lf = lf + 1
      if(lf .gt. nfmax) stop 1900
      ifun(lf) = isadj
      isun(lf) = ivpre
      icon(4,ivcur) = -1
      ian = ian + 1
      if(ian .gt. nhmax) stop 1910
      ia(ian) = ivcur
      if(isadj .eq. ispre) go to 500
      go to 200
  500 continue
      if(lf .lt. 2) stop 1920
      ivtro = isun(1)
      do 600 l = 2, lf
          isun(l-1) = isun(l)
  600 continue
c
c     test for eliminated adjacent triangles
c
      do 900 l = 1, lf -1
          isam = isun(l)
          if(isam .eq. 0 .or. isam .eq. nvmz) go to 900
          if(icon(4,iabs(isam)) .ne. -1) go to 900
          if(isam .gt. 0) then
              isun(l) = nvmp
          else
              isun(l) = nvmn
          endif
  900 continue
c
  700 continue
      do 800 l = 1, lr - 1
          isam = izun(l)
          if(isam .eq. 0 .or. isam .eq. nvmz) go to 800
          if(icon(4,iabs(isam)) .ne. -1) go to 800
          if(isam .gt. 0) then
              izun(l) = nvmp
          else
              izun(l) = nvmn
          endif
  800 continue
c
      mslop = 1
      mintr = 0
      iam = 0
      isnew = irun(lr)
      if(ivout .eq. 0) go to 1000
      if(lf.eq.0) stop 1930
      go to 1200
c
c     point to be eliminated is on convex hull
c
 1000 continue
      lr = lr + 1
      if(lr .gt. nfmax) stop 1940
      irun(lr) = isite
      izun(lr-1) = 0
c
c     triangulate 'right' side in a Delaunay way
c
      iopt = 4
c
      call edgstr(x, y, ix, iy, ix2, iy2, icon, irun, igun, iwun,
     *            ia, epf, mhalf, mfull, isclp, lr,
     *            ian, iam, mslop, mintr, jr, iopt)
c
      ial = iwun(1)
      is(isite) = ial
c
c     reconcile with rest of triangulation
c
      iflg = 1
      call mattri(is, icon, irun, izun, ial, lr, nvmz, nvmp, nvmn, iflg)
c
c     eliminate superfluous triangles
c
 1100 continue
      ivcur = icon(3,ial)
      ivabs = iabs(ivcur)
      iscor = icon(5,ial)
      if(icon(4,ivabs) .eq. iscor) then
          indx = 3
      elseif(icon(5,ivabs) .eq. iscor) then
          indx = 1
      elseif(icon(6,ivabs) .eq. iscor) then
          indx = 2
      else
          stop 1950
      endif
      icon(indx,ivabs) = 0
      if(ivcur .lt. 0) icon(indx,ivabs) = nvmz
      is(iscor) = ivabs
      icon(4,ial) = -1
      iabe = iabe + 1
      if(iabe .gt. njmax) stop 1960
      iave(iabe) = ial
      ial = icon(1,ial)
      if(ial .ne. 0) go to 1100
      go to 2200
c
c     point to be eliminated is not on convex hull
c
 1200 continue
c
c     triangulate 'right' side (not necessarily Delaunay)
c
      iopt = 0
c
      call edgstr(x, y, ix, iy, ix2, iy2, icon, irun, igun, iwun,
     *            ia, epf, mhalf, mfull, isclp, lr,
     *            ian, iam, mslop, mintr, jr, iopt)
c
c     update 'left' side information
c
      lg = lf
      do 1300 j = 2, jr
          lf = lf + 1
          if(lf .gt. nfmax) stop 1970
          ifun(lf) = igun(j)
          isun(lf-1) = iwun(j-1)
 1300 continue
c
c     triangulate 'left' side in a Delaunay fashion
c
      iopt = 2
c
      call edgstr(x, y, ix, iy, ix2, iy2, icon, ifun, igun, iwun,
     *            ia, epf, mhalf, mfull, isclp, lf,
     *            ian, iam, mslop, mintr, jf, iopt)
c
      if(jf .ne. 2) stop 1980
      ial = iwun(1)
c
c     merge the two sides
c
      lf = lg
      do 1400 j = 1, jr - 1
          iwun(j) = isun(lf+j-1)
 1400 continue
c
      j = jr
      ivcur = ial
 1500 continue
      ivadj = icon(1,ivcur)
      if(ivadj .eq. 0) go to 1600
      ivcur = ivadj
      go to 1500
 1600 continue
      j = j - 1
      ivadj = iwun(j)
      icon(1,ivcur) = ivadj
      if(ivadj .ne. 0) icon(2,ivadj) = ivcur
      ivcur = icon(3,ivcur)
      if(j .ne. 1) go to 1500
c
c     add each triangle to 'left' polygon and optimize
c
      j = jr - 1
 1700 continue
      if(j .eq. 0) go to 1900
      ivcur = iwun(j)
      if(ivcur .eq. 0) go to 1800
      iwun(j) = icon(3,ivcur)
      j = j + 1
      iwun(j) = icon(1,ivcur)
      indx = 2
      isnow = icon(5,ivcur)
      isadj = icon(6,ivcur)
      iscur = icon(4,ivcur)
c
      call addtri(x, y, ix, iy, ix2, iy2, icon, epf, mhalf, mfull,
     *            isclp, ivcur, indx, isnow, isadj, iscur)
c
      go to 1700
 1800 continue
      j = j - 1
      go to 1700
 1900 continue
c
c     reconcile everything with rest of triangulation
c
      if(icon(4,ial) .ne. ifun(1) .or. icon(6,ial) .ne. isnew) 
     *   stop 1990
      icon(2,ial) = ivtro
      if(ivtro .eq. 0 .or. ivtro .eq. nvmz) go to 2000
      iel = ial
      if(ivtro .lt. 0) then
          ivtro = -ivtro
          iel = -iel
      endif
      if(icon(4,ivtro) .eq. isnew) then
          icon(2,ivtro) = iel
      elseif(icon(5,ivtro) .eq. isnew) then
          icon(3,ivtro) = iel
      elseif(icon(6,ivtro) .eq. isnew) then
          icon(1,ivtro) = iel
      else
          stop 2000
      endif
c
 2000 continue
      is(isnew) = ial
      do 2100 l = 2, lr
          lf = lf + 1
          if(lf .gt. nfmax) stop 2010
          ifun(lf) = irun(l)
          isun(lf-1) = izun(l-1)
 2100 continue
c
      iflg = 1
      call mattri(is, icon, ifun, isun, ial, lf, nvmz, nvmp, nvmn, iflg)
c
c     record eliminated triangles
c
      if(iam .ge. ian) stop 2020
      iam = iam + 1
      do 2150 i = iam, ian
          iabe = iabe + 1
          if(iabe .gt. njmax) stop 2030
          iave(iabe) = ia(i)
 2150 continue
c
c     record eliminated point
c
 2200 continue
      is(isite) = 0
      iase = iase + 1
      if(iase .gt. nkmax) stop 2040
      iaze(iase) = isite
c
 2300 continue
      return
      end
*ADDTRI
c
c     subroutine addtri to -
c
c     add a triangle to a Delaunay triangulation of a polygon and get
c     a new Delaunay triangulation of the new polygon if the new
c     triangle has only one side in common with the polygon
c
c     March 6, 1991
c
      subroutine addtri(x, y, ix, iy, ix2, iy2, icon, epf, mhalf,
     *                  mfull, isclp, ivcur, indx, isite, isadj, iscur)
c
      integer mhalf, mfull, isclp(*)
      integer ivcur, indx, isite, isadj, iscur
      double precision epf
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer icon(6,*)
      integer isfin, ivadj, indy, ishat, itide
      double precision delx1, dely1, delx2, dely2, delx3, dely3
      double precision dif1, dif2, dif3, tdist
      double precision dat, dot, dot2, zlamb, vx, vy
      integer iv1, iv2
c
c     initialize
c
      isfin = isadj
c
  100 continue
      ivadj = icon(indx,ivcur)
      if(ivadj .eq. 0) go to 500
c
      if(icon(1,ivadj) .eq. ivcur) then
          indy = 4
      elseif(icon(2,ivadj) .eq. ivcur) then
          indy = 5
      elseif(icon(3,ivadj) .eq. ivcur) then
          indy = 6
      else
          stop 3000
      endif
      ishat = icon(indy,ivadj)
c
c     compute center of circumcircle for triangle isite-isadj-iscur
c
      delx1 = x(ishat) - x(isite)
      dely1 = y(ishat) - y(isite)
      dif1 = dsqrt(delx1**2 + dely1**2)
      if(dif1 .lt. epf) go to 300
c
      delx2 = y(isadj) - y(iscur)
      dely2 = x(iscur) - x(isadj)
      dif2 = dsqrt(delx2**2 + dely2**2)
      if(dif2 .lt. epf) go to 300
c
      delx3 = x(isite) - x(isadj)
      dely3 = y(isite) - y(isadj)
      dif3 = dsqrt(delx3**2 + dely3**2)
      if(dif3 .lt. epf) go to 300
c
      delx1 = x(isite) - x(iscur)
      dely1 = y(isite) - y(iscur)
      dif1 = dsqrt(delx1**2 + dely1**2)
      if(dif1 .lt. epf) go to 300
c
      dot = delx2*delx1 + dely2*dely1
      if(dot.lt.epf .and. dot.gt.-epf) go to 300
      dot2 = dot/dif2
      if(dot2.lt.epf .and. dot2.gt.-epf) go to 300
      dat = delx1*delx3 + dely1*dely3
      zlamb = dat/dot
      vx = .5*(x(isadj)+x(iscur) + zlamb*delx2)
      vy = .5*(y(isadj)+y(iscur) + zlamb*dely2)
      call biscrc (x, y, ishat, isite, epf, vx, vy, tdist)
      if(tdist.le.-epf) go to 500
      if(tdist.ge.epf) go to 400
  300 continue
      call circsn(ix, iy, ix2, iy2, isite, isadj, iscur, ishat,
     *            mhalf, mfull, isclp, itide)
      if(itide .ge. 0) go to 500
c
c     switch diagonals of quadrilateral
c
  400 continue
      iv1 = ivadj
      iv2 = ivcur
      if(indy .eq. 5) then
          iv1 = ivcur
          iv2 = ivadj
      endif
      if(indx .ne. 1 .and. indy .ne. 4) then
          icon(3,iv1) = icon(3,iv2)
          icon(3,iv2) = icon(1,iv2)
          icon(1,iv2) = icon(1,iv1)
          icon(1,iv1) = iv2
          icon(5,iv1) = icon(5,iv2)
          icon(4,iv2) = icon(5,iv2)
          icon(5,iv2) = icon(6,iv2)
          icon(6,iv2) = icon(6,iv1)
          if(icon(3,iv1) .ne. 0) icon(2,icon(3,iv1)) = iv1
          if(icon(1,iv2) .ne. 0) icon(2,icon(1,iv2)) = iv2
          ivcur = ivadj
      else
          icon(1,iv1) = icon(1,iv2)
          icon(1,iv2) = icon(3,iv2)
          icon(3,iv2) = icon(3,iv1)
          icon(3,iv1) = iv2
          icon(5,iv1) = icon(5,iv2)
          icon(6,iv2) = icon(5,iv2)
          icon(5,iv2) = icon(4,iv2)
          icon(4,iv2) = icon(4,iv1)
          if(icon(1,iv1) .ne. 0) icon(2,icon(1,iv1)) = iv1
          if(icon(3,iv2) .ne. 0) icon(2,icon(3,iv2)) = iv2
      endif
      if(indy .eq. 4) indx = 3
      isadj = ishat
      go to 100
c
c     move to next triangle with isite as a vertex
c
  500 continue
      if(isadj .eq. isfin) go to 600
      if(indx .eq. 1) then
          ivadj = icon(3,ivcur)
      elseif(indx .eq. 2) then
          ivadj = icon(1,ivcur)
      else
          ivadj = icon(2,ivcur)
      endif
      ivcur = ivadj
      iscur = isadj
      if(icon(4,ivcur) .eq. isite) then
          indx = 1
          isadj = icon(5,ivcur)
      elseif(icon(5,ivcur) .eq. isite) then
          indx = 2
          isadj = icon(6,ivcur)
      elseif(icon(6,ivcur) .eq. isite) then
          indx = 3
          isadj = icon(4,ivcur)
      else
          stop 3080
      endif
      go to 100
c
  600 continue
      return
      end
*COMPRS
c
c     subroutine comprs to -
c
c     compress array icon so that there are no gaps in it
c
c     March 15, 1991
c
      subroutine comprs(is, icon, id, n, ivnxt, nvmax, nvmz)
c
      integer n, ivnxt, nvmax, nvmz
      integer is(*), icon(6,*), id(*)
      integer ivnot, i, j, ivcur
c
c     test n, ivnxt, nvmz
c
      if(n .gt. nvmax .or. ivnxt .gt. nvmax) stop 3100
c
      if(nvmz .ne. -nvmax - 1) stop 3120
c
c     compress icon
c
      ivnot = 0
      do 200 i = 1, ivnxt
          if(icon(4,i) .eq. -1) go to 200
          ivnot = ivnot + 1
          id(i) = ivnot
          do 100 j = 1, 6
              icon(j,ivnot) = icon(j,i)
  100     continue
  200 continue
      ivnxt = ivnot
c
c     update icon for triangles
c
      do 400 i = 1, ivnxt
          do 300 j = 1, 3
              ivcur = icon(j,i)
              if(ivcur .eq. 0 .or. ivcur .eq. nvmz) go to 300
              if(ivcur .gt. 0) then
                  icon(j,i) = id(ivcur)
              else
                  ivcur = -ivcur
                  icon(j,i) = -id(ivcur)
              endif
  300     continue
  400 continue
c
c     update is for triangles
c
      do 500 i = 1, n
          if(is(i) .le. 0) go to 500
          is(i) = id(is(i))
  500 continue
c
      return
      end
*CONTST
c
c     subroutine contst to -
c
c     test consistency of triangulation
c
c     November 9, 1993
c
      subroutine contst(icon, is, id, nv, ivnxt, nvmz)
c
      integer nv, ivnxt, nvmz
      integer icon(6,*), is(*), id(*)
      integer site1, site2, i, iscur, ivini, itrct
      integer ivcur, ivcur2, ivabs2, ivlst, isit1, isit2, itemp
c
c     test initial triangle for each site
c
      do 50 i = 1, nv
          iscur = is(i)
          if(iscur .le. 0) go to 50
          if(icon(4,iscur) .ne. i .and. icon(5,iscur) .ne. i .and.
     *       icon(6,iscur) .ne. i) stop 3200
   50 continue
c
c     initialize
c
      do 60 i = 1, ivnxt
          id(i) = 1
   60 continue
c
      do 70 i = 1, nv
          if(is(i) .gt. 0) go to 80
   70 continue
      stop 3220
   80 continue
      ivini = is(i)
      itrct = 1
      id(ivini) = 0
      ivcur = ivini
  100 continue
      ivcur2 = icon(2,ivcur)
      if(ivcur2 .eq. 0 .or. ivcur2 .eq. nvmz) go to 200
      ivabs2 = iabs(ivcur2)
      ivlst = ivcur
      if(ivcur2 .lt. 0) ivlst = -ivcur
      site1 = icon(6,ivcur)
      site2 = icon(4,ivcur)
      if(id(ivabs2) .eq. 1) go to 500
      if(icon(2,ivabs2) .eq. ivlst) then
          isit1 = icon(4,ivabs2)
          isit2 = icon(6,ivabs2)
      elseif(icon(3,ivabs2) .eq. ivlst) then
          isit1 = icon(5,ivabs2)
          isit2 = icon(4,ivabs2)
      elseif(icon(1,ivabs2) .eq. ivlst .and. ivabs2 .eq. ivini) then
          isit1 = icon(6,ivabs2)
          isit2 = icon(5,ivabs2)
      else
          stop 3240
      endif
      if(site1 .ne. isit1 .or. site2 .ne. isit2) stop 3260
  200 continue
      ivcur2 = icon(3,ivcur)
      if(ivcur2 .eq. 0 .or. ivcur2 .eq. nvmz) go to 300
      ivabs2 = iabs(ivcur2)
      ivlst = ivcur
      if(ivcur2 .lt. 0) ivlst = -ivcur
      site1 = icon(4,ivcur)
      site2 = icon(5,ivcur)
      if(id(ivabs2) .eq. 1) go to 500
      if(icon(2,ivabs2) .eq. ivlst) then
          isit1 = icon(4,ivabs2)
          isit2 = icon(6,ivabs2)
      elseif(icon(3,ivabs2) .eq. ivlst) then
          isit1 = icon(5,ivabs2)
          isit2 = icon(4,ivabs2)
      elseif(icon(1,ivabs2) .eq. ivlst .and. ivabs2 .eq. ivini) then
          isit1 = icon(6,ivabs2)
          isit2 = icon(5,ivabs2)
      else
          stop 3280
      endif
      if(site1 .ne. isit1 .or. site2 .ne. isit2) stop 3300
  300 continue
      ivcur2 = icon(1,ivcur)
      if(ivcur .eq. ivini) go to 400
      if(ivcur2 .eq. 0 .or. ivcur2 .eq. nvmz) stop 3320
      ivabs2 = iabs(ivcur2)
      ivlst = ivcur
      if(ivcur2 .lt. 0) ivlst = -ivcur
      if(icon(3,ivabs2) .eq. ivlst) then
          ivcur = ivabs2
          go to 300
      elseif(icon(2,ivabs2) .eq. ivlst) then
          ivcur = ivabs2
          go to 200
      elseif(icon(1,ivabs2) .eq. ivlst .and. ivabs2 .eq. ivini) then
          go to 900
      else
          stop 3340
      endif
  400 continue
      if(ivcur2 .eq. 0 .or. ivcur2 .eq. nvmz) go to 900
      ivabs2 = iabs(ivcur2)
      ivlst = ivcur
      if(ivcur2 .lt. 0) ivlst = -ivcur
      site1 = icon(5,ivcur)
      site2 = icon(6,ivcur)
      if(id(ivabs2) .eq. 1) go to 500
      if(icon(2,ivabs2) .eq. ivlst) then
          isit1 = icon(4,ivabs2)
          isit2 = icon(6,ivabs2)
      elseif(icon(3,ivabs2) .eq. ivlst) then
          isit1 = icon(5,ivabs2)
          isit2 = icon(4,ivabs2)
      else
          stop 3360
      endif
      if(site1 .ne. isit1 .or. site2 .ne. isit2) stop 3380
      go to 900
c
c     shift icon for ivabs2
c
  500 continue
      if(icon(1,ivabs2) .eq. ivlst) go to 600
      if(icon(2,ivabs2) .eq. ivlst) then
          itemp = icon(1,ivabs2)
          icon(1,ivabs2) = icon(2,ivabs2)
          icon(2,ivabs2) = icon(3,ivabs2)
          icon(3,ivabs2) = itemp
          itemp = icon(4,ivabs2)
          icon(4,ivabs2) = icon(5,ivabs2)
          icon(5,ivabs2) = icon(6,ivabs2)
          icon(6,ivabs2) = itemp
      elseif(icon(3,ivabs2) .eq. ivlst) then
          itemp = icon(1,ivabs2)
          icon(1,ivabs2) = icon(3,ivabs2)
          icon(3,ivabs2) = icon(2,ivabs2)
          icon(2,ivabs2) = itemp
          itemp = icon(4,ivabs2)
          icon(4,ivabs2) = icon(6,ivabs2)
          icon(6,ivabs2) = icon(5,ivabs2)
          icon(5,ivabs2) = itemp
      else
          stop 3390
      endif
c
      if(site1 .ne. icon(6,ivabs2) .or.
     *   site2 .ne. icon(5,ivabs2)) stop 3400
c
  600 continue
      ivcur = ivabs2
      id(ivcur) = 0
      itrct = itrct + 1
      go to 100
c
  900 continue
      if(itrct .ne. ivnxt) stop 3420
c
      do 1000 i = 1, ivnxt
          if(id(i) .ne. 0) stop 3440
 1000 continue
c
      write(*,*)'****************************************'
      write(*,*)'consistency check satisfied'
      write(*,*)'****************************************'
      return
      end
*CIRCRI
c
c     this subroutine tests how well the circle criterion is satisfied
c     by the triangles
c
      subroutine circri(x, y, ix, iy, ix2, iy2, icon, mhalf, mfull,
     *                  isclp, ivnxt, epf)
c
      integer mhalf, mfull, isclp(*)
      integer ivnxt
      double precision epf
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer icon(6,*)
      double precision dif1, dif2, dif3, delx1, dely1, delx2, dely2
      double precision delx3, dely3, tdist
      double precision vx, vy, zlamb, dat, dot, dot2
      integer isite, isadj, iscur, i, ishat, k, ivadj, j, insti
      integer icerr, itide
c
c     initialize
c
      icerr = 0
c
c     test all triangles
c
      do 200 i = 1, ivnxt
         isite = icon(4,i)
         isadj = icon(5,i)
         iscur = icon(6,i)
c
c    compute center for current triangle
c
         insti = 0
         delx2 = y(isadj) - y(iscur)
         dely2 = x(iscur) - x(isadj)
         dif2 = dsqrt(delx2**2 + dely2**2)
         if(dif2 .lt. epf) go to 30
c
         delx3 = x(isite) - x(isadj)
         dely3 = y(isite) - y(isadj)
         dif3 = dsqrt(delx3**2 + dely3**2)
         if(dif3 .lt. epf) go to 30
c
         delx1 = x(isite) - x(iscur)
         dely1 = y(isite) - y(iscur)
         dif1 = dsqrt(delx1**2 + dely1**2)
         if(dif1 .lt. epf) go to 30
c
         dot = delx2*delx1 + dely2*dely1
         if(dot.lt.epf .and. dot.gt.-epf) go to 30
         dot2 = dot/dif2
         if(dot2.lt.epf .and. dot2.gt.-epf) go to 30
         dat = delx1*delx3 + dely1*dely3
         zlamb = dat/dot
         vx = .5*(x(isadj)+x(iscur) + zlamb*delx2)
         vy = .5*(y(isadj)+y(iscur) + zlamb*dely2)
         go to 40
   30    continue
         insti = 1
   40    continue
c
         do 100 j = 1, 3
            ivadj = icon(j,i)
            if(ivadj.le.0) go to 100
            do 50 k = 1, 3
                 if(icon(k,ivadj).eq.i) go to 75
   50       continue
            stop 3560
   75       continue
            ishat = icon(k+3,ivadj)
            if(insti.eq.1) go to 90
            delx1 = x(ishat) - x(isite)
            dely1 = y(ishat) - y(isite)
            dif1 = dsqrt(delx1**2 + dely1**2)
            if(dif1 .lt. epf) go to 90
            call biscrc(x,y,ishat,isite,epf,vx,vy,tdist)
            if(tdist.le.-epf) go to 100
            if(tdist.lt.epf) go to 90
            icerr = icerr+1
            go to 100
   90       continue
            call circsn(ix, iy, ix2, iy2, isite, isadj, iscur, ishat,
     *                  mhalf, mfull, isclp, itide)
            if(itide .ge. 0) go to 100
            icerr = icerr+1
  100    continue
  200 continue
c
      write(*,*) '************************************************'
      write(*,*) 'Number of circle criterion violations = ',icerr
      write(*,*) '(This number should equal 0)'
      write(*,*) '************************************************'
      write(*,*) ''
c
      return
      end
*ORIENT
c
c     This subroutine will test the orientation of the triangles
c
      subroutine orient(x, y, ix, iy, ix2, iy2, icon, nt,
     *                  mhalf, mfull, isclp, epf)
c
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer icon(6,*)
      double precision epf
      integer isclp(*), mhalf, mfull, nt
      integer a, b, c, i, isga, idmin
      double precision delx, dely, dif, xtemp, ytemp, dlst, dot
c
c     test all triangles
c
      idmin = 0
      do 300 i=1,nt
         a=icon(4,i)
         b=icon(5,i)
         c=icon(6,i)
         if(a.le.0 .or. b.le.0 .or. c.le.0) stop 3600
         delx = y(a) - y(b)
         dely = x(b) - x(a)
         dif = dsqrt(delx ** 2 + dely ** 2)
         if(dif .lt. epf) go to 220
         xtemp = x(c) - x(a)
         ytemp = y(c) - y(a)
         dlst=dsqrt(xtemp**2+ytemp**2)
         if(dlst .lt. epf) go to 220
         dot = (delx * xtemp + dely * ytemp)/dif
         if(dot.ge.epf .or. dot.le.-epf) go to 240
  220    continue
         call innsgn(ix, iy, ix2, iy2, a, b, c, mhalf, mfull, isclp,
     *               isga)
         if(isga.gt.0) then
            dot = 10.0d0
         elseif(isga.lt.0) then
            dot =-10.0d0
         else
            dot = 0.0d0
         endif
  240    continue
         if(dot .lt. epf) idmin = idmin+1
  300 continue
c
      write(*,*) '************************************************'
      write(*,*) 'Number of orientation violations = ',idmin
      write(*,*) '(This number should equal 0)'
      write(*,*) '************************************************'
      write(*,*) ''
c
      return
      end
*CONVEX
c
c  Subroutine to verify convexity of union of triangles
c
      subroutine convex(x, y, ix, iy, ix2, iy2, icon, is, nv, nt,
     *                  nvmz, mhalf, mfull, isclp, epf)
c
      double precision x(*), y(*)
      integer ix(*), iy(*), ix2(*), iy2(*)
      integer icon(6,*), is(*), nv, nt, nvmz
      double precision epf
      integer isclp(*), mhalf, mfull, isga
      integer idmin, i, ivcur, isite, iscur, isadj, isini, ivadj, itot
      double precision delx, dely, dif, xtemp, ytemp, dlst, dot
c
      idmin = 0
c
c     identify a triangle at boundary of convex hull
c
      do 300 i = 1, nt
         if(icon(1,i).eq.0 .or. icon(1,i).eq.nvmz .or.
     *      icon(2,i).eq.0 .or. icon(2,i).eq.nvmz .or.
     *      icon(3,i).eq.0 .or. icon(3,i).eq.nvmz) go to 400
  300 continue
      stop 3700
  400 continue
      ivcur = i
c
c     identify first two consecutive vertices at boundary of convex hull
c
      if(icon(1,ivcur).eq.0 .or. icon(1,ivcur).eq.nvmz) then
         isite = icon(6,ivcur)
         iscur = icon(5,ivcur)
      elseif(icon(2,ivcur).eq.0 .or. icon(2,ivcur).eq.nvmz) then
         isite = icon(4,ivcur)
         iscur = icon(6,ivcur)
      elseif(icon(3,ivcur).eq.0 .or. icon(3,ivcur).eq.nvmz) then
         isite = icon(5,ivcur)
         iscur = icon(4,ivcur)
      else
         stop 3720
      endif
      isini = isite
c
c     test current vertex isite at boundary of convex hull
c
      itot = 0
  500 continue
      itot = itot+1
      if(itot.gt.nv) stop 3730
      ivcur = is(isite)
      if(ivcur.le.0 .or. ivcur.gt.nt) stop 3740
      if(icon(4,ivcur).eq.isite) then
         ivadj = icon(3,ivcur)
         isadj = icon(5,ivcur)
      elseif(icon(5,ivcur).eq.isite) then
         ivadj = icon(1,ivcur)
         isadj = icon(6,ivcur)
      elseif(icon(6,ivcur).eq.isite) then
         ivadj = icon(2,ivcur)
         isadj = icon(4,ivcur)
      else
         stop 3760
      endif
      if(ivadj.ne.0 .and. ivadj.ne.nvmz) stop 3780
c
      delx = y(isite) - y(iscur)
      dely = x(iscur) - x(isite)
      dif = dsqrt(delx ** 2 + dely ** 2)
      if(dif .lt. epf) go to 520
      xtemp = x(isadj) - x(isite)
      ytemp = y(isadj) - y(isite)
      dlst=dsqrt(xtemp**2+ytemp**2)
      if(dlst .lt. epf) go to 520
      dot = (delx * xtemp + dely * ytemp)/dif
      if(dot.ge.epf .or. dot.le.-epf) go to 540
  520 continue
      call innsgn(ix, iy, ix2, iy2, isite, iscur, isadj, mhalf, mfull,
     *            isclp, isga)
      if(isga.gt.0) then
         dot = 10.0d0
      elseif(isga.lt.0) then
         dot =-10.0d0
      else
         dot = 0.0d0
      endif
  540 continue
      if(dot .ge. epf) idmin = idmin+1
      iscur = isite
      isite = isadj
      if(isite.ne.isini) go to 500
c
      write(*,*) '************************************************'
      write(*,*) 'Number of convexity violations = ',idmin
      write(*,*) '(This number should equal 0)'
      write(*,*) '************************************************'
      write(*,*) ''
c
      return
      end
*INNSGN
c
c     Routine for determining sign of distance from point ifou
c     to line that contains point ifir and isec. Distance is
c     positive if points ifir, isec, ifou are the vertices of
c     a triangle with nonempty interior and appear in this order
c     in a counterclockwise direction around the boundary of the
c     triangle.
c
      subroutine innsgn(x, y, x2, y2, ifir, isec, ifou,
     *                  mhalf, mfull, isclp, isga)
c
      integer x(*), y(*), x2(*), y2(*)
      integer ifir, isec, ifou
      integer isclp(*), mhalf, mfull, nkmax
      parameter (nkmax = 30)
      integer ia(nkmax), io(nkmax), iax(nkmax), iay(nkmax)
      integer iu(nkmax), iw(nkmax)
      integer ix4(nkmax), iy4(nkmax)
      integer ixf(nkmax), iyf(nkmax)
      integer ixfiw, iyfiw, ixsew, iysew
      integer ixfow, iyfow
      integer ixfi2, iyfi2, ixse2, iyse2
      integer ixfo2, iyfo2
      integer isgxf, isgyf, ikxf, ikyf
      integer isgx4, isgy4, ikx4, iky4
      integer isga, ika, isgo, iko
      integer isgax, ikax, isgay, ikay
      integer isgu, isgw, iku, ikw
c
      ixfiw = x(ifir)
      iyfiw = y(ifir)
      ixsew = x(isec)
      iysew = y(isec)
      ixfow = x(ifou)
      iyfow = y(ifou)
c
      ixfi2 = x2(ifir)
      iyfi2 = y2(ifir)
      ixse2 = x2(isec)
      iyse2 = y2(isec)
      ixfo2 = x2(ifou)
      iyfo2 = y2(ifou)
c
      call decmp2(ixf, isgxf, ikxf, ixfiw, ixfi2, mhalf, mfull, isclp)
      call decmp2(iyf, isgyf, ikyf, iyfiw, iyfi2, mhalf, mfull, isclp)
c
      call decmp2(io, isgo, iko, ixsew, ixse2, mhalf, mfull, isclp)
      call muldif(io, ixf, iay, isgo, isgxf, isgay, iko, ikxf, ikay,
     *              nkmax, mhalf)
      call decmp2(iu, isgu, iku, ixfow, ixfo2, mhalf, mfull, isclp)
      call muldif(iu, ixf, ix4, isgu, isgxf, isgx4, iku, ikxf, ikx4,
     *              nkmax, mhalf)
      call decmp2(io, isgo, iko, iysew, iyse2, mhalf, mfull, isclp)
      call muldif(io, iyf, iax, isgo, isgyf, isgax, iko, ikyf, ikax,
     *              nkmax, mhalf)
      isgax=-isgax
      call decmp2(iu, isgu, iku, iyfow, iyfo2, mhalf, mfull, isclp)
      call muldif(iu, iyf, iy4, isgu, isgyf, isgy4, iku, ikyf, iky4,
     *              nkmax, mhalf)
c
      call mulmul(iax, ix4, iw, isgax, isgx4, isgw, ikax, ikx4, ikw,
     *              nkmax, mhalf)
c
      call mulmul(iay, iy4, iu, isgay, isgy4, isgu, ikay, iky4, iku,
     *              nkmax, mhalf)
      isgu =-isgu
      call muldif(iw, iu, ia, isgw, isgu, isga, ikw, iku, ika,
     *              nkmax, mhalf)
c
      return
      end
*DISTSN
c
c     Routine for determining sign of distance from point ifou
c     to line that contains point ifir and that is perpendicular
c     to vector (iax,iay) with origin point ifir. The distance
c     is positive if point ifou is in halfplane that contains
c     vector (iax,iay).
c
      subroutine distsn(x, y, x2, y2, ifir, ifou, mhalf, mfull, isclp,
     *                  iax, isgax, ikax, iay, isgay, ikay, isga)
c
      integer x(*), y(*), x2(*), y2(*)
      integer ifir, ifou
      integer isclp(*), mhalf, mfull, nkmax
      parameter (nkmax = 30)
      integer iax(*), iay(*)
      integer ia(nkmax), iu(nkmax), iw(nkmax)
      integer ix4(nkmax), iy4(nkmax)
      integer ixf(nkmax), iyf(nkmax)
      integer ixfiw, iyfiw, ixfow, iyfow
      integer ixfi2, iyfi2, ixfo2, iyfo2
      integer isgxf, isgyf, ikxf, ikyf
      integer isgx4, isgy4, ikx4, iky4
      integer isga, ika
      integer isgax, ikax, isgay, ikay
      integer isgu, isgw, iku, ikw
c
      ixfiw = x(ifir)
      iyfiw = y(ifir)
      ixfow = x(ifou)
      iyfow = y(ifou)
c
      ixfi2 = x2(ifir)
      iyfi2 = y2(ifir)
      ixfo2 = x2(ifou)
      iyfo2 = y2(ifou)
c
      call decmp2(ixf, isgxf, ikxf, ixfiw, ixfi2, mhalf, mfull, isclp)
      call decmp2(iyf, isgyf, ikyf, iyfiw, iyfi2, mhalf, mfull, isclp)
c
      call decmp2(iu, isgu, iku, ixfow, ixfo2, mhalf, mfull, isclp)
      call muldif(iu, ixf, ix4, isgu, isgxf, isgx4, iku, ikxf, ikx4,
     *              nkmax, mhalf)
      call decmp2(iu, isgu, iku, iyfow, iyfo2, mhalf, mfull, isclp)
      call muldif(iu, iyf, iy4, isgu, isgyf, isgy4, iku, ikyf, iky4,
     *              nkmax, mhalf)
c
      call mulmul(iax, ix4, iw, isgax, isgx4, isgw, ikax, ikx4, ikw,
     *              nkmax, mhalf)
c
      call mulmul(iay, iy4, iu, isgay, isgy4, isgu, ikay, iky4, iku,
     *              nkmax, mhalf)
      isgu =-isgu
      call muldif(iw, iu, ia, isgw, isgu, isga, ikw, iku, ika,
     *              nkmax, mhalf)
c
      return
      end
*VECTRD
c
c     Routine for determining vector <ifir,isec>
c
      subroutine vectrd(x, y, x2, y2, ifir, isec, mhalf, mfull, isclp,
     *                  iax, isgax, ikax, iay, isgay, ikay)
c
      integer x(*), y(*), x2(*), y2(*)
      integer iax(*),iay(*)
      integer ifir, isec
      integer isclp(*), mhalf, mfull, nkmax
      parameter (nkmax = 30)
      integer io(nkmax)
      integer ixf(nkmax), iyf(nkmax)
      integer ixfiw, iyfiw, ixsew, iysew
      integer ixfi2, iyfi2, ixse2, iyse2
      integer isgxf, isgyf, ikxf, ikyf
      integer isgax, ikax, isgay, ikay
      integer isgo, iko
c
      ixfiw = x(ifir)
      iyfiw = y(ifir)
      ixsew = x(isec)
      iysew = y(isec)
c
      ixfi2 = x2(ifir)
      iyfi2 = y2(ifir)
      ixse2 = x2(isec)
      iyse2 = y2(isec)
c
      call decmp2(ixf, isgxf, ikxf, ixfiw, ixfi2, mhalf, mfull, isclp)
      call decmp2(iyf, isgyf, ikyf, iyfiw, iyfi2, mhalf, mfull, isclp)
c
      call decmp2(io, isgo, iko, ixsew, ixse2, mhalf, mfull, isclp)
      call muldif(io, ixf, iax, isgo, isgxf, isgax, iko, ikxf, ikax,
     *              nkmax, mhalf)
      call decmp2(io, isgo, iko, iysew, iyse2, mhalf, mfull, isclp)
      call muldif(io, iyf, iay, isgo, isgyf, isgay, iko, ikyf, ikay,
     *              nkmax, mhalf)
c
      return
      end
*PRPVEC
c
c     Routine for determining vector perpendicular to <ifir,isec>
c     that makes a right angle to <ifir,isec> in a counterclockwise
c     direction from it
c
      subroutine prpvec(x, y, x2, y2, ifir, isec, mhalf, mfull, isclp,
     *                  iax, isgax, ikax, iay, isgay, ikay)
c
      integer x(*), y(*), x2(*), y2(*)
      integer iax(*),iay(*)
      integer ifir, isec
      integer isclp(*), mhalf, mfull, nkmax
      parameter (nkmax = 30)
      integer io(nkmax)
      integer ixf(nkmax), iyf(nkmax)
      integer ixfiw, iyfiw, ixsew, iysew
      integer ixfi2, iyfi2, ixse2, iyse2
      integer isgxf, isgyf, ikxf, ikyf
      integer isgax, ikax, isgay, ikay
      integer isgo, iko
c
      ixfiw = x(ifir)
      iyfiw = y(ifir)
      ixsew = x(isec)
      iysew = y(isec)
c
      ixfi2 = x2(ifir)
      iyfi2 = y2(ifir)
      ixse2 = x2(isec)
      iyse2 = y2(isec)
c
      call decmp2(ixf, isgxf, ikxf, ixfiw, ixfi2, mhalf, mfull, isclp)
      call decmp2(iyf, isgyf, ikyf, iyfiw, iyfi2, mhalf, mfull, isclp)
c
      call decmp2(io, isgo, iko, ixsew, ixse2, mhalf, mfull, isclp)
      call muldif(io, ixf, iay, isgo, isgxf, isgay, iko, ikxf, ikay,
     *              nkmax, mhalf)
      call decmp2(io, isgo, iko, iysew, iyse2, mhalf, mfull, isclp)
      call muldif(io, iyf, iax, isgo, isgyf, isgax, iko, ikyf, ikax,
     *              nkmax, mhalf)
      isgax=-isgax
c
      return
      end
*CIRCSN
c
c     subroutine for determining position of point ifou with
c     respect to circle determined by points ifir, isec, ithi
c     if positive then ifou is outside the circle
c     if negative then ifou is inside the circle
c     if zero then ifou is on the boundary of the circle
c
      subroutine circsn(x, y, x2, y2, ifir, isec, ithi, ifou,
     *                  mhalf, mfull, isclp, ipout)
c
      integer x(*), y(*), x2(*), y2(*)
      integer ifir, isec, ithi, ifou, mhalf, mfull, nkmax, ipout
      integer isclp(*)
      parameter (nkmax = 30)
      integer iu(nkmax)
      integer iq2(nkmax), iq3(nkmax), iq4(nkmax)
      integer ix2(nkmax), iy2(nkmax)
      integer ix3(nkmax), iy3(nkmax)
      integer ix4(nkmax), iy4(nkmax)
      integer ixf(nkmax), iyf(nkmax)
      integer ixf2(nkmax), iyf2(nkmax)
      integer ixthw, iythw, ixfow, iyfow
      integer ixsew, iysew, ixfuw, iyfuw
      integer ixth2, iyth2, ixfo2, iyfo2
      integer ixse2, iyse2, ixfu2, iyfu2
      integer isgq2, isgq3, isgq4, ikq2, ikq3, ikq4
      integer isgxf, isgyf, ikxf, ikyf
      integer isgxf2, isgyf2, ikxf2, ikyf2
      integer isgx2, isgy2, ikx2, iky2
      integer isgx3, isgy3, ikx3, iky3 
      integer isgx4, isgy4, ikx4, iky4
      integer isgu, iku
c
      ixfuw = x(ifir)
      iyfuw = y(ifir)
      ixsew = x(isec)
      iysew = y(isec)
      ixthw = x(ithi)
      iythw = y(ithi)
      ixfow = x(ifou)
      iyfow = y(ifou)
c
      ixfu2 = x2(ifir)
      iyfu2 = y2(ifir)
      ixse2 = x2(isec)
      iyse2 = y2(isec)
      ixth2 = x2(ithi)
      iyth2 = y2(ithi)
      ixfo2 = x2(ifou)
      iyfo2 = y2(ifou)
c
      call decmp2(ixf, isgxf, ikxf, ixfuw, ixfu2, mhalf, mfull, isclp)
      call decmp2(iyf, isgyf, ikyf, iyfuw, iyfu2, mhalf, mfull, isclp)
      call mulmul(ixf, ixf, ixf2, isgxf, isgxf, isgxf2, ikxf, ikxf,
     *              ikxf2, nkmax, mhalf)
      call mulmul(iyf, iyf, iyf2, isgyf, isgyf, isgyf2, ikyf, ikyf,
     *              ikyf2, nkmax, mhalf)
      if(isgxf2.lt.0 .or. isgyf2.lt.0) stop 4600
c
      call frterm(ixsew, iysew, ixf, iyf, isgxf, isgyf, ikxf, ikyf,
     *            ixf2, iyf2, isgxf2, isgyf2, ikxf2, ikyf2, ix2, iy2,
     *            iq2, isgx2, isgy2, isgq2, ikx2, iky2, ikq2,
     *            mhalf, mfull, ixse2, iyse2, isclp)
c
      call frterm(ixthw, iythw, ixf, iyf, isgxf, isgyf, ikxf, ikyf,
     *            ixf2, iyf2, isgxf2, isgyf2, ikxf2, ikyf2, ix3, iy3,
     *            iq3, isgx3, isgy3, isgq3, ikx3, iky3, ikq3,
     *            mhalf, mfull, ixth2, iyth2, isclp)
c
      call frterm(ixfow, iyfow, ixf, iyf, isgxf, isgyf, ikxf, ikyf,
     *            ixf2, iyf2, isgxf2, isgyf2, ikxf2, ikyf2, ix4, iy4,
     *            iq4, isgx4, isgy4, isgq4, ikx4, iky4, ikq4,
     *            mhalf, mfull, ixfo2, iyfo2, isclp)
c
      call detrm3(iq2, ix2, iy2, isgq2, isgx2, isgy2,
     *            iq3, ix3, iy3, isgq3, isgx3, isgy3,
     *            iq4, ix4, iy4, isgq4, isgx4, isgy4,
     *            ikq2, ikq3, ikq4, ikx2, ikx3, ikx4,
     *            iky2, iky3, iky4, iu, isgu, iku, mhalf)
c
      ipout = isgu
c
      return
      end
*NUMDEN
c
c     subroutine for determining numerator and denominator used in
c     formulas for computing x-,y-coordinates of center of circle
c     determined by points ifir, isec, ithi
c
      subroutine numden(x, y, x2, y2, ifir, isec, ithi, mhalf, mfull,
     *                  isclp, io, isgo, iko, inx, iny, isgnx, isgny,
     *                  iknx, ikny)
c
      integer x(*), y(*), x2(*), y2(*)
      integer io(*), isgo, iko
      integer inx(*), iny(*), isgnx, isgny, iknx, ikny
      integer ifir, isec, ithi, mhalf, mfull, nkmax
      integer isclp(*)
      parameter (nkmax = 30)
      integer iq2(nkmax), iq3(nkmax)
      integer ix2(nkmax), iy2(nkmax)
      integer ix3(nkmax), iy3(nkmax)
      integer ixf(nkmax), iyf(nkmax)
      integer ixf2(nkmax), iyf2(nkmax)
      integer ixthw, iythw, ixsew, iysew, ixfuw, iyfuw
      integer ixth2, iyth2, ixse2, iyse2, ixfu2, iyfu2
      integer isgq2, isgq3, ikq2, ikq3
      integer isgxf, isgyf, ikxf, ikyf
      integer isgxf2, isgyf2, ikxf2, ikyf2
      integer isgx2, isgy2, ikx2, iky2
      integer isgx3, isgy3, ikx3, iky3 
c
      ixfuw = x(ifir)
      iyfuw = y(ifir)
      ixsew = x(isec)
      iysew = y(isec)
      ixthw = x(ithi)
      iythw = y(ithi)
c
      ixfu2 = x2(ifir)
      iyfu2 = y2(ifir)
      ixse2 = x2(isec)
      iyse2 = y2(isec)
      ixth2 = x2(ithi)
      iyth2 = y2(ithi)
c
      call decmp2(ixf, isgxf, ikxf, ixfuw, ixfu2, mhalf, mfull, isclp)
      call decmp2(iyf, isgyf, ikyf, iyfuw, iyfu2, mhalf, mfull, isclp)
      call mulmul(ixf, ixf, ixf2, isgxf, isgxf, isgxf2, ikxf, ikxf,
     *              ikxf2, nkmax, mhalf)
      call mulmul(iyf, iyf, iyf2, isgyf, isgyf, isgyf2, ikyf, ikyf,
     *              ikyf2, nkmax, mhalf)
      if(isgxf2.lt.0 .or. isgyf2.lt.0) stop 4610
c
      call frterm(ixsew, iysew, ixf, iyf, isgxf, isgyf, ikxf, ikyf,
     *            ixf2, iyf2, isgxf2, isgyf2, ikxf2, ikyf2, ix2, iy2,
     *            iq2, isgx2, isgy2, isgq2, ikx2, iky2, ikq2,
     *            mhalf, mfull, ixse2, iyse2, isclp)
c
      call frterm(ixthw, iythw, ixf, iyf, isgxf, isgyf, ikxf, ikyf,
     *            ixf2, iyf2, isgxf2, isgyf2, ikxf2, ikyf2, ix3, iy3,
     *            iq3, isgx3, isgy3, isgq3, ikx3, iky3, ikq3,
     *            mhalf, mfull, ixth2, iyth2, isclp)
c
      call dterm2(ix2, iy2, isgx2, isgy2, ix3, iy3, isgx3, isgy3,
     *            ikx2, ikx3, iky2, iky3, io, isgo, iko, mhalf)
c
      call dterm2(iq2, iy2, isgq2, isgy2, iq3, iy3, isgq3, isgy3,
     *            ikq2, ikq3, iky2, iky3, inx, isgnx, iknx, mhalf)
c
      call dterm2(ix2, iq2, isgx2, isgq2, ix3, iq3, isgx3, isgq3,
     *            ikx2, ikx3, ikq2, ikq3, iny, isgny, ikny, mhalf)
c
      return
      end
*FRTERM
c
      subroutine frterm(ixsew, iysew, ixf, iyf, isgxf, isgyf, ikxf,
     *                  ikyf, ixf2, iyf2, isgxf2, isgyf2, ikxf2, ikyf2,
     *                  ix2, iy2, iq2, isgx2, isgy2, isgq2, ikx2, iky2,
     *                  ikq2, mhalf, mfull, ixse2, iyse2, isclp)
c
      integer ixsew, iysew, isgxf, isgyf, isgxf2, isgyf2
      integer ikxf, ikyf, ikxf2, ikyf2
      integer isgx2, isgy2, isgq2
      integer ikx2, iky2, ikq2, mhalf, mfull
      integer ixse2, iyse2, isclp(*)
      integer isgo, isgu, isgv, isgp, iko, iku, ikv, ikp
      integer ixf(*), iyf(*), ixf2(*), iyf2(*)
      integer ix2(*), iy2(*), iq2(*)
      integer nkmax
      parameter (nkmax = 30)
      integer io(nkmax), iu(nkmax), iv(nkmax), ip(nkmax)
c
      call decmp2(io, isgo, iko, ixsew, ixse2, mhalf, mfull, isclp)
      call muldif(io, ixf, ix2, isgo, isgxf, isgx2, iko, ikxf, ikx2,
     *              nkmax, mhalf)
      call mulmul(io, io, iu, isgo, isgo, isgu, iko, iko, iku,
     *              nkmax, mhalf)
      call muldif(iu, ixf2, ip, isgu, isgxf2, isgp, iku, ikxf2, ikp,
     *              nkmax, mhalf)
c
      call decmp2(io, isgo, iko, iysew, iyse2, mhalf, mfull, isclp)
      call muldif(io, iyf, iy2, isgo, isgyf, isgy2, iko, ikyf, iky2,
     *              nkmax, mhalf)
      call mulmul(io, io, iu, isgo, isgo, isgu, iko, iko, iku,
     *              nkmax, mhalf)
      call muldif(iu, iyf2, iv, isgu, isgyf2, isgv, iku, ikyf2, ikv,
     *              nkmax, mhalf)
      isgv=-isgv
      call muldif(ip, iv, iq2, isgp, isgv, isgq2, ikp, ikv, ikq2,
     *              nkmax, mhalf)
c
      return
      end
*DETRM3
c
      subroutine detrm3(ix2, iy2, iz2, isgx2, isgy2, isgz2,
     *                  ix3, iy3, iz3, isgx3, isgy3, isgz3,
     *                  ix4, iy4, iz4, isgx4, isgy4, isgz4,
     *                  ikx2, ikx3, ikx4, iky2, iky3, iky4,
     *                  ikz2, ikz3, ikz4, io, isgo, iko, mhalf)
c
      integer nkmax
      parameter (nkmax = 30)
      integer io(*), iu(nkmax), iv(nkmax), iw(nkmax)
      integer ix2(*), iy2(*), iz2(*), ix3(*), iy3(*), iz3(*)
      integer ix4(*), iy4(*), iz4(*)
      integer isgx2, isgy2, isgz2, isgx3, isgy3, isgz3
      integer isgx4, isgy4, isgz4, ikx2, ikx3, ikx4, iky2, iky3, iky4
      integer ikz2, ikz3, ikz4, isgo, iko, mhalf
      integer isgu, isgv, isgw, iku, ikv, ikw
c
      call mulmul(ix3, iy4, iv, isgx3, isgy4, isgv, ikx3, iky4, ikv,
     *              nkmax, mhalf)
      call mulmul(ix4, iy3, iu, isgx4, isgy3, isgu, ikx4, iky3, iku,
     *              nkmax, mhalf)
      call muldif(iv, iu, iw, isgv, isgu, isgw, ikv, iku, ikw,
     *              nkmax, mhalf)
      call mulmul(iw, iz2, io, isgw, isgz2, isgo, ikw, ikz2, iko,
     *              nkmax, mhalf)
c
      call mulmul(ix2, iy4, iv, isgx2, isgy4, isgv, ikx2, iky4, ikv,
     *              nkmax, mhalf)
      call mulmul(ix4, iy2, iu, isgx4, isgy2, isgu, ikx4, iky2, iku,
     *              nkmax, mhalf)
      call muldif(iv, iu, iw, isgv, isgu, isgw, ikv, iku, ikw,
     *              nkmax, mhalf)
      call mulmul(iw, iz3, iu, isgw, isgz3, isgu, ikw, ikz3, iku,
     *              nkmax, mhalf)
      call muldif(io, iu, iw, isgo, isgu, isgw, iko, iku, ikw,
     *              nkmax, mhalf)
c
      call mulmul(ix3, iy2, iv, isgx3, isgy2, isgv, ikx3, iky2, ikv,
     *              nkmax, mhalf)
      call mulmul(ix2, iy3, iu, isgx2, isgy3, isgu, ikx2, iky3, iku,
     *              nkmax, mhalf)
      call muldif(iv, iu, io, isgv, isgu, isgo, ikv, iku, iko,
     *              nkmax, mhalf)
      call mulmul(io, iz4, iu, isgo, isgz4, isgu, iko, ikz4, iku,
     *              nkmax, mhalf)
      call muldif(iw, iu, io, isgw, isgu, isgo, ikw, iku, iko,
     *              nkmax, mhalf)
c
      return
      end
*DTERM2
c
      subroutine dterm2(ix2, iy2, isgx2, isgy2, ix3, iy3, isgx3, isgy3,
     *                  ikx2, ikx3, iky2, iky3, io, isgo, iko, mhalf)
c
      integer nkmax
      parameter (nkmax = 30)
      integer io(*), iu(nkmax), iv(nkmax)
      integer ix2(*), iy2(*), ix3(*), iy3(*)
      integer isgx2, isgy2, isgx3, isgy3, ikx2, ikx3, iky2, iky3
      integer isgo, iko, mhalf
      integer isgu, isgv, iku, ikv
c
      call mulmul(ix2, iy3, iu, isgx2, isgy3, isgu, ikx2, iky3, iku,
     *              nkmax, mhalf)
      call mulmul(ix3, iy2, iv, isgx3, isgy2, isgv, ikx3, iky2, ikv,
     *              nkmax, mhalf)
      call muldif(iu, iv, io, isgu, isgv, isgo, iku, ikv, iko,
     *              nkmax, mhalf)
c
      return
      end
*DECMP2
c
c     subroutine decmp2 
c
c     to decompose a regular or non-regular length integer
c
      subroutine decmp2(ia, isga, ika, iwi, iwi2, mhalf, mfull, isclp)
c
      integer ia(*), isga, ika, iwi, iwi2, mhalf, mfull, isclp(*)
      integer nkmax
      parameter (nkmax = 30)
      integer iu(nkmax), io(nkmax), isgu, isgo, iku, iko, isgcl, ikcl
c
      call decomp(ia, isga, iwi, mhalf)
      ika = 2
      if(iwi2.ne.0) then
         isgcl = 1
         ikcl = 2
         call mulmul(ia, isclp, iu, isga, isgcl, isgu, ika, ikcl,
     *                 iku, nkmax, mhalf)
         if(iwi2.eq.mfull) iwi2 = 0
         call decomp(io, isgo, iwi2, mhalf)
         isgo = -isgo
         iko = 2
         call muldif(iu, io, ia, isgu, isgo, isga, iku, iko, ika,
     *                 nkmax, mhalf)
      endif
c
      return
      end
*DECOMP
c
c     subroutine decomp
c
c     to decompose a regular length integer
c
c     iwi = isga*(ia(1) + ia(2) * mhalf)
c
c     iwi  is a regular length integer
c     isga is a sign integer (-1, 0, 1)
c     ia(1) and ia(2) are integers less than mhalf
c
      subroutine decomp(ia, isga, iwi, mhalf)
c
      integer ia(*), isga, iwi, mhalf, ivi
c
      if(iwi.gt.0) then
         isga = 1
         ivi = iwi
      elseif(iwi.lt.0) then
         isga =-1
         ivi = -iwi
      else
         isga = 0
         ia(1) = 0
         ia(2) = 0
         return
      endif
      ia(2) = ivi/mhalf
      ia(1) = ivi - ia(2)*mhalf
c
      return
      end
*MULMUL
c
c     subroutine mulmul
c
c     to perform a multiple precision integer multiplication
c     (for multiplying 2 or more integers)
c
c     io = ia * ib
c
c     ia represents a decomposed integer
c     ib represents a decomposed integer
c     io is the product of ia and ib in its decomposed form
c
      subroutine mulmul(ia, ib, io, isga, isgb, isgo, ika, ikb, iko,
     *                    nkmax, mhalf)
c
      integer ia(*), ib(*), io(*)
      integer isga, isgb, isgo, ika, ikb, iko, nkmax, mhalf
      integer i, ipt, ipr, iko1, k, j
c
      if(isga.eq.0.or.isgb.eq.0)then
         isgo=0
         iko = 2
         io(1) = 0
         io(2) = 0
         return
      endif
c
      iko = ika + ikb
      if(iko.gt.nkmax) stop 4710
c
      if(isga.gt.0)then
         if(isgb.gt.0)then
            isgo = 1
         else
            isgo =-1
         endif
      else
         if(isgb.gt.0)then
            isgo =-1
         else
            isgo = 1
         endif
      endif
c
      iko1 = iko - 1
      ipr = 0
c
      do 200 i = 1, iko1
         ipt = ipr
         k = i
         do 180 j = 1, ikb
            if(k .lt. 1) go to 190
            if(k .gt. ika) go to 150
            ipt = ipt + ia(k)*ib(j)
  150       continue
            k = k - 1
  180    continue
  190    continue
         ipr = ipt/mhalf
         io(i) = ipt - ipr*mhalf
  200 continue
c
      io(iko) = ipr
      if(ipr.ge.mhalf) stop 4720
c
      iko1 = iko
      do 300 i = iko1, ika+1, -1
         if(io(i) .ne. 0) go to 400
         iko = iko - 1
  300 continue
  400 continue
c
      return
      end
*MULDIF
c
c     subroutine muldif
c
c     to perform a multiple precision integer subtraction
c     (for subtracting a decomposed product from another)
c
c     io = ia - ib
c
c     ia represents a decomposed regular length integer or the 
c        decomposed product of two or more regular length integers
c     ib is similarly described
c     io is a decomposed integer which represents ia - ib
c
      subroutine muldif(ia, ib, io, isga, isgb, isgo, ika, ikb, iko,
     *                    nkmax, mhalf)
c
      integer ia(*), ib(*), io(*)
      integer isga, isgb, isgo, ika, ikb, iko, nkmax, mhalf
      integer i, iko1, irel
c
      if(isgb.eq.0)then
         if(isga.eq.0)then
            isgo=0
            iko = 2
            io(1) = 0
            io(2) = 0
            return
         endif
         isgo = isga
         iko = ika
         do 100 i=1,iko
            io(i) = ia(i)
  100    continue
      elseif(isga.eq.0)then
         isgo =-isgb
         iko = ikb
         do 200 i=1,iko
            io(i) = ib(i)
  200    continue
      else
         iko = ika
         if(ikb.lt.ika) then
            do 300 i=ikb+1,ika
               ib(i) = 0
  300       continue
         elseif(ika.lt.ikb) then
            iko = ikb
            do 400 i=ika+1,ikb
               ia(i) = 0
  400       continue
         endif
         if(isga*isgb.gt.0)then
            irel = 0
            do 500 i = iko, 1, -1
               if(ia(i).gt.ib(i))then
                  irel = 1
                  go to 600
               elseif(ia(i).lt.ib(i))then
                  irel = -1
                  go to 600
               endif
  500       continue
  600       continue
            if(irel.eq.0)then
               isgo = 0
               do 700 i=1,iko
                  io(i) = 0
  700          continue
            else
               isgo=isga*irel
               io(1) = (ia(1)-ib(1))*irel
               do 800 i=2,iko
                  if(io(i-1).lt.0) then
                     io(i) =-1
                     io(i-1) = io(i-1) + mhalf
                  else
                     io(i) = 0
                  endif
                  io(i) = io(i) + (ia(i)-ib(i))*irel
  800          continue
               if(io(iko).lt.0) stop 4810
            endif
         else
            isgo=isga
            io(1) = ia(1)+ib(1)
            do 900 i=2,iko
               if(io(i-1).ge.mhalf) then
                  io(i) = 1
                  io(i-1) = io(i-1) - mhalf
               else
                  io(i) = 0
               endif
               io(i) = io(i) + ia(i)+ib(i)
  900       continue
            if(io(iko).ge.mhalf) then
               iko = iko+1
               if(iko.gt.nkmax) stop 4820
               io(iko) = 1
               io(iko-1) = io(iko-1) - mhalf
            endif
         endif
      endif
c
      if(iko .eq. 2) go to 1400
      iko1 = iko
      do 1300 i = iko1, 3, -1
         if(io(i) .ne. 0) go to 1400
         iko = iko - 1
 1300 continue
 1400 continue
c
      return
      end
*DOUBNM
c
      subroutine doubnm(io, isgo, iko, r215, dnum)
c
      integer io(*)
      double precision dnum, r215, rpwr
      integer isgo, iko, i
c
      if(isgo.eq.0) then
         dnum = dble(0)
         go to 1000
      else
         if(iko .lt. 2) stop 5710
         if(iko .gt. 68) stop 5720
         rpwr = dble(1)
         dnum = dble(io(1))
         do 100 i = 2, iko
            rpwr = rpwr*r215
            dnum = dnum + dble(io(i))*rpwr
  100    continue
      endif
      if(isgo.lt.0) dnum = -dnum
c
 1000 continue
      return
      end
