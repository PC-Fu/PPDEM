      subroutine Delaunay(nMax, nPt, x, y, numCell, 
     $      ix, iy, ix2, iy2, is, icon, iave, iaze )
       
       ! Find the element closest to the given point. 
       ! Strain cells (triangles) will be constructed around this element in IniStrainCell.
       
       implicit none
c
      integer nMax, nPt, numCell, nvMax

      double precision x(nMax), y(nMax)
      integer ix(nMax), iy(nMax), ix2(nMax), iy2(nMax)
      integer is(nMax), icon(6,nMax*3)
      integer iave(nMax), iaze(nMax)
      integer ivnxt, nvmz,np, iPt
      integer icsfig, mhalf, mfull, isclp(2)
      double precision epf
      double precision r215, deps, dscle, dfull, dfill
c
      logical vnflg, vsflg, voflg, lsflg, dlflg,
     *        toflg, ccflg, npflg, trflg
c
      integer i, nvmn, nvmp, iase, ileft, iabe, idupl, inpro
      double precision xmax, xmin, ymax, ymin

      nvMax=nMax*3

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


      nvmz = -nMax*3 - 1
      nvmn = nvmz - 1
      nvmp = -nvmn
c
      epf = 0.01d0

c
c*****************************************************************
c
c     read points file
c
      
      xmax=x(1)
      xmin=x(1)
      ymax=y(1)
      ymin=y(1)

      do iPt=1,nPt
        xMax=max(xMax,x(iPt))
        xMin=min(xMin,x(iPt))
        yMax=max(yMax,y(iPt))
        yMin=min(yMin,y(iPt))
      end do



      iase=1
      iaze(1)=nPt+1


      np = 0
c
c*****************************************************************
c
c     transform coordinates into integer decomposition
c

      call transf(x, y, ix, iy, ix2, iy2, xmin, ymin, xmax, ymax,
     *            nPt, icsfig, mhalf, mfull, isclp, r215, deps,
     *            dscle, dfull, dfill, epf)

c
      call tricmp(x, y, ix, iy, ix2, iy2, is, icon, iave, iaze,
     *            epf, mhalf, mfull, isclp, nvmz, nPt, iabe, iase,
     *            nmax, nvmax, ivnxt, idupl, inpro, r215, deps, ileft)
c
c
c**********************************************************************
c
c     save information about final Delaunay triangulation
c

      numCell=ivnxt
      

      end subroutine