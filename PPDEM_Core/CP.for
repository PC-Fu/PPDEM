	subroutine CP(rCA,rCB,xCA,xCB,yCA,yCB,qCA,qCB,aCA,aCB,vxCA,vxCB,
     $	vyCA,vyCB,vqCA,vqCB,nVPB,xPB,yPB,FxCA,FyCA,FxCB,FyCB,MCA,MCB,
     $	E,tanTheta,flagPC,FtPair,dt,alpha,beta,xcon,ycon,
     $	flagGlue,flagPairCohe,
     $	cosQiAM,sinQiAM,rMA,cosQiAN,sinQiAN,rNA,
     $	cosQiBM,sinQiBM,rMB,cosQiBN,sinQiBN,rNB,ECohe,nPtHL,xPtHL,
     $	strgFactor,strgTensl,cosNorm)


	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!  Careful.  Two cases, two edges intersect the circle and one edges intersect the circle, are handled seperately



	implicit none

	
	double precision rCA,rCB,xCA,xCB,yCA,yCB,qCA,qCB,vxCA,vxCB,vyCA,
     $	vyCB,vqCA,vqCB,xPB(10),yPB(10),FxCA,FyCA,FxCB,FyCB,MCA,MCB,
     $	E,tanTheta,alpha,beta,dampt,dampn,cosNorm

	double precision aOver,lCord,Fn,Ft,aCA,aCB

	double precision areaO1,areaO2,cO1(2),cO2(2)

	double precision cosA,sinA,cosB,sinB,cosD,sinD,cosE,sinE,cosF,sinF,
     $								cosBF,cosBE,cosG,sinG, sinBA    
		
		
	double precision vtCA,vtCB,vnCA,vnCB

	double precision dx,dy,dr,D,delta

	double precision xLCi,yLCi,xLC(5),yLC(5),xVinC(10),yVinC(10),
     $	xCon,yCon   ! xCon, yCon=coordinates of the contact point

	double precision angC, lAO,lOB
	! lCord=the length of the cord if only one edge intersects the circle
	! angC= half of the angle of the sector

	integer iEdge,iVertex

	integer nVPB,nLC,mLC,flagPC,nVinC
	! nVPB=nuber of vertexes of Polygon B
	!	nCL=nuber of cross points between polygon edges and the circle A
	! flagLC=1 if the polygon intersect the circle; flagLC=0 they don't intersect

	double precision FtPair,dt

	integer flagGlue,flagPairCohe

	double precision sinC,cosC,cosQAM,sinQAM,cosQAN,sinQAN,cosQiAM,
     $	sinQiAM,cosQiAN,sinQiAN,cosQBM,sinQBM,cosQBN,sinQBN,cosQiBM,
     $	sinQiBM,cosQiBN,sinQiBN,cosM,sinM,cosN,sinN,rMA,rNA,rMB,rNB

	double precision xAM(2),xAN(2),xBM(2),xBN(2),ECohe,FCoheN,FCoheM,
     $	lAMBM,lANBN,strgFactor,strgTensl

	integer nPtHL
	double precision xPtHL(100000,2),tempA,tempB



	xPB(nVPB+1)=xPB(1)
	yPB(nVPB+1)=yPB(1)

	nLC=0
	Fn=0
	Ft=0

	FxCA=0
	FyCA=0
	MCA=0

	FxCB=0
	FyCB=0
	MCB=0

	xVinC=0
	yVinC=0



	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!!!!!! Search for polygon edges that intersect the circle !!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

	do iEdge=1,nVPB

		mLC=0
		
		dx=xPB(iEdge+1)-xPB(iEdge)
		dy=yPB(iEdge+1)-yPB(iEdge)
		dr=sqrt(dx**2+dy**2)
		D=(xPB(iEdge)-xCA)*(yPB(iEdge+1)-yCA)- 
     $  	 (xPB(iEdge+1)-xCA)*(yPB(iEdge)-yCA) 
		delta=rCA**2*dr**2-D**2     !http://mathworld.wolfram.com/Circle-LineIntersection.html

		if (delta.gt.0.) then		! The infinite line incersects the circle; check whether the intersecting point is on the edge

			xLCi= (D*dy+sign(sqrt(delta),dy)*dx)/dr**2+xCA
			yLCi=(-D*dx+abs(dy)*sqrt(delta))/dr**2+yCA

			if (((xLCi.gt.min(xPB(iEdge+1),xPB(iEdge))).and.
     $			(xLCi.lt.max(xPB(iEdge+1),xPB(iEdge)))).or.
     $			((yLCi.gt.min(yPB(iEdge+1),yPB(iEdge))).and.
     $			(yLCi.lt.max(yPB(iEdge+1),yPB(iEdge))))) then ! the intersection point is on the edge
				
				nLC=nLC+1
				mLC=mLC+1
				xLC(nLC)=xLCi
				yLC(nLC)=yLCi
			end if

			xLCi= (D*dy-sign(sqrt(delta),dy)*dx)/dr**2+xCA
			yLCi=(-D*dx-abs(dy)*sqrt(delta))/dr**2+yCA

			if (((xLCi.gt.min(xPB(iEdge+1),xPB(iEdge))).and.
     $			(xLCi.lt.max(xPB(iEdge+1),xPB(iEdge)))).or.
     $			((yLCi.gt.min(yPB(iEdge+1),yPB(iEdge))).and.
     $			(yLCi.lt.max(yPB(iEdge+1),yPB(iEdge))))) then ! the intersection point is on the edge
			
				nLC=nLC+1
				mLC=mLC+1
				xLC(nLC)=xLCi
				yLC(nLC)=yLCi
			end if

			if (nLC.eq.2) then  !
				flagPC=1
				goto 1003  
			end if

		end if  ! the infinite line does not intersect the circule
	end do ! iEdge

	if (nLC.lt.2) then  ! the Polygon B doesn't intersect Circle A.
		flagPC=0 
		goto 1007
	end if


1003		xCon=0.5*(xLC(1)+xLC(2))
		yCon=0.5*(yLC(1)+yLC(2))
		lCord=sqrt((xLC(1)-xLC(2))**2+(yLC(1)-yLC(2))**2)
		angC=Dasin(0.5*lCord/rCA)
		lAO=sqrt((xCon-xCA)**2+(yCon-yCA)**2)
		cosA=(xCon-xCA)/lAO
		sinA=(yCon-yCA)/lAO
		cosB=-sinA
		sinB=cosA
		
	  if (abs(sinB).gt.1e-5) then
      	    cosNorm=-cosB/sinB
	  else
	      cosNorm=1.e3
	  end if


	if (flagGlue.eq.1) then

		xAM(1)=xLC(1)
		xAM(2)=yLC(1)
		xAN(1)=xLC(2)
		xAN(2)=yLC(2)

		rMA=rCA
		rNA=rCB
		rMB=sqrt((xAM(1)-xCB)**2+(xAM(2)-yCB)**2)
		rNB=sqrt((xAN(1)-xCB)**2+(xAN(2)-yCB)**2)

		cosQAM=(xAM(1)-xCA)/rMA
		sinQAM=(xAM(2)-yCA)/rMA
		cosQAN=(xAN(1)-xCA)/rNA
		sinQAN=(xAN(2)-yCA)/rNA
		cosQiAM=cosQAM*Dcos(qCA)+sinQAM*Dsin(qCA)					!(QiAM=QAM-qCA)
		sinQiAM=sinQAM*Dcos(qCA)-cosQAM*Dsin(qCA)					!(QiAM=QAM-qCA)
		cosQiAN=cosQAN*Dcos(qCA)+sinQAN*Dsin(qCA)					!(QiAN=QAN-qCA)
		sinQiAN=sinQAN*Dcos(qCA)-cosQAN*Dsin(qCA)					!(QiAN=QAN-qCA)


		cosQBM=(xAM(1)-xCB)/rMB
		sinQBM=(xAM(2)-yCB)/rMB
		cosQBN=(xAN(1)-xCB)/rNB
		sinQBN=(xAN(2)-yCB)/rNB
		cosQiBM=cosQBM*Dcos(qCB)+sinQBM*Dsin(qCB)					!(QiBM=QBM-qCB)
		sinQiBM=sinQBM*Dcos(qCB)-cosQBM*Dsin(qCB)					!(QiBM=QBM-qCB)
		cosQiBN=cosQBN*Dcos(qCB)+sinQBN*Dsin(qCB)				
		sinQiBN=sinQBN*Dcos(qCB)-cosQBN*Dsin(qCB)				

		
		ECohe=sqrt((xAM(1)-xAN(1))**2+(xAM(2)-xAN(2))**2)*E*2

		flagPairCohe=1


	end if !(flagPairCohe.eq.1)


	! if there are additional vertexes in circle, xcon,lAO, sinA, cosA will be replaced
	! sinB and cosB don't have to be replaced



	if (mLC.eq.2) then  ! the circle intersect this edge at two point.  No need to check inside vertexes

		flagPC=1
		aOver=0.5*rCA**2*(2*angC-Dsin(2*angC))


		lOB=sqrt((xCB-xCon)**2+(yCB-yCon)**2)
		cosD=(xCB-xCon)/lOB
		sinD=(yCB-yCon)/lOB
		cosE=-sinD
		sinE=cosD


		vtCA=vxCA*cosB+vyCA*sinB+vqCA*lAO
		vtCB=vxCB*cosB+vyCB*sinB-
     $ 			vqCB*lOB*(cosB*cosE+sinB*sinE)

		vnCA=vxCA*cosA+vyCA*sinA
		vnCB=vxCB*cosA+vyCB*sinA

		Fn=aOver*E						!*( 1+1/abs( 0.15*aOver- min(aCA,aCB) ) )

		Ft=FtPair+(vtCB-vtCA)*dt*(rCA+rCB)*E

		if (flagGlue.eq.1) then
				strgTensl=strgFactor*Fn
		end if

		if (Ft.ge.Fn*tanTheta) then
			Ft=Fn*tanTheta
		else if (Ft.le.(-Fn*tanTheta)) then
			Ft=-Fn*tanTheta
		end if


		FtPair=Ft
		
		dampn=(vnCA-vnCB)*(alpha*(aCA+aCB)+beta*E*aover/min(rCA,rCB))
	   dampt=(vtCB-vtCA)*(alpha*(aCA+aCB)+beta*E*aover/min(rCA,rCB))
   	
         !write (1123,'(4E13.5)') Fn,Ft,dampn,dampt

         if (abs(dampn).le.0.8*abs(Fn)) then
            dampn=dsign(0.8*Fn,dampn)
         end if
         if (abs(dampt).le.0.8*abs(Ft)) then
            dampt=dsign(0.8*Ft,dampt)
         end if

         !write (1125,'(4E13.5)') Fn,Ft,dampn,dampt

         Fn=Fn !+dampn
         Ft=Ft !+dampt

		FxCA=-Fn*cosA+Ft*cosB
		FyCA=-Fn*sinA+Ft*sinB
		MCA=Ft*lAO

		FxCB=-FxCA
		FyCB=-FyCA
		MCB=FxCB*lOB*sinD-FyCB*lOB*cosD

	else if (nLC.eq.2) then  ! Two intersecting points found.  Need to check vertexes inside the circle 
		flagPC=1
		nVinC=0
		do iVertex=1,nVPB
			if (((xPB(iVertex)-xCA)**2+(yPB(iVertex)-yCA)**2).lt.rCA**2) then
				nVinC=nVinC+1
				xVinC(nVinC)=xPB(iVertex)
				yVinC(nVinC)=yPB(iVertex)
			end if
		end do  ! iVertex=1,nVPB
		xVinC(nVinC+1)=xLC(1)
		yVinC(nVinC+1)=yLC(1)
		xVinC(nVinC+2)=xLC(2)
		yVinC(nVinC+2)=yLC(2)
		nVinC=nVinC+2

		call sortVinP(xVinC, yVinC, nVinC)

		xVinC(nVinC+1)=xVinC(1)
		yVinC(nVinC+1)=yVinC(1)
		
		call PolyAC(nVinC,xVinC,yVinC,areaO1,cO1)

		if (areaO1.lt.1e-12) then 
			goto 1007
		end if

		areaO2=0.5*rCA**2*(2*angC-Dsin(2*angC))
		cO2(1)=xCA+rCA*4/3*(Dsin(angC)**3/(angC-Dsin(angC)))*cosA
		cO2(2)=yCA+rCA*4/3*(Dsin(angC)**3/(angC-Dsin(angC)))*sinA
		
		aOver=areaO1+areaO2
		xCon=cO1(1)+(cO2(1)-cO2(1))/aOver*areaO1
		yCon=cO1(2)+(cO2(2)-cO2(2))/aOver*areaO1

		lAO=sqrt((xCon-xCA)**2+(yCon-yCA)**2)
		lOB=sqrt((xCon-xCB)**2+(yCon-yCB)**2)

		cosA=(xCon-xCA)/lAO
		sinA=(yCon-yCA)/lAO
		cosF=-sinA
		sinF=cosA

		sinBA=sinB*cosA-cosB*sinA    ! sin(B-A) should be positive.  if not, flip B.
		if (sinBA.lt.0) then
			sinB=-sinB
			cosB=-cosB
		end if

		cosD=(xCB-xCon)/lOB
		sinD=(yCB-yCon)/lOB
		cosE=-sinD
		sinE=cosD

		cosG=sinB
		sinG=-cosB

		cosBF=cosB*cosF+sinB*sinF
		cosBE=cosB*cosE+sinB*sinE

		
		vtCA=vxCA*cosB+vyCA*sinB+vqCA*lAO*cosBF
		vtCB=vxCB*cosB+vyCB*sinB-vqCA*lOB*cosBE

		vnCA=vxCA*cosG+vyCA*sinG
		vnCB=vxCB*cosG+vyCB*sinG

	if (aover.lt.1e-12) then

		flagPairCohe=0
		goto 1007

	end if

		Fn=aOver*E						!*( 1+1/abs( 0.15*aOver- min(aCA,aCB) ) )


		if (flagGlue.eq.1) then
				strgTensl=strgFactor*Fn
		end if


		Ft=FtPair+(vtCB-vtCA)*dt*(rCA+rCB)*E
		

		if (Ft.ge.aOver*E*tanTheta) then
			Ft=aOver*E*tanTheta
		else if (Ft.le.(-aOver*E*tanTheta)) then
			Ft=-aOver*E*tanTheta
		end if

		FtPair=Ft
		
		
		dampn=(vnCA-vnCB)*(alpha*(aCA+aCB)+beta*E*aover/min(rCA,rCB))
	   dampt=(vtCB-vtCA)*(alpha*(aCA+aCB)+beta*E*aover/min(rCA,rCB))
   	
         if (abs(dampn).le.0.8*abs(Fn)) then
            dampn=dsign(0.8*Fn,dampn)
         end if
         if (abs(dampt).le.0.8*abs(Ft)) then
            dampt=dsign(0.8*Ft,dampt)
         end if

         !write (1125,'(4E13.5)') Fn,Ft,dampn,dampt

         Fn=Fn !+dampn
         Ft=Ft !+dampt
         
		FxCA=-Fn*cosG+Ft*cosB
		FxCB=Fn*cosG-Ft*cosB
		FyCA=-Fn*sinG+Ft*sinB
		FyCB=Fn*sinG-Ft*sinB
		MCA=-FxCA*lAO*sinA+FyCA*lAO*cosA
		MCB=FxCB*lOB*sinD-FyCB*lOB*cosD

		





	end if  ! check whether there is vertexes inside the circle



	

	if (flagPairCohe.eq.1) then


		cosQAM=Dcos(qCA)*cosQiAM-Dsin(qCA)*sinQiAM			!(QAM=qCA+QiAM)
		sinQAM=Dsin(qCA)*cosQiAM+Dcos(qCA)*sinQiAM			!(QAM=qCA+QiAM)
		cosQAN=Dcos(qCA)*cosQiAN-Dsin(qCA)*sinQiAN			!(QAN=qCA+QiAN)
		sinQAN=Dsin(qCA)*cosQiAN+Dcos(qCA)*sinQiAN			!(QAM=qCA+QiAN)
		cosQBM=Dcos(qCB)*cosQiBM-Dsin(qCB)*sinQiBM			
		sinQBM=Dsin(qCB)*cosQiBM+Dcos(qCB)*sinQiBM		
		cosQBN=Dcos(qCB)*cosQiBN-Dsin(qCB)*sinQiBN			
		sinQBN=Dsin(qCB)*cosQiBN+Dcos(qCB)*sinQiBN			
		xAM(1)=xCA+rMA*cosQAM
		xAM(2)=yCA+rMA*sinQAM
		xAN(1)=xCA+rNA*cosQAN
		xAN(2)=yCA+rNA*sinQAN
		xBM(1)=xCB+rMB*cosQBM
		xBM(2)=yCB+rMB*sinQBM
		xBN(1)=xCB+rNB*cosQBN
		xBN(2)=yCB+rNB*sinQBN

		nPtHL=nPtHL+1
		xPtHL(nPtHL,1)=(xAM(1)+xAN(1))/2
		xPtHL(nPtHL,2)=(xAM(2)+xAN(2))/2


		lAMBM=sqrt((xAM(1)-xBM(1))**2+(xAM(2)-xBM(2))**2)
		lANBN=sqrt((xAN(1)-xBN(1))**2+(xAN(2)-xBN(2))**2)
		FCoheM=lAMBM*ECohe
		FCoheN=lANBN*ECohe

		if (FCoheM+FCoheN.gt.strgTensl) then
			FCoheM=0
			FCoheN=0
			lAMBM=0
            lANBN=0
            flagPairCohe=0
		end if

		if (lAMBM.gt.1e-12) then
			cosM=(xBM(1)-xAM(1))/lAMBM
			sinM=(xBM(2)-xAM(2))/lAMBM
			FxCA=FxCA+FCoheM*cosM
			FyCA=FyCA+FCoheM*sinM
			FxCB=FxCB-FCoheM*cosM
			FyCB=FyCB-FCoheM*sinM
			MCA=MCA-FCoheM*cosM*rMA*sinQAM+FCoheM*sinM*rMA*cosQAM
			MCB=MCB+FCoheM*cosM*rMB*sinQBM-FCoheM*sinM*rMB*cosQBM
		end if

		if (lANBN.gt.1e-12) then
			cosN=(xBN(1)-xAN(1))/lANBN
			sinN=(xBN(2)-xAN(2))/lANBN
			FxCA=FxCA+FCoheN*cosN
			FyCA=FyCA+FCoheN*sinN
			FxCB=FxCB-FCoheN*cosN
			FyCB=FyCB-FCoheN*sinN
			MCA=MCA-FCoheN*cosN*rNA*sinQAN+FCoheN*sinN*rNA*cosQAN
			MCB=MCB+FCoheN*cosN*rNB*sinQBN-FCoheN*sinN*rNB*cosQBN
		end if
		

	end if		!(flagPairCohe.eq.1)


		
1007	end subroutine

