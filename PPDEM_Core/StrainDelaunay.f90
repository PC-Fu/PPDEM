subroutine StrainDelaunay(nEle, nActEle, xEle, yEle, nCon, pairCon, flagConBoun, &
                          numCell, eleStnCell, flagEffCell, &
                          nEffEle, xEffEle, iNdStn, TILStn, TNBRStn, mapEffEle, nConPEleStn)

implicit none
    !DEC$ ATTRIBUTES DLLEXPORT :: StrainDelaunay
    !DEC$ ATTRIBUTES ALIAS:'StrainDelaunay' :: StrainDelaunay
    !DEC$ ATTRIBUTES Reference :: nEle, nActEle, xEle, yEle, nCon, pairCon, flagConBoun
    !DEC$ ATTRIBUTES Reference :: numCell, eleStnCell, flagEffCell
    !DEC$ ATTRIBUTES Reference :: nEffEle, xEffEle, iNdStn, TILStn, TNBRStn, mapEffEle, nConPEleStn
                          
integer nEle, nActEle, nCon, PairCon(nEle*10,2), flagConBoun(nEle*10)

double precision xEle(nEle), yEle(nEle), xEffEle(2,nEle), lEdge(3), area, PtDist, TriArea

integer numCell, eleStnCell(numCell,3), flagEffCell(numCell), nEffEle, iNdStn(nEle), &
    TILStn(3, nEle*2), TNBRStn(3, nEle*2), mapEffEle(nEle), nConPEleStn(nEle)
    
integer iCon, iEle, iErr, iCell, i, numCellReal
   

!!!! Come out with effective element list
nConPEleStn=0
do iCon=1,nCon
    if (flagConBoun(iCon).eq.0) then 
        do i=1,2
            iEle=PairCon(iCon,i)
            nConPEleStn(iEle)=nConPEleStn(iEle)+1
        end do
    else if (flagConBoun(iCon).eq.2) then   ! contact between element and wall
        iEle=PairCon(iCon,1)
        nConPEleStn(iEle)=nConPEleStn(iEle)+1
    end if
end do

nEffEle=0

do iEle=1,nActEle
    if (nConPEleStn(iEle).ge.5) then
        nEffEle=nEffEle+1
        mapEffEle(nEffEle)=iEle
        xEffEle(1,nEffEle)=xEle(iEle)
        xEffEle(2,nEffEle)=yEle(iEle)
        iNdStn(nEffEle)=nEffEle
    end if    
end do

call dtris2(nEffEle, xEffEle(:,1:nEffEle), iNdStn(1:nEffEle),  &
          numCellReal, TILStn(:,1:nEffEle*2), TNBRStn(:,1:nEffEle*2), &
          iErr)
          
do iCell=1,numCellReal          
    eleStnCell(iCell,1)=mapEffEle(TILStn(1,iCell))
    eleStnCell(iCell,2)=mapEffEle(TILStn(2,iCell))
    eleStnCell(iCell,3)=mapEffEle(TILStn(3,iCell))
end do

flagEffCell=0
flagEffCell(1:numCellReal)=1

do iCell=1,numCellReal
    lEdge(1)=Dsqrt( PtDist( xEle(eleStnCell(iCell,1)),  yEle(eleStnCell(iCell,1)), &
                            xEle(eleStnCell(iCell,2)),  yEle(eleStnCell(iCell,2))   ))
    lEdge(2)=Dsqrt( PtDist( xEle(eleStnCell(iCell,1)),  yEle(eleStnCell(iCell,1)), &
                            xEle(eleStnCell(iCell,3)),  yEle(eleStnCell(iCell,3))   ))
    lEdge(3)=Dsqrt( PtDist( xEle(eleStnCell(iCell,2)),  yEle(eleStnCell(iCell,2)), &
                            xEle(eleStnCell(iCell,3)),  yEle(eleStnCell(iCell,3))   ))

    area=TriArea(  xEle(eleStnCell(iCell,1)),  yEle(eleStnCell(iCell,1)),  &
                   xEle(eleStnCell(iCell,2)),  yEle(eleStnCell(iCell,2)),  &
                   xEle(eleStnCell(iCell,3)),  yEle(eleStnCell(iCell,3))  )

    if ( ((lEdge(1)+lEdge(2)+lEdge(3))/3)**2*0.433.gt.area*5.0) then
        flagEffCell(iCell)=0
    end if

end do

    
                  
                          
end subroutine                          