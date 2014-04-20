	subroutine CC(rCA,rCB,xCA,xCB,yCA,yCB,qCA,qCB,massCA,massCB,vxCA,vxCB,
     $				vyCA,vyCB,vqCA,vqCB,FxCA,FyCA,FxCB,FyCB,MCA,MCB,E,tanTheta,
     $				FtPair,fricRatio,dt,dampingRatio,rollingDamp,xCon,yCon,
     $				flagGlue,flagPairCohe,cosQiAM,sinQiAM,cosQiAN,sinQiAN,
     $				cosQiBM,sinQiBM,cosQiBN,sinQiBN,ECohe,xPtHL,
     $				strgFactor,strgTensl,tanNorm,aOver)

	implicit none


	double precision rCA,rCB,xCA,xCB,yCA,yCB,qCA,qCB,vxCA,vxCB,vyCA,
     $	vyCB,vqCA,vqCB,FxCA,FyCA,FxCB,FyCB,MCA,MCB,E,tanTheta,xCon,yCon,
     $	rACon,rBCon,fricRatio,tanNorm,bw

	! rACon, rBCon, distance from the contact point to the circle centers

	double precision aOver,d,lChord,Fn,Ft,FtPair,dt,massCA,massCB,
     $   alpha,beta,dampt,dampn,dampM,dampingRatio,omega,rollingDamp,
     $   vCn,vCt

	double precision cosA,sinA,cosB,sinB
		
	double precision vtCA,vtCB,vnCA,vnCB

	integer flagGlue,flagPairCohe

	double precision sinC,cosC,cosQAM,sinQAM,cosQAN,sinQAN,cosQiAM,
     $	sinQiAM,cosQiAN,sinQiAN,cosQBM,sinQBM,cosQBN,sinQBN,cosQiBM,
     $	sinQiBM,cosQiBN,sinQiBN,cosM,sinM,cosN,sinN,strgFactor,strgTensl

	double precision xAM(2),xAN(2),xBM(2),xBN(2),ECohe,FCoheN,FCoheM,
     $	lAMBM,lANBN


	integer nPtHL
	double precision xPtHL(2),tempA,tempB

	FxCA=0
	FxCB=0
	FyCA=0
	FyCB=0
	MCA=0
	MCB=0
	Fn=0
	Ft=0

	d=sqrt((xCA-xCB)**2+(yCA-yCB)**2)
	
	lChord=sqrt((-d+rCA-rCB)*(-d-rCA+rCB)*(-d+rCA+rCB)*(d+rCA+rCB))
	lChord=lChord/d
	bw=lChord
	aOver=(rCA+rCB-d)*lChord
	! We don't actually calculate the real overlap area.  This is an approximation to save time.

	if (aOver.le.1e-18*rCA**2) then
		   goto 1956
	end if

	
	cosA=(xCB-xCA)/d
	sinA=(yCB-yCA)/d
	
	if (abs(cosA).gt.1e-5) then
	  tanNorm=sinA/cosA
	else
	  tanNorm=1e3
	end if
	
	cosB=-sinA
	sinB=cosA

	vnCA=vxCA*cosA+vyCA*sinA
	vnCB=vxCB*cosA+vyCB*sinA

	vtCA=vxCA*cosB+vyCA*sinB+vqCA*rCA
	vtCB=vxCB*cosB+vyCB*sinB-vqCB*rCB

	xCon=xCA+(xCB-xCA)*rCA/(rCA+rCB)
	yCon=yCA+(yCB-yCA)*rCA/(rCA+rCB)

	rACon=d/(rCA+rCB)*rCA
	rBCon=d-rACon

	vCn=vnCA-vnCB
	vCt=vtCB-vtCA

	Fn=aOver*E   !*0.5/(rCA+rCB)
	Ft=FtPair+vCt*dt*bw*E/3.0 !*0.5/(rCA+rCB)
	
	if (vCn.lt.0.0) then
	  Ft=Ft-sign(FtPair*E*bw*vCn*dt/Fn,Ft)
	end if
	
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!! Below is the local contact damping.  It's sort of Rayleigh damping
	
	omega=sqrt(E*bw*(1/massCA+1/massCB))  !*0.5/(rCA+rCB))
	alpha=dampingRatio*omega
	beta=dampingRatio/omega
	
	
	dampn=vCn*(alpha/(1/massCA+1/massCB)
     $  	+beta*E*bw)  !*0.5/(rCA+rCB))
	dampt=vCt*(alpha/(1/massCA+1/massCB)
     $  	+beta*E*bw)  !*0.5/(rCA+rCB))
	dampM=-(vqCA-vqCB)*min(rCA,rCB)*bw*
     $	(alpha/(1/massCA+1/massCB)
     $  +beta*E*bw)*rollingDamp
     
     
     	Fn=Fn+dampn
	Ft=Ft+dampt

     
c      if (abs(dampn).le.0.6*abs(Fn)) then
c         Fn=Fn+dampn
c      else
c         Fn=Fn+dsign(0.6*Fn,dampn)
c      end if

c      if (abs(dampt).le.0.6*abs(Ft)) then
c         Ft=Ft+dampt
c      else
c         Ft=Ft+dsign(0.6*Ft,dampt)
c      end if
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !! Here we enforce the Coulomb friction condition
	if (Ft.ge.Fn*tanTheta) then
		Ft=Fn*tanTheta
		
	else if (Ft.le.(-Fn)*tanTheta) then
		Ft=-Fn*tanTheta
	end if
	
	fricRatio=min(1.0,abs(Ft/Fn)/max(tanTheta,0.001))


      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !! Apply the interaction force to the two particles.
	FtPair=Ft

	FxCA=-Fn*cosA+Ft*cosB
	FxCB=Fn*cosA-Ft*cosB
	FyCA=-Fn*sinA+Ft*sinB
	FyCB=Fn*sinA-Ft*sinB
	MCA=Ft*rACon
	MCB=Ft*rBCon
	

      if (abs(dampM).le.
     $ abs(Fn*bw*rollingDamp)) then
         MCA=MCA+dampM
         MCB=MCB-dampM
      else
         MCA=MCA+dsign(abs(Fn*bw*rollingDamp),dampM)
         MCB=MCB-dsign(abs(Fn*bw*rollingDamp),dampM)
      end if


      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!! Everything below was used to bond particles together, but this feature is not maintained anymore.
	if (flagPairCohe.eq.1) then


		cosQAM=Dcos(qCA)*cosQiAM-Dsin(qCA)*sinQiAM			!(QAM=qCA+QiAM)
		sinQAM=Dsin(qCA)*cosQiAM+Dcos(qCA)*sinQiAM			!(QAM=qCA+QiAM)
		cosQAN=Dcos(qCA)*cosQiAN-Dsin(qCA)*sinQiAN			!(QAN=qCA+QiAN)
		sinQAN=Dsin(qCA)*cosQiAN+Dcos(qCA)*sinQiAN			!(QAM=qCA+QiAN)
		cosQBM=Dcos(qCB)*cosQiBM-Dsin(qCB)*sinQiBM			
		sinQBM=Dsin(qCB)*cosQiBM+Dcos(qCB)*sinQiBM		
		cosQBN=Dcos(qCB)*cosQiBN-Dsin(qCB)*sinQiBN			
		sinQBN=Dsin(qCB)*cosQiBN+Dcos(qCB)*sinQiBN			
		xAM(1)=xCA+rCA*cosQAM
		xAM(2)=yCA+rCA*sinQAM
		xAN(1)=xCA+rCA*cosQAN
		xAN(2)=yCA+rCA*sinQAN
		xBM(1)=xCB+rCB*cosQBM
		xBM(2)=yCB+rCB*sinQBM
		xBN(1)=xCB+rCB*cosQBN
		xBN(2)=yCB+rCB*sinQBN
		
		xPtHL(1)=(xAM(1)+xAN(1))/2
		xPtHL(2)=(xAM(2)+xAN(2))/2
		
c		nPtHL=nPtHL+1
c		xPtHL(nPtHL,1)=xAM(1)
c		xPtHL(nPtHL,2)=xAM(2)
c		nPtHL=nPtHL+1
c		xPtHL(nPtHL,1)=xAN(1)
c		xPtHL(nPtHL,2)=xAN(2)
c		nPtHL=nPtHL+1
c		xPtHL(nPtHL,1)=xBM(1)
c		xPtHL(nPtHL,2)=xBM(2)
c		nPtHL=nPtHL+1
c		xPtHL(nPtHL,1)=xBN(1)
c		xPtHL(nPtHL,2)=xBN(2)


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
			MCA=MCA-FCoheM*cosM*rCA*sinQAM+FCoheM*sinM*rCA*cosQAM
			MCB=MCB+FCoheM*cosM*rCB*sinQBM-FCoheM*sinM*rCB*cosQBM
		end if

		if (lANBN.gt.1e-12) then
			cosN=(xBN(1)-xAN(1))/lANBN
			sinN=(xBN(2)-xAN(2))/lANBN
			FxCA=FxCA+FCoheN*cosN
			FyCA=FyCA+FCoheN*sinN
			FxCB=FxCB-FCoheN*cosN
			FyCB=FyCB-FCoheN*sinN
			MCA=MCA-FCoheN*cosN*rCA*sinQAN+FCoheN*sinN*rCA*cosQAN
			MCB=MCB+FCoheN*cosN*rCB*sinQBN-FCoheN*sinN*rCB*cosQBN
		end if
			
			


	end if		!(flagPairCohe.eq.1)




	
	if (flagGlue.eq.1) then
		flagPairCohe=1

		sinC=lChord/2./rCA
		cosC=sqrt(1-sinC**2)
		cosQAM=cosC*cosA-sinC*sinA    !(QAM=A+C)
		sinQAM=cosC*sinA+sinC*cosA
		cosQAN=cosC*cosA+sinC*sinA		!(QAN=A-C)
		sinQAN=sinA*cosC-cosA*sinC
		cosQiAM=cosQAM*Dcos(qCA)+sinQAM*Dsin(qCA)					!(QiAM=QAM-qCA)
		sinQiAM=sinQAM*Dcos(qCA)-cosQAM*Dsin(qCA)					!(QiAM=QAM-qCA)
		cosQiAN=cosQAN*Dcos(qCA)+sinQAN*Dsin(qCA)					!(QiAN=QAN-qCA)
		sinQiAN=sinQAN*Dcos(qCA)-cosQAN*Dsin(qCA)					!(QiAN=QAN-qCA)

		xAM(1)=xCA+rCA*cosQAM
		xAM(2)=yCA+rCA*sinQAM
		xAN(1)=xCA+rCA*cosQAN
		xAN(2)=yCA+rCA*sinQAN

		cosQBM=(xAM(1)-xCB)/rCB
		sinQBM=(xAM(2)-yCB)/rCB
		cosQBN=(xAN(1)-xCB)/rCB
		sinQBN=(xAN(2)-yCB)/rCB
		cosQiBM=cosQBM*Dcos(qCB)+sinQBM*Dsin(qCB)					!(QiBM=QBM-qCB)
		sinQiBM=sinQBM*Dcos(qCB)-cosQBM*Dsin(qCB)					!(QiBM=QBM-qCB)
		cosQiBN=cosQBN*Dcos(qCB)+sinQBN*Dsin(qCB)				
		sinQiBN=sinQBN*Dcos(qCB)-cosQBN*Dsin(qCB)				
		
		ECohe=lChord*E*0.5/(rCA+rCB)*2

		strgTensl=strgFactor*Fn
	end if


	!write (1000,'(100e13.5)') xCA,xCB,vxCA,vxCB,lChord,aover,FxCA,FxCB
1956	end subroutine

