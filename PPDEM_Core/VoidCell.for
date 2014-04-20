      subroutine VoidCell (nEle, nActEle, nCon,
     $      maxConAll, maxConPEle, maxEdgePEle,
     $      xEle, yEle, xCon, yCon, pairCon, flagConBoun, 
     $      nEffCon, xEffCon, effCon2Glob, iEleEffCon, 
     $      nTriAllCon, iConTriAllCon, iEConTriAllCon, fgDeadTri,
     $      nConPEle, iConPEle, iConCellinEle, nCellInEle, 
     $      nDlnBound,iConDlnBound, iEleDlnBound, 
     $      nGstDlnBound, iEffGstDlnBound, 
     $      nEdgeAll, fgEffEdge, iEleEffEdge, nEdgePt, jPtEdgeiPt,
     $      iEdgeiPt, iPtEdge, iCellEdge, iEdgeCell, fgSolidCell,
     $      iVCCell,nVC, mapVC, nCellVC, iCellVC, nEConVC, iEConVC,
     $      maxNGrid, maxDlnBPGrid, nDlnBPGrid, iDlnBPGrid,
     $      nSldTriPVC, iEConSldTri, xSldCell, fgSeenMe, fgBridgeEdge,
     $      fgBndEle, fgBndVC, xVC,
     $      flagMask, flagWeight, nNodeMask, Mask,
     $      flagVCMask, vecVV, rqVV, nBinVV, binVV, tsVV,
     $      xPtEff, iNd2, TIL, TNBR)
     
      implicit none
      
	 !DEC$ ATTRIBUTES DLLEXPORT :: VoidCell
	 !DEC$ ATTRIBUTES ALIAS:'VoidCell' :: VoidCell
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle, nActEle, nCon,
     $      maxConAll, maxConPEle, maxEdgePEle,
     $      xEle, yEle, xCon, yCon, pairCon, flagConBoun, 
     $      nEffCon, xEffCon, effCon2Glob, iEleEffCon, 
     $      nTriAllCon, iConTriAllCon, iEConTriAllCon, fgDeadTri,
     $      nConPEle, iConPEle, iConCellinEle, nCellInEle, 
     $      nDlnBound,iConDlnBound, iEleDlnBound, 
     $      nGstDlnBound, iEffGstDlnBound, 
     $      nEdgeAll, fgEffEdge, iEleEffEdge, nEdgePt, jPtEdgeiPt,
     $      iEdgeiPt, iPtEdge, iCellEdge, iEdgeCell, fgSolidCell,
     $      iVCCell,nVC, mapVC, nCellVC, iCellVC, nEConVC, iEConVC,
     $      maxNGrid, maxDlnBPGrid, nDlnBPGrid, iDlnBPGrid,
     $      nSldTriPVC, iEConSldTri, xSldCell, fgSeenMe, fgBridgeEdge,
     $      fgBndEle, fgBndVC, xVC,
     $      flagMask, flagWeight, nNodeMask, Mask,
     $      flagVCMask, vecVV, rqVV, nBinVV, binVV, tsVV,
     $      xPtEff, iNd2, TIL, TNBR
     
      ! Arrays that are not passed from the main app
      ! nConPEle(nEle), iConPEle(nEle,maxConPEle)
      ! iConDlnBound(maxConAll*2,2), iEleDlnBound(maxConAll)
      ! fgEffEdge, iEleEffEdge, nEdgePt, jPtEdgeiPt
      ! iEdgeit, iPtEdge, iCellEdge, iEdgeCell
      
      
      
      integer nEle, nActEle, nCon, pairCon(nEle*10,2), 
     $  flagConBoun(nEle*10), maxConAll, maxConPEle, maxEdgePEle
     
      double precision xEle(nEle), yEle(nEle), 
     $      xCon(nEle*10), yCon(nEle*10)
      
      integer nEffCon, effCon2Glob(maxConAll*2), 
     $      iEleEffCon(maxConAll*2,2)
      double precision xEffCon(maxConAll*2,2)
      
      integer nTriAllCon, n2Tri, iConTriAllCon(maxConAll*3,3),
     $      iEConTriAllCon(maxConAll*3,3), fgDeadTri(maxConAll*3)
     
      integer nConPEle(nEle),iConPEle(nEle,maxConPEle),  
     $      nCellinEle, iConCellInEle(nEle*maxConPEle,3) ! This arry is for plotting
      
      integer nDlnBound,iConDlnBound(maxConAll*2,2),
     $      iEleDlnBound(maxConAll*2), 
     $      nGstDlnBound(maxConAll*2), iEffGstDlnBound(maxConAll*2,12)
     
      integer nEdgePEle, iPtEdgePEle(maxEdgePEle,2),
     $      nCellPEdge(maxEdgePEle), nCellPEle, iPtCell(maxConPEle,3) ! Temp variables,all small 
      
      double precision xConEle(maxConPEle,2)
      
      integer nGhost, nNewTri, iGhost2Eff(maxConPEle)
      double precision xGhost(maxConPEle,2)
      
      double precision x1(2),x2(2),x3(2),x4(2),x0(2),ua(2)
      integer flagInter, flagExist
      
      
      integer nEdgeAll,fgEffEdge(maxConAll*3),iEleEffEdge(maxConAll*3), 
     $      nEdgePt(maxConAll*2),jPtEdgeiPt(maxConAll*2,maxEdgePEle),
     $      iEdgeiPt(maxConAll*2,maxEdgePEle),
     $      iPtEdge(maxConAll*3,2), iCellEdge(maxConAll*3,2),
     $      iEdgeCell(maxConAll*3,3)
     
      integer fgSolidCell(maxConAll*3)
      
      integer iVCCell(maxConAll*3), fgMoreIter, mapVC(maxConAll*3), 
     $      nVC, nCellVC(maxConAll), iCellVC(maxConAll,maxConPEle),
     $      nEConVC(maxConAll), iEConVC(maxConAll,maxConPEle) 
      
      double precision TriArea, tempArea, areaCutOff
      
      double precision x0Grid(2,2),lGrid
      integer nGrid(2),maxNGrid(2), maxDlnBPGrid, 
     $      nDlnBPGrid(maxNGrid(1),maxNGrid(2)),
     $      iDlnBPGrid(maxNGrid(1),maxNGrid(2),maxDlnBPGrid),
     $      myGrid(2,2)
     
      double precision xSldCell(nEle,2), xVC(maxConAll,2)
      
      integer nSldTriPVC(maxConAll), 
     $   iEConSldTri(maxConAll,maxEdgePEle,3)
      
      integer fgSeenMe(maxConAll*2),fgBridgeEdge(maxConAll*3)
     
      integer fgBndEle(nEle),fgBndVC(maxConAll)
      
      integer flagMask, flagWeight, nNodeMask, Mask(10)
      
      integer flagVCMask(maxConAll), nBinVV, nVV
      
      double precision vecVV(maxConAll*maxConPEle/2,2), 
     $   rqVV(maxConAll*maxConPEle/2,2), binVV(nBinVV), 
     $   intvBinVV, tempSum, tsVV(2,2), xPA(10), yPA(10)
      
      double precision OMP_GET_WTIME,timeNow(0:10)
      integer iTime
      
      integer ixT(maxConPEle), iyT(maxConPEle), ix2T(maxConPEle), 
     $      iy2T(maxConPEle), isT(maxConPEle), iConT(6,maxConPEle*3),
     $      iaveT(maxConPEle), iazeT(maxConPEle)
     
!      integer ixT2(maxConAll*2), iyT2(maxConAll*2), ix2T2(maxConAll*2), 
!     $      iy2T2(maxConAll*2), isT2(maxConAll*2),iConT2(6,maxConAll*6),
!     $      iaveT2(maxConAll*2), iazeT2(maxConAll*2)
      
      integer iEle, jEle, iPt, jPt, iCell, jCell, iCon, iEdge, jEdge, 
     $       iE, jE, kE, iGrid, jGrid, iVC, iECon, iNd, iVV
     
      double precision ASinCos
      
      double precision xPtEff(2,maxConAll*2)
      integer iNd2(maxConAll), TIL(3,maxConAll*2), TNBR(3,maxConAll*2), 
     $  iErr
      
      ! iTime=0 
      ! timeNow(iTime)=OMP_GET_WTIME() !0
      ! iTime=iTime+1
      
      areaCutOff=1.0e-9
      !!!!!!!!!!!!!!!
      !! Triangulate the domain based on all the contact points
      nEffCon=0
      effCon2Glob=0
      fgBndEle=0
      do iCon=1,nCon
        ! A contact is considered "effective" if it is an inter-particle or particle-wall contact.  
        ! In PPDEM, we also use contact to store data related to the pressure applied to particles at the boundary
        if ( (flagConBoun(iCon).eq.0).or.(flagConBoun(iCon).eq.2) ) then
            nEffCon=nEffCon+1
            xEffCon(nEffCon,1)=xCon(iCon)
            xEffCon(nEffCOn,2)=yCon(iCon)
            effCon2Glob(nEffCon)=iCon
            if (flagConBoun(iCon).eq.0) then
                iEleEffCon(nEffCon,:)=PairCon(iCon,:)
            else 
                iEleEffCon(nEffCon,1)=PairCon(iCon,1)
                iEleEffCon(nEffCon,2)=0
            end if
        end if
        if ( (flagConBoun(iCon).eq.1).or.(flagConBoun(iCon).eq.2) ) then
            ! We flag the element at the boundary of the domain.  We have to do this because triangulation does not work well at the boundary.
            fgBndEle(PairCon(iCon,1))=1  
        end if
      end do
      
      ! timeNow(iTime)=OMP_GET_WTIME() !1
      ! iTime=iTime+1
      
      do iCon=1,nEffCon
        iNd2(iCon)=iCon
        xPtEff(:,iCon)=xEffCon(iCon,:)
      end do
      call dtris2(nEffCon, xPtEff(:,1:nEffCon), iNd2(1:nEffCon), 
     $          nTriAllCon, TIL(:,1:nEffCon*2), TNBR(:,1:nEffCon*2), 
     $          iErr)
      
!      call Delaunay(maxConAll*2, nEffCon,  
!     $      xEffCon(:,1), xEffCon(:,2), nTriAllCon, 
!     $      ixT2, iyT2, ix2T2, iy2T2, isT2, iConT2, iaveT2, iazeT2)
     
      ! timeNow(iTime)=OMP_GET_WTIME() !2
      ! iTime=iTime+1
      
!      do iCell=1,nTriAllCon
!        iEConTriAllCon(iCell,1:3)=iConT2(4:6,iCell)
!        iConTriAllCon(iCell,1)=effCon2Glob(iConT2(4,iCell))
!        iConTriAllCon(iCell,2)=effCon2Glob(iConT2(5,iCell))
!        iConTriAllCon(iCell,3)=effCon2Glob(iConT2(6,iCell))
!      end do

      do iCell=1,nTriAllCon
        iEConTriAllCon(iCell,1:3)=TIL(1:3,iCell)
        iConTriAllCon(iCell,1)=effCon2Glob(TIL(1,iCell))
        iConTriAllCon(iCell,2)=effCon2Glob(TIL(2,iCell))
        iConTriAllCon(iCell,3)=effCon2Glob(TIL(3,iCell))
      end do

      ! timeNow(iTime)=OMP_GET_WTIME() !3
      ! iTime=iTime+1
      
      fgDeadTri=0
      do iCell=1,nTriAllCon
      
        tempArea=TriArea( xEffCon(iEConTriAllCon(iCell,1),1), 
     $                xEffCon(iEConTriAllCon(iCell,1),2), 
     $                xEffCon(iEConTriAllCon(iCell,2),1), 
     $                xEffCon(iEConTriAllCon(iCell,2),2), 
     $                xEffCon(iEConTriAllCon(iCell,3),1), 
     $                xEffCon(iEConTriAllCon(iCell,3),2) )

        if ( tempArea.lt.areaCutOff) then
            fgDeadTri(iCell)=1
         end if
      end do 

      ! timeNow(iTime)=OMP_GET_WTIME() !4
      ! iTime=iTime+1
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!
      call SortCon2Ele(nEle, nCon, maxConPEle, 
     $  PairCon, nConPEle, iConPEle, flagConBoun)
      
      ! timeNow(iTime)=OMP_GET_WTIME() !5
      ! iTime=iTime+1
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!! Generate the list of Delaunay boundaries
      
      nCellInEle=0
      nDlnBound=0
      iConDlnBound=0
      xSldCell=0.0
      
      do iEle=1,nActEle
        nEdgePEle=0
        iPtEdgePEle=0
        nCellPEdge=0
        nCellPEle=0
        
        if (nConPEle(iEle).ge.3) then
            do iPt=1, nConPEle(iEle)
                xConEle(iPt,1)=xCon(iConPEle(iEle,iPt))
                xConEle(iPt,2)=yCon(iConPEle(iEle,iPt))
            end do
            call Delaunay(maxConPEle, nConPEle(iEle), 
     $      xConEle(:,1), xConEle(:,2), nCellPEle, 
     $      ixT, iyT, ix2T, iy2T, isT, iConT, iaveT, iazeT)
            do iCell=1, nCellPEle
                iPtCell(iCell,1:3)=iConT(4:6,iCell)
                ! Still local indcies
            end do
            
            tempArea=0.0
            do iCell=1, nCellPEle
                x1=xConEle(iPtCell(iCell,1),:)
                x2=xConEle(iPtCell(iCell,2),:)
                x3=xConEle(iPtCell(iCell,3),:)

                xSldCell(iEle,:)=xSldCell(iEle,:)+
     $              (x1+x2+x3)/3.0*
     $              TriArea(x1(1),x1(2),x2(1),x2(2),x3(1),x3(2))
                tempArea=tempArea+
     $              TriArea(x1(1),x1(2),x2(1),x2(2),x3(1),x3(2))
            end do
            
            xSldCell(iEle,:)=xSldCell(iEle,:)/tempArea
            
            
            !!! These variables are for the convenience of plotting only
            do iCell=1,nCellPEle
                nCellInEle=nCellInEle+1
                iConCellInEle(nCellInEle,1)=
     $             iConPEle(iEle,iPtCell(iCell,1))
                iConCellInEle(nCellInEle,2)=
     $             iConPEle(iEle,iPtCell(iCell,2))
                iConCellInEle(nCellInEle,3)=
     $             iConPEle(iEle,iPtCell(iCell,3))
                ! Here we use global contact number
            end do
            
            !!! Build the list of unique edges
            do iCell=1,nCellPEle
                
                do jEdge=1,3
                    iPt= min(iPtCell(iCell,jEdge),
     $                       iPtCell(iCell,mod(jEdge,3)+1) )
                    jPt= max(iPtCell(iCell,jEdge),
     $                       iPtCell(iCell,mod(jEdge,3)+1) )
                    ! iPt and jPt are local indecies.  
                    call ChkEleEdge(maxEdgePEle, nEdgePEle,iPtEdgePEle, 
     $               iPt, jPt, flagExist)
     
                    if (flagExist.eq.0) then
                        nEdgePEle=nEdgePEle+1
                        iPtEdgePEle(nEdgePEle,1)=iPt
                        iPtEdgePEle(nEdgePEle,2)=jPt
                        nCellPEdge(nEdgePEle)=1
                    else
                        nCellPEdge(flagExist)=nCellPEdge(flagExist)+1
                    end if
                    
                end do
            end do
            
            do iEdge=1,nEdgePEle
                if (nCellPEdge(iEdge).eq.1) then
                    nDlnBound=nDlnBound+1
                    iConDlnBound(nDlnBound,1)=
     $                  iConPEle(iEle,iPtEdgePEle(iEdge,1))
                    iConDlnBound(nDlnBound,2)=
     $                  iConPEle(iEle,iPtEdgePEle(iEdge,2))
                    iEleDlnBound(nDlnBound)=iEle
                end if
            end do
      
        end if      
      end do
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!! Initialize the grid system
      
      x0Grid(1,1)=minval(xEffCon(1:nEffCon,1))
      x0Grid(1,2)=maxval(xEffCon(1:nEffCon,1))
      x0Grid(2,1)=minval(xEffCon(1:nEffCon,2))
      x0Grid(2,2)=maxval(xEffCon(1:nEffCon,2))
      lGrid=0
      do iEdge=1,nDlnBound
        x1(1)=xCon(iConDlnBound(iEdge,1))-xCon(iConDlnBound(iEdge,2))
        x1(2)=yCon(iConDlnBound(iEdge,1))-yCon(iConDlnBound(iEdge,2))
        lGrid=max(lGrid, x1(1)**2+x1(2)**2)
      end do
      lGrid=sqrt(lGrid)
      
      nGrid(1)=(x0Grid(1,2)-x0Grid(1,1))/lGrid+1
      nGrid(2)=(x0Grid(2,2)-x0Grid(2,1))/lGrid+1
      
      nDlnBPGrid=0
      do iEdge=1,nDlnBound
        call FindMyGrid( xCon(iConDlnBound(iEdge,1)),
     $                   yCon(iConDlnBound(iEdge,1)), 
     $                   xCon(iConDlnBound(iEdge,2)),
     $                   yCon(iConDlnBound(iEdge,2)),
     $                   maxNGrid,x0Grid,lGrid,myGrid)
     
        do iGrid=myGrid(1,1),myGrid(1,2)
            do jGrid=myGrid(2,1),myGrid(2,2)
                nDlnBPGrid(iGrid,jGrid)=nDlnBPGrid(iGrid,jGrid)+1
                iDlnBPGrid(iGrid,jGrid,nDlnBPGrid(iGrid,jGrid))=iEdge
            end do
        end do
      end do
      



      
      ! timeNow(iTime)=OMP_GET_WTIME() !6
      ! iTime=iTime+1
      
      ! Search through all the triangles constituted by contact points
      ! If the triangle intersect any Delauney boundary, we create ghost points at the intersections
      ! and then re-tessellate this triangular area.
      
      nGhost=0
      nNewTri=0
      n2Tri=nTriAllCon
      nGstDlnBound=0
      do iCell=1,n2Tri
      if ( fgDeadTri(iCell).eq.0 ) then
        nGhost=0
        do jEdge=1,3
            iPt= min( iConTriAllCon(iCell,jEdge),
     $                iConTriAllCon(iCell,mod(jEdge,3)+1) )         
            jPt= max( iConTriAllCon(iCell,jEdge),
     $                iConTriAllCon(iCell,mod(jEdge,3)+1) )        
            
            x1(1)=xCon(iPt)
            x1(2)=yCon(iPt)
            x2(1)=xCon(jPt)
            x2(2)=yCon(jPt)
            
            call FindMyGrid(x1(2),x1(2),x2(1),x2(2),
     $                   maxNGrid,x0Grid,lGrid,myGrid)
            fgSeenMe(1:nDlnBound)=0
     
            do iGrid=myGrid(1,1),myGrid(1,2) 
            do jGrid=myGrid(2,1),myGrid(2,2)
            
            do iE=1,nDlnBPGrid(iGrid,jGrid)
                iEdge=iDlnBPGrid(iGrid,jGrid,iE)
                if (fgSeenMe(iEdge).eq.0) then
                fgSeenMe(iEdge)=1
                x3(1)=xCon(iConDlnBound(iEdge,1))
                x3(2)=yCon(iConDlnBound(iEdge,1))
                x4(1)=xCon(iConDlnBound(iEdge,2))
                x4(2)=yCon(iConDlnBound(iEdge,2))
                call LineIntersect(x1,x2,x3,x4,x0,ua,flagInter)
                
                if (flagInter.eq.1) then
                    fgDeadTri(iCell)=1
                    nGhost=nGhost+1
                    xGhost(nGhost,:)=x0
                    
                    call ChkGhostExist(maxConAll, x0, 
     $              nGstDlnBound(iEdge),iEffGstDlnBound(iEdge,:), 
     $              xEffCon, flagExist)
     
                    if (flagExist.eq.0) then
                        nEffCon=nEffCon+1
                        xEffCon(nEffCon,:)=x0
                        iGhost2Eff(nGhost)=nEffCon
                        iEleEffCon(nEffCon,1)=iEleDlnBound(iEdge)
                        iEleEffCon(nEffCon,2)=iEleDlnBound(iEdge)
                        nGstDlnBound(iEdge)=nGstDlnBound(iEdge)+1
                        iEffGstDlnBound(iEdge,nGstDlnBound(iEdge))
     $                        =nEffCon
                    else 
                        iGhost2Eff(nGhost)=flagExist
                    end if
                end if
            end if ! not seen me yet
            end do
            end do
            end do
            

        end do
        if (fgDeadTri(iCell).eq.1) then
            nGhost=nGhost+1
            xGhost(nGhost,1)=xCon(iConTriAllCon(iCell,1))
            xGhost(nGhost,2)=yCon(iConTriAllCon(iCell,1))
            iGhost2Eff(nGhost)=iEConTriAllCon(iCell,1)
            nGhost=nGhost+1
            xGhost(nGhost,1)=xCon(iConTriAllCon(iCell,2))
            xGhost(nGhost,2)=yCon(iConTriAllCon(iCell,2))
            iGhost2Eff(nGhost)=iEConTriAllCon(iCell,2)
            nGhost=nGhost+1
            xGhost(nGhost,1)=xCon(iConTriAllCon(iCell,3))
            xGhost(nGhost,2)=yCon(iConTriAllCon(iCell,3))
            iGhost2Eff(nGhost)=iEConTriAllCon(iCell,3)
            
            call Delaunay(maxConPEle, nGhost, 
     $              xGhost(:,1), xGhost(:,2), nNewTri, 
     $              ixT, iyT, ix2T, iy2T, isT, iConT, iaveT, iazeT)
            do jCell=1, nNewTri
                tempArea=TriArea( xGhost(iConT(4,jCell),1), 
     $                        xGhost(iConT(4,jCell),2),  
     $                        xGhost(iConT(5,jCell),1),  
     $                        xGhost(iConT(5,jCell),2),  
     $                        xGhost(iConT(6,jCell),1),  
     $                        xGhost(iConT(6,jCell),2) )

                
                if ( tempArea.gt.areaCutOff) then
                    
                    nTriAllCon=nTriAllCon+1
                    iEConTriAllCon(nTriAllCon,1)=
     $                  iGhost2Eff(iConT(4,jCell))
                    iEConTriAllCon(nTriAllCon,2)=
     $                  iGhost2Eff(iConT(5,jCell))
                    iEConTriAllCon(nTriAllCon,3)=
     $                  iGhost2Eff(iConT(6,jCell))
                end if
            end do

        end if
      end if ! This cell is not dead
      end do  !iCell=1,n2Tri
      
      ! timeNow(iTime)=OMP_GET_WTIME() !7
      ! iTime=iTime+1
      
      !!!!!!!!!!!!!!!!!!
      !!! Build the edge list
      !!!!!!!!!!!!!!!!!!!!
      fgEffEdge=0
      nEdgePt=0
      nEdgeAll=0
      iEleEffEdge=0
      iCellEdge=0
      do iCell=1, nTriAllCon
        if (fgDeadTri(iCell).eq.0) then
        
            do iEdge=1,3
                iPt= min( iEConTriAllCon(iCell,iEdge),
     $                iEConTriAllCon(iCell,mod(iEdge,3)+1) )         
                jPt= max( iEConTriAllCon(iCell,iEdge),
     $                iEConTriAllCon(iCell,mod(iEdge,3)+1) )        
            
                call ChkExistEdge(maxEdgePEle,jPt,nEdgePt(iPt),
     $                 iEdgeiPt(iPt,:),jPtEdgeiPt(iPt,:), flagExist)
 
                if (flagExist.eq.0) then
                    nEdgeAll=nEdgeAll+1
                    iPtEdge(nEdgeAll,1)=iPt
                    iPtEdge(nEdgeAll,2)=jPt
                    nEdgePt(iPt)=nEdgePt(iPt)+1
                    jPtEdgeiPt(iPt,nEdgePt(iPt))=jPt
                    iEdgeiPt(iPt,nEdgePt(iPt))=nEdgeAll
                    
                    iCellEdge(nEdgeAll,1)=iCell
                    iEdgeCell(iCell,iEdge)=nEdgeAll
                    
                    !! Now we check whether this is an effective edge
                    
                    if ((iEleEffCon(iPt,1).eq.iEleEffCon(jPt,1)) .or. 
     $                  (iEleEffCon(iPt,1).eq.iEleEffCon(jPt,2)) )then

                        fgEffEdge(nEdgeAll)=1
                        iEleEffEdge(nEdgeAll)=iEleEffCon(iPt,1)
                    else if 
     $                 ( (iEleEffCon(iPt,2).ne.0).and.
     $                   ((iEleEffCon(iPt,2).eq.iEleEffCon(jPt,1)) .or. 
     $                    (iEleEffCon(iPt,2).eq.iEleEffCon(jPt,2)) ) 
     $                 )then

                        fgEffEdge(nEdgeAll)=1
                        iEleEffEdge(nEdgeAll)=iEleEffCon(iPt,2)
                    end if
                    
                else
                   iEdgeCell(iCell,iEdge)=flagExist
                   iCellEdge(flagExist,2)=iCell
                end if  ! edge does not already exist
                
            end do  ! loop three edges
        end if  ! this cell is not dead
      end do  ! iCell=1, nTriAllCon
      
      fgSolidCell=0
      do iCell=1,nTriAllCon
        if (fgDeadTri(iCell).eq.0) then
            if ( (iEleEffEdge(iEdgeCell(iCell,1)).ne.0) .and. 
     $           ( iEleEffEdge(iEdgeCell(iCell,1)).eq.
     $             iEleEffEdge(iEdgeCell(iCell,2)) ) .and.
     &           ( iEleEffEdge(iEdgeCell(iCell,1)).eq.
     $             iEleEffEdge(iEdgeCell(iCell,3)) ) 
     $         ) then
                fgSolidCell(iCell)=1
            end if
        end if
      end do
      
      ! timeNow(iTime)=OMP_GET_WTIME() !8
      ! iTime=iTime+1
      
      !!!!!!!!!!!!!!!!!!
      !! Consolidate void cell index
      !!!!!!!!!!!!!!!!!!
      do iCell=1, nTriAllCon
        iVCCell(iCell)=iCell
      end do
      
      fgMoreIter=1
      do while (fgMoreIter.gt.0)
        fgMoreIter=0
        do iEdge=1,nEdgeAll
            if ( (fgEffEdge(iEdge).eq.0).and.
     $           (iCellEdge(iEdge,2).ne.0) ) then
                if (iVCCell(iCellEdge(iEdge,2)).ne.
     $              iVCCell(iCellEdge(iEdge,1))) then
                    fgMoreIter=fgMoreIter+1
                    iVCCell(iCellEdge(iEdge,1))=
     $                  min( iVCCell(iCellEdge(iEdge,1)),
     $                       iVCCell(iCellEdge(iEdge,2)) )
                    iVCCell(iCellEdge(iEdge,2))=
     $                  iVCCell(iCellEdge(iEdge,1))
                end if
            end if
        end do
!      write (838,*) fgMoreIter
!      flush (838)
      end do
      
      mapVC=0
      nCellVC=0
      nVC=0
      do iCell=1,nTriAllCon
        if ((fgSolidCell(iCell).eq.0).and.(fgDeadTri(iCell).eq.0)) then
            if (mapVC(iVCCell(iCell)).eq.0) then
                nVC=nVC+1
                mapVC(iVCCell(iCell))=nVC
                iVCCell(iCell)=nVC
            else
                iVCCell(iCell)=mapVC(iVCCell(iCell))
            end if
            nCellVC(iVCCell(iCell))=min( nCellVC(iVCCell(iCell))+1,
     $                                   maxConPEle) 
            iCellVC(iVCCell(iCell),nCellVC(iVCCell(iCell)))=iCell
        end if
      end do
      
      ! timeNow(iTime)=OMP_GET_WTIME() !9
      ! iTime=iTime+1
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!! Build Void Cells
      
      nSldTriPVC=0
      
      
      !iEconSldTriEdge(nEle,maxEdgePEle)

      
      do iCell=1, nTriAllCon
        if ((fgDeadTri(iCell).eq.0).and.(fgSolidCell(iCell).eq.0)) then
            do iE=1,3
                iEdge=iEdgeCell(iCell,iE)
                if (fgEffEdge(iEdge).eq.1) then
                    iEle=iEleEffEdge(iEdge)

                    if (nConPEle(iEle).ge.3) then
                    
                        iVC=iVCCell(iCell)
                        nSldTriPVC(iVC)=
     4                      min(maxEdgePEle,nSldTriPVC(iVC)+1)
                        
                        iEConSldTri(iVC,nSldTriPVC(iVC),1)=iEle
                        iEConSldTri(iVC,nSldTriPVC(iVC),2)=
     $                                              iPtEdge(iEdge,1)
                        iEConSldTri(iVC,nSldTriPVC(iVC),3)=
     $                                              iPtEdge(iEdge,2)
     
                        ! If a solid triangle edge appears twice, we don't plot it
                        
!                        call ChkExistSldTriEdge(maxEdgePEle, 
!     $                       nSldTriEdgePEle(iEle),iSldTriEdge(iEle,:),
!     $                       flagExist)
!                    x1=xSldCell(iEle,:)
!                    x2=xEffCon(iPtEdge(iEdge,1),:)
!                    x3=xEffCon(iPtEdge(iEdge,2),:)
                    end if
                end if
            end do
        end if
      
      end do
      
      !!! Check whether each edge is a bridge edge
      !!! The particles who own bridge edges should have two contact
      fgBridgeEdge=0
      do iEdge=1,nEdgeAll
        if (fgEffEdge(iEdge).eq.1) then
            if (nConPEle(iEleEffEdge(iEdge)).eq.2) then
            
                fgBridgeEdge(iEdge)=1
            
            end if
        end if
      end do
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!! Find out whether each VC is at the boundary or not
      fgBndVC=0
      
      do iVC=1,nVC
        iCell=0
        do while ((fgBndVC(iVC).eq.0).and.(iCell.lt.nCellVC(iVC)))
            iCell=iCell+1
            do iPt=1,3
                iECon=iEConTriAllCon(iCellVC(iVC,iCell),iPt)
                iEle=iEleEffCon(iECon,1)
                jEle=iEleEffCon(iECon,2)
                if (jEle.eq.0) then
                    fgBndVC(iVC)=1
                else if ((fgBndEle(iEle).eq.1).or.
     $                   (fgBndEle(jEle).eq.1) ) then
                    fgBndVC(iVC)=1
                end if             
            end do
        end do
      end do
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!!!  Get the void vectors
      
      xVC=0.0
      
      nEConVC=0
      do iVC=1,nVC
        do iE=1,nCellVC(iVC)
            iCell=iCellVC(iVC,iE)
            do jE=1,3
                iEdge=iEdgeCell(iCell,jE)
                do kE=1,2
                    iPt=iPtEdge(iEdge,kE)
                    call ChkPtExist(maxConPEle, iPt, 
     $                 nEConVC(iVC), iEConVC(iVC,:), flagExist)
      
                    if ((flagExist.eq.0) .and. 
     $                   (nEConVC(iVC).lt.maxConPEle))then
      
                        nEConVC(iVC)=min(nEConVC(iVC)+1,maxConPEle)
                        iEConVC(iVC,nEConVC(iVC))=iPt
                        xVC(iVC,:)= xVC(iVC,:)+
     $                             xEffCon(iPt,:)
                    end if
                end do
            end do
        end do
        
        xVC(iVC,:)=xVC(iVC,:)/nEConVC(iVC)
        
      end do
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!
      !!! Geometrical characteristics of VCs
!      xVC=0.0
!      do iVC=1,nVC
!        tempArea=0
!        do iE=1,nCellVC(iVC)
!            iCell=iCellVC(iVC,iE)
!            x1=xEffCon(iEConTriAllCon(iCell,1),:)
!            x2=xEffCon(iEConTriAllCon(iCell,2),:)
!            x3=xEffCon(iEConTriAllCon(iCell,3),:)
!            tempArea=tempArea+
!     $          TriArea(x1(1),x1(2),x2(1),x2(2),x3(1),x3(2))
!            xVC(iVC,:)=xVC(iVC,:)+(x1+x2+x3)/3.0*
!     $          TriArea(x1(1),x1(2),x2(1),x2(2),x3(1),x3(2))       
!        end do
!        
!!        do iCell=1,nSldTriPVC(iVC)
!!            x1=xSldCell(iEConSldTri(iVC,iCell,1),:)
!!            x2=xEffCon(iEConSldTri(iVC,iCell,2),:)
!!            x3=xEffCon(iEConSldTri(iVC,iCell,3),:)
!!            tempArea=tempArea+
!!     $          TriArea(x1(1),x1(2),x2(1),x2(2),x3(1),x3(2))
!!            xVC(iVC,:)=xVC(iVC,:)+(x1+x2+x3)/3.0*
!!     $          TriArea(x1(1),x1(2),x2(1),x2(2),x3(1),x3(2))       
!!        end do
!        
!        if (nCellVC(iVC).gt.0) then
!            xVC(iVC,:)=xVC(iVC,:)/tempArea
!        end if
!      
!      end do
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
      !!! Now, we start performing statistical analysiis
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
      if (flagMask.eq.0) then
        
        flagVCMask(1:nVC)=1
      
      else
        
        do iNd=1,nNodeMask
            xPA(iNd)=xEle(Mask(iNd))
            yPA(iNd)=yEle(Mask(iNd))
        end do
        
        xPA(nNodeMask+1)=xEle(Mask(1))
        yPA(nNodeMask+1)=yEle(Mask(1))  
        
        flagVCMask(1:nVC)=0
        do iVC=1,nVC
            if (fgBndVC(iVC).eq.0) then
                call PtPoly(xVC(iVC,1),xVC(iVC,2),nNodeMask,
     $           xPA,yPA,flagVCMask(iVC))
            
            end if
        end do
      end if  
      
      nVV=0
      do iVC=1,nVC
        if ((fgBndVC(iVC).eq.0).and.(flagVCMask(iVC).eq.1)) then
            do iPt=1,nEConVC(iVC)
                nVV=nVV+1
                vecVV(nVV,:)=xEffCon(iEConVC(iVC,iPt),:)-xVC(iVC,:)
                rqVV(nVV,1)=sqrt(vecVV(nVV,1)**2+vecVV(nVV,2)**2)
                rqVV(nVV,2)=ASinCos(vecVV(nVV,1)/rqVV(nVV,1), 
     $                              vecVV(nVV,2))
                
            end do
        end if
      end do
      
      intvBinVV=6.284/nBinVV
      tempSum=0.0
      tsVV=0.0
      do iVV=1,nVV
        if (flagWeight.eq.0) then
            
            BinVV(int(rqVV(iVV,2)/intvBinVV)+1)=
     $          BinVV(int(rqVV(iVV,2)/intvBinVV)+1)+1   
            tempSum=tempSum+1 
            
            tsVV(1,1)=tsVV(1,1)+cos(rqVV(iVV,2))**2       
            tsVV(1,2)=tsVV(1,2)+cos(rqVV(iVV,2))*sin(rqVV(iVV,2))       
            tsVV(2,1)=tsVV(2,1)+cos(rqVV(iVV,2))*sin(rqVV(iVV,2))       
            tsVV(2,2)=tsVV(2,2)+sin(rqVV(iVV,2))**2  
                 
        else
            
            BinVV(int(rqVV(iVV,2)/intvBinVV)+1)=
     $          BinVV(int(rqVV(iVV,2)/intvBinVV)+1)
     $         +rqVV(iVV,1)   
            tempSum=tempSum+rqVV(iVV,1)  
            tsVV(1,1)=tsVV(1,1)+cos(rqVV(iVV,2))**2*rqVV(iVV,1)       
            tsVV(1,2)=tsVV(1,2)
     $           +cos(rqVV(iVV,2))*sin(rqVV(iVV,2))*rqVV(iVV,1)       
            tsVV(2,1)=tsVV(2,1)
     $           +cos(rqVV(iVV,2))*sin(rqVV(iVV,2))*rqVV(iVV,1)       
            tsVV(2,2)=tsVV(2,2)+sin(rqVV(iVV,2))**2*rqVV(iVV,1)  
      
            
        end if
      end do
      
      binVV=binVV/6.2832*nBinVV/tempSum
      tsVV=tsVV/tempSum
      
      
!      write (1094,'(4F8.3, 2I10)') tsVV(1,1), tsVV(1,2), tsVV(2,1),
!     $  tsVV(2,2), nCon, nEffCon
!          

      end subroutine
