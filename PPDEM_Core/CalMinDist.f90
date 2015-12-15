	subroutine CalMinDist(nEle, nActEle, xEle, yEle, rEle, nVertex, &
	pair, nPair, alwNEleFrd, nDistEle, distEle, meanDist, stdevDist, dThreeMean, dThreeBig, dThreeSmall, dThreeDev, nCThree, dCThree, coordTen)

	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: CalMinDist
	 !DEC$ ATTRIBUTES ALIAS:'CalMinDist' :: CalMinDist
	 !DEC$ ATTRIBUTES Reference :: nEle, nActEle, xEle, yEle, rEle, nVertex, pair, nPair, alwNEleFrd, nDistEle, distEle, meanDist, stdevDist, dThreeMean, dThreeBig, dThreeSmall, dThreeDev, nCThree, dCThree, coordTen

    integer nEle,nActEle, alwNEleFrd, nPair, nVertex(nEle),  nDistEle(nEle)
    
	double precision xEle(nEle),yEle(nEle),rEle(nEle), distEle(alwNEleFrd,nEle)
    
	integer pair(nEle*alwNEleFrd,2)
	double precision meanDist(6), stdevDist(6), dist
	integer iPair, iEle, jEle, count, i,nContEle(nEle),count1,count2
	
    double precision dThree(nEle),dThreeMean,dThreeBig,dThreeSmall,dThreeDev, nCThree,dCThree,dThreeOrigin(nEle),dThreeTenP,coordTen, dThreeQ1, dThreeQ3
    nDistEle = 0.0
    distEle = 1e6
    meanDist = 0.0
    stdevDist = 0.0
    
    dThree=0.0
    dThreeMean=0.0
    dThreeBig=0.0
    dThreeSmall=0.0
    dThreeDev=0.0
    dThreeTenP=0.0
    dThreeOrigin=0.0
    coordTen=0.0
    nContEle=0.0
    
    do iPair=1,nPair
        iEle=pair(iPair,1)
	    jEle=pair(iPair,2)
	    dist = (xEle(iEle) - xEle(jEle))**2 + (yEle(iEle) - yEle(jEle))**2
	    dist = dist ** 0.5 - rEle(iEle) - rEle(jEle)
        if (dist .le. 1e-12) then
            nContEle(iEle)=nContEle(iEle)+1
            nContEle(jEle)=nContEle(jEle)+1
        end if
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
    
    do i=1,6
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
    
    count=0
    do iEle=1,nActEle
        if (ndistEle(iEle) .ge. 3) then
            count = count + 1
        end if
    end do

    do iEle=1,nActEle
        if (ndistEle(iEle) .ge. 3) then
            dThree(iEle)=(distEle(1,iEle)+distEle(2,iEle)+distEle(3,iEle))/3
            dThreeOrigin(iEle)= (distEle(1,iEle)+distEle(2,iEle)+distEle(3,iEle))/3
        end if
    end do
    call SortArray( dThree, nEle)
    do iEle=1,nEle
        dThreeMean=dThreeMean+dThree(iEle)
        if (iEle .le. count/10*2.5) then
            dThreeBig=dThreeBig+dThree(nEle+1-iEle)
            dThreeTenP=dThree(nEle+1-iEle)
            dThreeQ3=dThree(nEle+1-iEle)
        else
            if (iEle .le. count/10*7.5) then
                dThreeQ1=dThree(nEle+1-iEle)
            end if
            dThreeSmall=dThreeSmall+dThree(nEle+1-iEle)
        end if
    end do
    !dThreeBig=0.0
    !dThreeSmall=0.0
    !count1=0.0
    !count2=0.0
    !do iEle=1,nEle
    !    if (ndistEle(iEle) .ge. 3) then
    !    if (dThreeOrigin(iEle) .ge. dThreeQ3+1.5*(dThreeQ3-dThreeQ1)) then
    !        dThreeBig=dThreeBig+dThreeOrigin(iEle)
    !        count1=count1+1
    !    else
    !        dThreeSmall=dThreeSmall+dThreeOrigin(iEle)
    !        count2=count2+1
    !    end if
    !    end if
    !end do
    dThreeMean=dThreeMean/count
    dThreeBig=dThreeBig/count*10/2.5
    dThreeSmall=dThreeSmall/count*10/7.5
    do iEle=1,nEle
        if (ndistEle(iEle) .ge. 3) then
            dThreeDev = dThreeDev + (dThree(iEle)-dThreeMean)**2
        end if      
    end do
    dThreeDev=(dThreeDev/(count-1))**0.5
    
    nCThree=0
    dCThree=0.0
    do iEle=1,nActEle
        if (ndistEle(iEle) .ge. 3) then
            if (distEle(3,iEle) .le. 1e-20) then
               dCThree = dCThree + rEle(iEle) * 2 
               nCThree = nCThree + 1
            end if
            
        end if
    end do
    
    dCThree = dCThree/nCThree    
    nCThree = nCThree/count
    !dCThree = (count1*1.0)/(count*1.0)    
    !nCThree = (count2*1.0)/(count*1.0)  
    !open(unit=1234,file="d3.out")
    !do i=1,nEle
    !    if (i .ge. nEle-count) then
    !       write(1234,*) dThree(i)
    !    end if
    !end do
    count=0
    coordTen=0.0
    do iEle=1,nEle
        if (dThreeOrigin(iEle) .ge. dThreeTenP) then
            count=count+1
            coordTen=coordTen+nContEle(iEle)
        end if
    end do
    coordTen=coordTen/count
        
	end subroutine

