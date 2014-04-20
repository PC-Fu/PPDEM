	subroutine udVertex(nEle,nActEle,xEle,yEle,qEle,qVertex,rVertex,
     $					 	nVertex,xVertex,yVertex,rqCE,xCE,numThreads)   

	implicit none
	
	 
	integer nEle,nActEle,nVertex(nEle),iEle,iVertex,numThreads
	double precision xEle(nEle),yEle(nEle),qEle(nEle),qVertex(nEle,10)
     $	,rVertex(nEle,10),xVertex(nEle,10),yVertex(nEle,10)
      double precision rqCE(nEle,10,4),xCE(nEle,10,2)
     
     
      call omp_set_num_threads (numThreads)

      !$omp parallel do private (iVertex)

	do iEle=1,nActEle

		do iVertex=1,nVertex(iEle)
			
			xVertex(iEle,iVertex)=xEle(iEle)+
     $			rVertex(iEle,iVertex)*Dcos(qEle(iEle)+qVertex(iEle,iVertex))
	
			yVertex(iEle,iVertex)=yEle(iEle)+
     $			rVertex(iEle,iVertex)*Dsin(qEle(iEle)+qVertex(iEle,iVertex))
     
            xCE(iEle,iVertex,1)=xEle(iEle)+rqCE(iEle,iVertex,1)
     $         *Dcos(qEle(iEle)+rqCE(iEle,iVertex,2))
     
            xCE(iEle,iVertex,2)=yEle(iEle)+ rqCE(iEle,iVertex,1)
     $        *Dsin(qEle(iEle)+rqCE(iEle,iVertex,2))
     
            rqCE(iEle,iVertex,4)=Dacos((xVertex(iEle,iVertex)
     $       -xCE(iEle,iVertex,1))/rqCE(iEle,iVertex,3))
     
            if (yVertex(iEle,iVertex)-xCE(iEle,iVertex,2).lt.0) then
            
               rqCE(iEle,iVertex,4)=6.283185307-rqCE(iEle,iVertex,4)
               
            end if
    
		
		end do !iVertex

			xVertex(iEle,nVertex(iEle)+1)=xVertex(iele,1)
			yVertex(iEle,nVertex(iEle)+1)=yVertex(iele,1)

	end do ! iEle
	end subroutine	