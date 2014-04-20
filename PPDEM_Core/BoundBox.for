	subroutine BoundBox(nEle,nActEle,xEle,yEle,rEle,nVertex,xVertex,
     $	yVertex,boundEle,hSector)

	implicit none

	integer nEle,nActEle,numThreads
	integer nVertex(nEle),iEle,iVertex

	double precision xEle(nEle),yEle(nEle),rEle(nEle),xVertex(nEle,10),
     $	yVertex(nEle,10), boundEle(nEle,4),hSector(nEle)



      !$omp parallel do private (iVertex)


	do iEle=1,nActEle
	

		if (nVertex(iEle).eq.0) then
			
			boundEle(iEle,1)=xEle(iEle)-rEle(iELe)
			boundEle(iEle,2)=xEle(iEle)+rEle(iELe)
			boundEle(iEle,3)=yEle(iEle)-rEle(iELe)
			boundEle(iEle,4)=yEle(iEle)+rEle(iELe)
		
		else
			
			boundEle(iEle,1)=xVertex(iEle,1)
			boundele(iEle,2)=xVertex(iEle,1)
			boundEle(iEle,3)=yVertex(iEle,1)
			boundele(iEle,4)=yVertex(iEle,1)
			do iVertex=2,nVertex(iEle)
			    boundEle(iEle,1)=min(boundEle(iEle,1),xVertex(iEle,iVertex))
			    boundEle(iEle,2)=max(boundEle(iEle,2),xVertex(iEle,iVertex))
			    boundEle(iEle,3)=min(boundEle(iEle,3),yVertex(iEle,iVertex))
			    boundEle(iEle,4)=max(boundEle(iEle,4),yVertex(iEle,iVertex))
			end do
			
			boundEle(iEle,1)=boundEle(iEle,1)-hSector(iEle)
			boundele(iEle,2)=boundEle(iEle,2)+hSector(iEle)
			boundEle(iEle,3)=boundEle(iEle,3)-hSector(iEle)
			boundele(iEle,4)=boundEle(iEle,4)+hSector(iEle)
            		
		end if

	end do

	end subroutine
