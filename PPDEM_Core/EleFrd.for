	subroutine EleFrd(nEle,xEle,yEle,rEle,nVertex,xVertex,yVertex,
     $		pair,nPair,nGridX,nGridY,nEleGrid,lEG,maxGap,
     $      nEleFrd,pairIndex,oldNPair,oldPair,
     $      oldNEleFrd,oldPairIndex,alwNEleFrd,maxNEleFrd,
     $      flag1stEF,maxNEleGrid,hSector)

	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: EleFrd
	 !DEC$ ATTRIBUTES ALIAS:'EleFrd' :: EleFrd
	 !DEC$ ATTRIBUTES Reference :: 
     $      nEle,xEle,yEle,rEle,nVertex,xVertex,yVertex,
     $		pair,nPair,nGridX,nGridY,nEleGrid,lEG,maxGap,
     $      nEleFrd,pairIndex,oldNPair,oldPair,
     $      oldNEleFrd,oldPairIndex,alwNEleFrd,maxNEleFrd,
     $      flag1stEF,maxNEleGrid,hSector
     
     
     
     
     	integer nEle,nGridX,nGridY,alwNEleFrd,maxNEleFrd,maxNEleGrid

	double precision xEle(nEle),yEle(nEle),rEle(nEle),
     $	xVertex(nEle,10),yVertex(nEle,10),maxGap,distEE,hSector(nEle)

	integer pair(nEle*alwNEleFrd,2),nPair,oldnPair,flagFrd,
     $   nVertex(nEle),oldPair(nEle*alwNEleFrd,2)
	
	integer nEleFrd(nEle),pairIndex(nEle,alwNEleFrd,2),
     $   oldNEleFrd(nEle),oldPairIndex(nEle,alwNEleFrd,2)
	! nEleFrd = number of Frds of each element
	! pairIndex: (iEle,iEleFrd,1)=Element index of iEle's iEleFrdth's Frd; (iEle,iEleFrd,2)=Pair index of iEle's iEleFrdth's Frd

	integer nEleGrid(nGridX,nGridY),lEG(nGridX,nGridY,maxNEleGrid)

	integer iEle,jELe,iVertex,iRow,iCol,iIRow,iICol,lStart,iList,jList,
     $   flag1stEF,iPair

	double precision xPA(10),yPA(10),xPB(10),yPB(10)
	
	double precision time111

      maxNEleFrd=0
      
      if (flag1stEF.eq.1) then
	   oldPair=pair
	   oldnPair=nPair
	   oldNEleFrd=nEleFrd
	   oldPairIndex=PairIndex
	   flag1stEF=0
	end if
	
	nPair=0
	nEleFrd=0
	pairIndex=0

      !call clockx(time111)
      !!write (10000,*) "strating eleFrd",time111

	do iRow=1,nGridY
		do iCol=1,nGridX
			do iList=1,nEleGrid(iCol,iRow)
				iEle=lEG(iCol,iRow,iList)
				do iIRow=iRow,min(nGridY,iRow+1)
					do iICol=max(1,iCol-1),min(nGridX,iCol+1)
						
						if ((iIcol.eq.iCol).and.(iIRow.eq.iRow)) then
							lStart=iList+1
						else if ((iIcol.eq.(iCol-1)).and.(iIRow.eq.iRow)) then
							lstart=1e6
						else
							lStart=1
						end if

						do jList=lstart,nEleGrid(iICol,iiRow)
							jEle=lEG(iICol,iIRow,jList)


	if (((xEle(iEle)-xEle(jEle))**2+(yEle(iEle)-yEle(jEle))**2).lt.
     $	(rEle(iELe)+rEle(jEle)+maxGap)**2) then
	
		if ((nVertex(iEle).eq.0).and.(nVertex(jELe).eq.0)) then

			nPair=nPair+1
			pair(nPair,1)=iEle
			pair(nPair,2)=jEle
			
			nEleFrd(iEle)=nEleFrd(iEle)+1
			maxNEleFrd=max(maxNEleFrd,nEleFrd(iEle))
			if (maxNEleFrd.eq.alwNEleFrd) then
			   goto 8876
			end if
		   pairIndex(iEle,nEleFrd(iEle),1)=jEle
		   pairIndex(iEle,nEleFrd(iEle),2)=nPair

		else

			if ((nVertex(iEle).gt.2).and.(nVertex(jELe).gt.2)) then

				do iVertex=1,nVertex(iEle)+1
					xPA(iVertex)=xVertex(iEle,iVertex)
					yPA(iVertex)=yVertex(iEle,iVertex)
				end do
				do iVertex=1,nVertex(jEle)+1
					xPB(iVertex)=xVertex(jEle,iVertex)
					yPB(iVertex)=yVertex(jEle,iVertex)
				end do
				
				call PPDist(nVertex(iEle),xPA,yPA,nVertex(jEle),xPB,yPB,
     $			maxGap+hSector(iEle)+hSector(jELe),flagFrd)

				if (flagFrd.eq.1) then
				
					nPair=nPair+1
					pair(nPair,1)=iEle
					pair(nPair,2)=jEle
				
					nEleFrd(iEle)=nEleFrd(iEle)+1
			      maxNEleFrd=max(maxNEleFrd,nEleFrd(iEle))
			      if (maxNEleFrd.eq.alwNEleFrd) then
			         goto 8876
			      end if
		         pairIndex(iEle,nEleFrd(iEle),1)=jEle
		         pairIndex(iEle,nEleFrd(iEle),2)=nPair
				
				end if

			else if ((nVertex(iEle).eq.0).and.(nVertex(jELe).gt.2)) then

				do iVertex=1,nVertex(jEle)+1
					xPB(iVertex)=xVertex(jEle,iVertex)
					yPB(iVertex)=yVertex(jEle,iVertex)
				end do

				call PCDist(xEle(iEle),yEle(iEle),rEle(iEle),
     $			nVertex(jEle),xPB,yPB,maxGap+hSector(jEle),flagFrd)
				
				if (flagFrd.eq.1) then
					nPair=nPair+1
					pair(nPair,1)=iEle
					pair(nPair,2)=jEle
				
					nEleFrd(iEle)=nEleFrd(iEle)+1
			      maxNEleFrd=max(maxNEleFrd,nEleFrd(iEle))
			      if (maxNEleFrd.eq.alwNEleFrd) then
			         goto 8876
			      end if
		         pairIndex(iEle,nEleFrd(iEle),1)=jEle
		         pairIndex(iEle,nEleFrd(iEle),2)=nPair
				
				end if


			else if ((nVertex(iEle).gt.2).and.(nVertex(jELe).eq.0)) then

				do iVertex=1,nVertex(iEle)+1
					xPB(iVertex)=xVertex(iEle,iVertex)
					yPB(iVertex)=yVertex(iEle,iVertex)
				end do

				call PCDist(xEle(jEle),yEle(jEle),rEle(jEle),
     $			nVertex(iEle),xPB,yPB,maxGap+hSector(iEle),flagFrd)
				
				if (flagFrd.eq.1) then
					nPair=nPair+1
					pair(nPair,1)=iEle
					pair(nPair,2)=jEle
				
					nEleFrd(iEle)=nEleFrd(iEle)+1
			      maxNEleFrd=max(maxNEleFrd,nEleFrd(iEle))
			      if (maxNEleFrd.eq.alwNEleFrd) then
			         goto 8876
			      end if
		         pairIndex(iEle,nEleFrd(iEle),1)=jEle
		         pairIndex(iEle,nEleFrd(iEle),2)=nPair
				
				end if

			end if
		end if

	end if



						end do 

					end do 

				end do 

			end do 

		end do 

	end do 
	
      !call clockx(time111)
      !!write (10000,*) "finishing eleFrd",time111
      


8876	end subroutine

