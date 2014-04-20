	subroutine PP(rCA,rCB,xCA,xCB,yCA,yCB,qCA,qCB,aCA,aCB,vxCA,vxCB,
     $		vyCA,vyCB,vqCA,vqCB,nVPA,nVPB,xPA,xPB,yPA,yPB,FxCA,FyCA,
     $		FxCB,FyCB,MCA,MCB,E,tanTheta,flagPP,FtPair,dt,alpha,beta,
     $		xcon,ycon,flagGlue,flagPairCohe,
     $		cosQiAM,sinQiAM,rMA,cosQiAN,sinQiAN,rNA,
     $		cosQiBM,sinQiBM,rMB,cosQiBN,sinQiBN,rNB,ECohe,nPtHL,xPtHL,
     $		strgFactor,strgTensl,cosNorm)


	implicit none

	
	double precision rCA,rCB,xCA,xCB,yCA,yCB,qCA,qCB,vxCA,vxCB,vyCA,
     $	vyCB,vqCA,vqCB,xPA(10),xPB(10),yPA(10),yPB(10),FxCA,FyCA,
     $	FxCB,FyCB,MCA,MCB,E,tanTheta,aCA,aCB,cosNorm

	double precision aOver,Fn,Ft

	double precision cosA,sinA,cosB,sinB,cosD,sinD,cosE,sinE,cosF,sinF,
     $								cosBF,cosBE,cosG,sinG, sinBA    
		
	double precision vtCA,vtCB,vnCA,vnCB

	double precision dx,dy,dr,D,delta,dt,alpha,beta,dampt,dampn,dampM

	double precision xLCi,yLCi,xLC(2),yLC(2),xVinC(10),yVinC(10),
     $	xCon,yCon   ! xCon, yCon=coordinates of the contact point

	double precision angC, lAO,lOB

	integer iEdge,iVertex,jEdge

	integer nVPA,nVPB,nLC,mLC,flagPP,nVinC,flagPtPoly,flagdebug

	integer nEdgeA,nEdgeB,iEdgeA,iEdgeB,lEdgeA(10),lEdgeB(10),flagEC
	! nEdge=number of edges of A that are within or intersect the bounding circle of Polygon B
	! lEdge=list of of edges of A that are within or intersect the bounding circle of Polygon B

	integer nVinP,flagEE, nPEE  ! PEE = intersection point between edges
	double precision xVinP(10),yVinP(10),xtemp,ytemp,xPEE(10),yPEE(10)

	double precision FtPair,temp(2)

	integer flagGlue,flagPairCohe

	double precision sinC,cosC,cosQAM,sinQAM,cosQAN,sinQAN,cosQiAM,
     $	sinQiAM,cosQiAN,sinQiAN,cosQBM,sinQBM,cosQBN,sinQBN,cosQiBM,
     $	sinQiBM,cosQiBN,sinQiBN,cosM,sinM,cosN,sinN,rMA,rNA,rMB,rNB

	double precision xAM(2),xAN(2),xBM(2),xBN(2),ECohe,FCoheN,FCoheM,
     $	lAMBM,lANBN,strgFactor,strgTensl,tempA,tempB

	integer nPtHL
	double precision xPtHL(100000,2)


	!open (1000,file='debug.dat')
	FxCA=0
	FxCB=0
	FyCA=0
	FyCB=0
	MCA=0
	MCB=0
	Fn=0
	Ft=0
	flagPP=0


	!!!!!  Build lists of edges that potentially intersect with the other Polygon (intersect or are within the bounding circle).
	nEdgeA=0
	do iEdge=1,nVPA
		Call EdgeCircle(xPA(iEdge),yPA(iEdge),xPA(iEdge+1),
     $		yPA(iEdge+1),xCB,yCB,rCB,flagEC)
		if (flagEC.eq.1) then
			nEdgeA=nEdgeA+1
			lEdgeA(nEdgeA)=iEdge
		end if
	end do ! iEdge=1,nVPA


	nEdgeB=0
	do iEdge=1,nVPB
		Call EdgeCircle(xPB(iEdge),yPB(iEdge),xPB(iEdge+1),
     $		yPB(iEdge+1),xCA,yCA,rCA,flagEC)
		if (flagEC.eq.1) then
			nEdgeB=nEdgeB+1
			lEdgeB(nEdgeB)=iEdge
		end if
	end do ! iEdge=1,nVPA


	if ((nEdgeA.eq.0).or.(nEdgeB.eq.0)) then
		FxCA=0
		FxCB=0
		FyCA=0
		FyCB=0
		MCA=0
		MCB=0
		FtPair=0
		goto 6033
	end if

		

	!!!!!!  Build a list of vertexes that is inside of the other polygon
	nVinP=0
	nPEE=0


	do iVertex=1,nVPA
		if (((xPA(iVertex)-xCB)**2+(yPA(iVertex)-yCB)**2).lt.rCB**2) then

			Call PtPoly(xPA(iVertex),yPA(iVertex),nVPB,xPB,yPB,flagPtPoly)

			if (flagPtPoly.eq.1) then
				nVinP=nVinP+1
				xVinP(nVinP)=xPA(iVertex)
				yVinP(nVinP)=yPA(iVertex)
			end if

		end if
	end do !iVertex=1,nVPA

	do iVertex=1,nVPB
		if (((xPB(iVertex)-xCA)**2+(yPB(iVertex)-yCA)**2).lt.rCA**2) then

			Call PtPoly(xPB(iVertex),yPB(iVertex),nVPA,xPA,yPA,flagPtPoly)

			if (flagPtPoly.eq.1) then
				nVinP=nVinP+1
				xVinP(nVinP)=xPB(iVertex)
				yVinP(nVinP)=yPB(iVertex)
			end if

		end if
	end do !iVertex=1,nVPB



		!!!!!!!! Build a list of intersections between edges !!!!!!!!!!!!!!!!!!!
	!!!!!!!! For convenience, use the same index and array, nVinP, xVinP, yVinP 
	
	do iEdge=1, nEdgeA
		do jEdge=1,nEdgeB
			call EdgeEdge(  xPA(lEdgeA(iEdge)),yPA(lEdgeA(iEdge)),
     $										xPA(lEdgeA(iEdge)+1),yPA(lEdgeA(iEdge)+1),
     $										xPB(lEdgeB(jEdge)),yPB(lEdgeB(jEdge)),
     $										xPB(lEdgeB(jEdge)+1),yPB(lEdgeB(jEdge)+1),
     $										xtemp,ytemp,flagEE)
			if (flagEE.eq.1) then
				nVinP=nVinP+1
				xVinP(nVinP)=xtemp
				yVinP(nVinP)=ytemp
				nPEE=nPEE+1
				xPEE(nPEE)=xtemp
				yPEE(nPEE)=ytemp
			end if
	
		end do  !jEdge
	end do !iEdge
			
	if (nVinP.lt.3) then
		goto 6033
	end if

	if (flagGlue.eq.1) then

		xAM(1)=xVinP(nVinP-1)
		xAM(2)=yVinP(nVinP-1)
		xAN(1)=xVinP(nVinP)
		xAN(2)=yVinP(nVinP)

		rMA=sqrt((xAM(1)-xCA)**2+(xAM(2)-yCA)**2)
		rNA=sqrt((xAN(1)-xCA)**2+(xAN(2)-yCA)**2)
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



	call sortVinP(xVinp, yVinP, nVinP)

	xVinP(nVinP+1)=xVinP(1)
	yVinP(nVinP+1)=yVinP(1)

	
	aOver=0
	
	call findCon(nVinP,xVinP,yVinP,xCA,yCA,xCB,yCB,
     $						xCon,yCon,cosB,sinB,aover,nPEE,xPEE,yPEE)   ! Find the contact point

	if (aover.lt.1e-12) then

		flagPairCohe=0
		goto 6033

	end if
	
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
	
	
	if (abs(sinB).gt.1e-5) then
      	cosNorm=-cosB/sinB
	else
	  cosNorm=1.e3
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
	vtCB=vxCB*cosB+vyCB*sinB-vqCB*lOB*cosBE

	vnCA=vxCA*cosG+vyCA*sinG
	vnCB=vxCB*cosG+vyCB*sinG

	Fn=aOver*E						!*( 1+1/abs( 0.15*aOver- min(aCA,aCB) ) )
	
	Ft=FtPair+(vtCB-vtCA)*dt*(rCA+rCB)*E

	if (flagGlue.eq.1) then
			strgTensl=strgFactor*Fn
	end if


	

	if (Ft.ge.aOver*E*tanTheta) then
		Ft=aOver*E*tanTheta
	else if (Ft.le.(-aOver*E*tanTheta)) then
		Ft=-aOver*E*tanTheta
	end if

	FtPair=Ft
	
	dampn=(vnCA-vnCB)*(alpha*(aCA+aCB)+beta*E*aover/min(rCA,rCB))
	dampt=(vtCB-vtCA)*(alpha*(aCA+aCB)+beta*E*aover/min(rCA,rCB))
	dampM=-(vqCA-vqCB)*alpha*min(aCA*rCA**2,aCB*rCB**2)/2

	
      if (abs(dampn).le.0.8*abs(Fn)) then
         Fn=Fn+dampn
      else
         Fn=Fn+dsign(0.8*Fn,dampn)
      end if

      if (abs(dampt).le.0.8*abs(Ft)) then
         Ft=Ft+dampt
      else
         Ft=Ft+dsign(0.8*Ft,dampt)
      end if
      

	FxCA=-Fn*cosG+Ft*cosB
	FxCB=Fn*cosG-Ft*cosB
	FyCA=-Fn*sinG+Ft*sinB
	FyCB=Fn*sinG-Ft*sinB
	MCA=-FxCA*lAO*sinA+FyCA*lAO*cosA
	MCB=FxCB*lOB*sinD-FyCB*lOB*cosD
	flagPP=1
	
	
      if (abs(dampM).le.Fn*min(rCA,rCB)) then
         MCA=MCA+dampM
         MCB=MCB-dampM
      else
         MCA=MCA+dsign(Fn*min(rCA,rCB),dampM)
         MCB=MCB-dsign(Fn*min(rCA,rCB),dampM)
        
      end if

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
		


c		if ((FCoheM+FCoheN.gt.strgTensl).and.
c     $		(FCoheM+FCoheN.lt.2*strgTensl)) then
c			tempA=(2*strgTensl-FCoheM-FCoheN)/(FCoheM+FCoheN)*FCoheM
c			tempB=(2*strgTensl-FCoheM-FCoheN)/(FCoheM+FCoheN)*FCoheN
c			FCoheM=tempA
c			FCoheN=tempB
c		else if(FCoheM+FCoheN.gt.2*strgTensl) then
c			FCoheM=0
c			FCoheN=0
c			lAMBM=0
c			lANBN=0
c			flagPairCohe=0
c		end if


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


6033	end subroutine
