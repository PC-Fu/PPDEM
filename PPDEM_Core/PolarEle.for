	subroutine PolarEle(nEle,nActEle,xEle,yEle,qEle,nVertex,qiVertex,
     $  rVertex,rEle,areaEle,MIEle,xVertex,yVertex,rqCE,xCE,CAC,hSector)

	implicit none
	
	
	integer nEle,nActEle
	integer nVertex(nEle)
	integer iEle,iVertex,nVE,iV,jV

	double precision xEle(nEle),yEle(nEle),qEle(nEle),
     $	qiVertex(nEle,10),rVertex(nEle,10),rEle(nEle)													!
	double precision areaEle(nEle),MIEle(nEle)

	double precision cx,cy,sinq,cosq,lChord,sectorArea

	double precision xVertex(nEle,10),yVertex(nEle,10)
	
	double precision rqCE(nEle,10,4),xCE(nEle,10,2),xMPViVj(2),
     $   lViVj,cosqViVj,sinqViVj,cosqCE,sinqCE,
     $   CAC(nEle,10),hSector(nEle)
	
	! xMPViVj = coordinate of the mid point of each edge
	! CAC =  the central angle of the arc.
	
	!!! Area, centroid, moment of inertia of each element !!!
	
	areaEle=0
	hSector=0


	
	
	do iEle=1,nActEle
	

		nVE=nVertex(iEle)
	
		if (nVertex(iEle).gt.2) then ! Polygon

			xEle(iEle)=0
			yEle(iEle)=0
			
			do iVertex=1,nVertex(iEle)

				iV=iVertex

				if (iV.lt.nVertex(iEle)) then
					jV=iV+1
				else
					jV=mod(iV+1,nVertex(iEle))
				end if

				areaEle(iEle)=areaEle(iEle)
     $				+xVertex(iEle,iV)*yVertex(iEle,jV)
     $				-xVertex(iEle,jV)*yVertex(iEle,iV)

				xEle(iEle)=xEle(iEle)+(xVertex(iEle,iV)+xVertex(iEle,jV))
     $				*(xVertex(iEle,iV)*yVertex(iEle,jV)-
     $				xVertex(iEle,jV)*yVertex(iEle,iV))

				yEle(iEle)=yEle(iEle)+(yVertex(iEle,iV)+yVertex(iEle,jV))
     $				*(xVertex(iEle,iV)*yVertex(iEle,jV)-
     $				xVertex(iEle,jV)*yVertex(iEle,iV))
			
			end do !iVertex
			
			areaEle(iEle)=areaEle(iEle)/2.

			xEle(iEle)=xEle(iEle)/6./areaEle(iEle)
			yEle(iEle)=yEle(iEle)/6./areaEle(iEle)
			
		else ! Circle
			
			areaEle(iEle)=3.1415926535*rEle(iEle)**2

		end if

	end do ! iEle=1,nActEle

	
	!!! Polar coordinates of each vertex, radius of bounding circle and approximation of moment of inertia.
	
	do iEle=1,nActEle
	
		
		if (nVertex(iEle).gt.2) then

			cx=xEle(iEle)
			cy=yEle(iEle)
			
			rEle(iEle)=0
				
			do iVertex=1,nVertex(iEle)

				rVertex(iEle,iVertex)=sqrt((xVertex(iEle,iVertex)-cx)**2
     $				+(yVertex(iEle,iVertex)-cy)**2)
				
				sinq=(yVertex(iEle,iVertex)-cy)/rVertex(iEle,iVertex)
				cosq=(xVertex(iEle,iVertex)-cx)/rVertex(iEle,iVertex)

				qiVertex(iEle,iVertex)=Dacos(cosq)
				if (sinq.lt.0) then
					qiVertex(iEle,iVertex)=2*3.1415926535-qiVertex(iEle,iVertex)
				end if

				if (rVertex(iEle,iVertex).gt.rEle(iEle)) then
					rEle(iEle)=rVertex(iEle,iVertex)
				end if

			end do ! iVertex
			
			
			rVertex(iEle,nVertex(iEle)+1)=rVertex(iEle,1)
			qiVertex(iEle,nVertex(iEle)+1)=qiVertex(iEle,1)
			
			end if
			
			MIEle(iEle)=0.5*areaEle(iEle)*rEle(iEle)**2
		
	end do ! iEle=1,nActEle
	
	
	do iEle=1,nActEle
		if (nVertex(iEle).gt.2) then
	   do iV=1,nVertex(iEle)
	   
	      xMPViVj(1)=(xVertex(iEle,iV)+xVertex(iEle,iV+1))/2
	      xMPViVj(2)=(yVertex(iEle,iV)+yVertex(iEle,iV+1))/2
	      
	      lViVj=sqrt((xVertex(iEle,iV)-xVertex(iEle,iV+1))**2
     $	      +(yVertex(iEle,iV)-yVertex(iEle,iV+1))**2)
            cosqViVj=-(yVertex(iEle,iV+1)-yVertex(iEle,iV))/lViVj
            sinqViVj=(xVertex(iEle,iV+1)-xVertex(iEle,iV))/lViVj
            
            xCE(iEle,iV,1)=xMPViVj(1)+lViVj/2/
     $         Dtan(CAC(iEle,iV)/2)*cosqViVj
            xCE(iEle,iV,2)=xMPViVj(2)+lViVj/2/
     $         Dtan(CAC(iEle,iV)/2)*sinqViVj
            
            rqCE(iEle,iV,3)=lViVj/2/Dsin(CAC(iEle,iV)/2)
            
            rqCE(iEle,iV,1)=sqrt((xCE(iEle,iV,1)-xEle(iEle))**2
     $         +(xCE(iEle,iV,2)-yEle(iEle))**2)
            
            cosqCE=(xCE(iEle,iV,1)-xEle(iEle))/rqCE(iEle,iV,1)
            sinqCE=(xCE(iEle,iV,2)-yEle(iEle))/rqCE(iEle,iV,1)
            
            rqCE(iEle,iV,2)=Dacos(cosqCE)
            if (sinqCE.lt.0) then
               rqCE(iEle,iV,2)=6.283185307- rqCE(iEle,iV,2)
            end if
            
            rqCE(iEle,iV,4)=Dacos((xVertex(iEle,iV)
     $      -xCE(iEle,iV,1)) /rqCE(iEle,iV,3))
     
            if (yVertex(iEle,iV)-xCE(iEle,iV,2).lt.0) then
               rqCE(iEle,iV,4)=6.283185307-rqCE(iEle,iV,4)
               
            end if
            
            hSector(iEle)=max(hSector(iEle),
     $       rqCE(iEle,iV,3)*(1-dcos(CAC(iEle,iV)/2)))
            
            

            
            ! xCE will be updated at every time step while rqCE will keep constant
	   end do
	   end if
	   
	   
	
	end do ! iEle
	
	do iEle=1,nActEle
		
		if (nVertex(iEle).gt.2) then
		
			do iV=1,nVertex(iEle)
			   lchord=Dsqrt((xVertex(iEle,iV)-xVertex(iEle,iV+1))**2+
     $		      (yVertex(iEle,iV)-yVertex(iEle,iV+1))**2)
			   areaEle(iEle)=areaEle(iEle)+sectorArea(lChord,rqCE(iEle,iV,3))
			   
			end do

		end if
	end do

	
	rEle=rEle+hSector
	qEle=0

	end subroutine

