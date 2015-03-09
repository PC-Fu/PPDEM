	subroutine CalMinDist(nEle, nActEle, xEle, yEle, rEle, nVertex, &
	pair, nPair, alwNEleFrd, nDistEle, distEle, meanDist, stdevDist)

	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: CalMinDist
	 !DEC$ ATTRIBUTES ALIAS:'CalMinDist' :: CalMinDist
	 !DEC$ ATTRIBUTES Reference :: nEle, nActEle, xEle, yEle, rEle, nVertex, pair, nPair, alwNEleFrd, nDistEle, distEle, meanDist, stdevDist

    integer nEle,nActEle, alwNEleFrd, nPair, nVertex(nEle),  nDistEle(nEle)
    
	double precision xEle(nEle),yEle(nEle),rEle(nEle), distEle(alwNEleFrd,nEle)
    
	integer pair(nEle*alwNEleFrd,2)
	double precision meanDist(3), stdevDist(3), dist
	integer iPair, iEle, jEle, count, i
	
    nDistEle = 0.0
    distEle = 1e6
    meanDist = 0.0
    stdevDist = 0.0
    
    do iPair=1,nPair
        iEle=pair(iPair,1)
	    jEle=pair(iPair,2)
	    dist = (xEle(iEle) - xEle(jEle))**2 + (yEle(iEle) - yEle(jEle))**2
	    dist = dist ** 0.5 - rEle(iEle) - rEle(jEle)
	    dist = max (dist, 0.0)
	    nDistEle(iEle) = nDistEle(iEle) + 1
	    distEle(nDistEle(iEle), iEle) = dist
	    nDistEle(jEle) = nDistEle(jEle) + 1
	    distEle(nDistEle(jEle), jEle) = dist
    end do
    
    do iEle = 1, nActEle
        if (nDistEle(iEle).gt.1) then
            call SortArray( distEle(1:nDistEle(iEle), iEle), nDistEle(iEle))
        end if
    end do
    
    do i=1,3
        count=0
        do iEle=1,nActEle
            if (ndistEle(iEle) .ge. i) then
                count = count + 1
                meanDist(i) = meanDist(i) + distEle(i,iEle)
            end if
        end do
        meanDist(i) = meanDist(i) / count
        
        do iEle=1,nActEle
            if (ndistEle(iEle) .ge. i) then
                stdevDist(i) = stdevDist(i) + (distEle(i,iEle)-meanDist(i))**2
            end if
        end do
        stdevDist(i) = (stdevDist(i)/(count-1))**0.5        
    
    
    end do
    
	end subroutine

