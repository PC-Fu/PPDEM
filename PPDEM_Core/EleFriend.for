	subroutine EleFriend(nEle,xEle,yEle,rEle,nVertex,xVertex,yVertex,
     $			pair,nFriend,nGridX,nGridY,nEleGrid,lEG,maxGap)
	!USE DFPORT 
      USE IFPORT

	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: EleFriend
	 !DEC$ ATTRIBUTES ALIAS:'EleFriend' :: EleFriend

	integer nEle,nGridX,nGridY

	double precision xEle(nEle),yEle(nEle),rEle(nEle),
     $	xVertex(nEle,10),yVertex(nEle,10),maxGap,distEE

	integer pair(nEle*20,2),nFriend,flagFriend,nVertex(nEle)

	integer nEleGrid(nGridX,nGridY),lEG(nGridX,nGridY,100)

	integer iEle,jELe,iVertex,iRow,iCol,iIRow,iICol,lStart,iList,jList

	double precision xPA(10),yPA(10),xPB(10),yPB(10)
	
	double precision time111


	nFriend=0

      !call clockx(time111)
      !!write (10000,*) "strating elefriend",time111

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

			nFriend=nFriend+1
			pair(nFriend,1)=iEle
			pair(nFriend,2)=jEle

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
     $			maxGap,flagFriend)

				if (flagFriend.eq.1) then
					nFriend=nFriend+1
					pair(nFriend,1)=iEle
					pair(nFriend,2)=jEle
				end if

			else if ((nVertex(iEle).eq.0).and.(nVertex(jELe).gt.2)) then

				do iVertex=1,nVertex(jEle)+1
					xPB(iVertex)=xVertex(jEle,iVertex)
					yPB(iVertex)=yVertex(jEle,iVertex)
				end do

				call PCDist(xEle(iEle),yEle(iEle),rEle(iEle),
     $			nVertex(jEle),xPB,yPB,maxGap,flagFriend)
				
				if (flagFriend.eq.1) then
					nFriend=nFriend+1
					pair(nFriend,1)=iEle
					pair(nFriend,2)=jEle
				end if


			else if ((nVertex(iEle).gt.2).and.(nVertex(jELe).eq.0)) then

				do iVertex=1,nVertex(iEle)+1
					xPB(iVertex)=xVertex(iEle,iVertex)
					yPB(iVertex)=yVertex(iEle,iVertex)
				end do

				call PCDist(xEle(jEle),yEle(jEle),rEle(jEle),
     $			nVertex(iEle),xPB,yPB,maxGap,flagFriend)
				
				if (flagFriend.eq.1) then
					nFriend=nFriend+1
					pair(nFriend,1)=iEle
					pair(nFriend,2)=jEle
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
      !!write (10000,*) "finishing elefriend",time111


	end subroutine

