	subroutine CPCurve(rCA,rCB,xCA,xCB,yCA,yCB,qCA,qCB,massCA,massCB,
     $   qiVB,rqPACEB,xPACEB,vxCA,vxCB,vyCA,vyCB,vqCA,vqCB,
     $	nVPB,xPB,yPB,FxCA,FyCA,FxCB,FyCB,MCA,MCB,
     $	E,tanTheta,flagPC,FtPair,fricRatio,dt,
     $	dampingRatio,rollingDamp,xcon ,ycon,flagGlue,flagPairCohe,
     $	cosQiAM,sinQiAM,rMA,cosQiAN,sinQiAN,rNA,
     $	cosQiBM,sinQiBM,rMB,cosQiBN,sinQiBN,rNB,ECohe,xPtHL,
     $	strgFactor,strgTensl,tanNorm,aOver,iniOriB,elongB)


	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!  A is always the circle and B is always the polygon



	implicit none

	
	double precision rCA,rCB,xCA,xCB,yCA,yCB,qCA,qCB,vxCA,vxCB,vyCA,
     $	vyCB,vqCA,vqCB,xPB(10),yPB(10),FxCA,FyCA,FxCB,FyCB,MCA,MCB,
     $	E,tanTheta,alpha,beta,dampt,dampn,dampM,fricRatio,tanNorm,
     $  dampingRatio,omega,rollingDamp,iniOriB,elongB

	double precision aOver,Fn,Ft,massCA,massCB


	double precision cosA,sinA,cosB,sinB,cosD,sinD,cosE,sinE,cosF,sinF,
     $		cosBF,cosBE,cosG,sinG, sinBA,cosAE
		
		
	double precision vtCA,vtCB,vnCA,vnCB

	double precision dx,dy,dr,D,delta

	double precision xLCi,yLCi,xLC(5),yLC(5),xVinP(10),yVinP(10),
     $	xCon,yCon   ! xCon, yCon=coordinates of the contact point

	double precision lAO,lOB,bw

	integer iEdge,iVertex,iTemp,iV

	integer nVPB,mLC,flagPC,nVinP
	! nVPB=nuber of vertexes of Polygon B
	! nCL=nuber of cross points between polygon edges and the circle A
	! flagLC=1 if the polygon intersect the circle; flagLC=0 they don't intersect

	double precision FtPair,dt

	integer flagGlue,flagPairCohe

	double precision sinC,cosC,cosQAM,sinQAM,cosQAN,sinQAN,cosQiAM,
     $	sinQiAM,cosQiAN,sinQiAN,cosQBM,sinQBM,cosQBN,sinQBN,cosQiBM,
     $	sinQiBM,cosQiBN,sinQiBN,cosM,sinM,cosN,sinN,rMA,rNA,rMB,rNB

	double precision xAM(2),xAN(2),xBM(2),xBN(2),ECohe,FCoheN,FCoheM,
     $	lAMBM,lANBN,strgFactor,strgTensl

	integer nPtHL
	double precision xPtHL(2),tempA,tempB
	
	double precision qiVB(10),rqPACEB(10,4),xPACEB(10,2),qVB(10),
     $   x3y3(2,2),qCIA,qCIB,AsinCos,aOverTemp,SectorArea,lChord,
     $   qVEdgeB(10,2),vCn,vCt
	
	integer typeEGB(10),flagCC,flagArcB,iCI,iEdgeVinP(10)
	
!      double precision oriB,cosEtaB,sinEtaB,
!     $  cos2EtaPB,sin2EtaPB,liB



	xPB(nVPB+1)=xPB(1)
	yPB(nVPB+1)=yPB(1)

	Fn=0
	Ft=0

	FxCA=0
	FyCA=0
	MCA=0

	FxCB=0
	FyCB=0
	MCB=0

	xVinP=0
	yVinP=0


      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!  Edge sorting will NOT carried because the number of edges of one polygon is generally small
      
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!  Determine the type of edges of polygon B
      
      do iV=1,nVPB+1
      
         qVB(iV)=mod(qCB+qiVB(iV),6.283185307)
         if (qVB(iV).lt.0) then
            qVB(iV)=qVB(iV)+6.283185307
         end if
      
      end do  !iV=1,nVPB+1
      
      do iEdge=1,nVPB
         if (abs(qVB(iEdge+1)-qVB(iEdge)).gt.3.1415926535) then
            typeEGB(iEdge)=1
            qVEdgeB(iEdge,1)=max(qVB(iEdge+1),qVB(iEdge))-6.283185307
            qVEdgeB(iEdge,2)=min(qVB(iEdge+1),qVB(iEdge))
         else
            typeEGB(iEdge)=0
            qVEdgeB(iEdge,1)=min(qVB(iEdge+1),qVB(iEdge))
            qVEdgeB(iEdge,2)=max(qVB(iEdge+1),qVB(iEdge))
         end if
      end do

      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!! Find the two intersection points.
      
      iEdge=0
      nVinP=0
      
      do while ((iEdge.lt.nVPB).and.(nVinP.lt.2)) 
      
         iEdge=iEdge+1
         
         call InterCircle(xCA,yCA,rCA,xPACEB(iEdge,1),xPACEB(iEdge,2),
     $         rqPACEB(iEdge,3),flagCC,x3y3)
         if (flagCC.eq.1) then
         
            do iCI=1,2
            
               qCIB=ASinCos( (x3y3(iCI,1)-xCB)/
     $            sqrt((x3y3(iCI,1)-xCB)**2+(x3y3(iCI,2)-yCB)**2),
     $            x3y3(iCI,2)-yCB)
     
               if ((typeEGB(iEdge).eq.1).and.(qCIB.gt.3.1415926535))
     $            then
                  qCIB=qCIB-6.283185307
               end if
                  
               if ((qCIB.gt.qVEdgeB(iEdge,1)).and.
     $            (qCIB.lt.qVEdgeB(iEdge,2))) then
                  nVinP=nVinP+1
                  xVinP(nVinP)=x3y3(iCI,1)
                  yVinP(nVinP)=x3y3(iCI,2)
                  iEdgeVinP(nVinP)=iEdge
               end if   
            
            end do ! iCI=1,2
         
         end if      !(flagCC.eq.1)
      
      end do   !((iEdge.lt.nVPB).and.(nVinP.lt.2)) 
      
      
      if (nVinP.eq.2) then
      
         flagPC=1
         lChord=sqrt((xVinP(1)-xVinP(2))**2+(yVinP(1)-yVinP(2))**2 )
         bw=lChord
         
         aOverTemp=SectorArea(lChord,rCA)
     
         if (iEdgeVinP(1).eq.iEdgeVinP(2)) then
         
            aOverTemp=aOverTemp+SectorArea(lChord,
     $       rqPACEB(iEdgeVinP(1),3))
         
         else
            
            if (abs(iEdgeVinP(1)-iEdgeVinP(2)).eq.1) then
               nVinP=nVinP+1
               xVinP(nVinP)=xPB(max(iEdgeVinP(1),iEdgeVinP(2)))
               yVinP(nVinP)=yPB(max(iEdgeVinP(1),iEdgeVinP(2)))
            else if (abs(iEdgeVinP(1)-iEdgeVinP(2)).gt.1) then
               nVinP=nVinP+1
               xVinP(nVinP)=xPB(1)
               yVinP(nVinP)=yPB(1)
            end if
               
            aOverTemp=aOverTemp+SectorArea(sqrt
     $     ( (xVinP(1)-xVinP(nVinP))**2+(yVinP(1)-yVinP(nVinP))**2 ),
     $     rqPACEB(iEdgeVinP(1),3))
            
            aOverTemp=aOverTemp+SectorArea(sqrt
     $     ( (xVinP(2)-xVinP(nVinP))**2+(yVinP(2)-yVinP(nVinP))**2 ),
     $     rqPACEB(iEdgeVinP(2),3))
        
         end if

      else

 		FxCA=0
		FxCB=0
		FyCA=0
		FyCB=0
		MCA=0
		MCB=0
		FtPair=0
		flagPairCohe=0
		flagPC=0
		goto 1007
		
    
      end if
      
      if ((flagGlue.eq.1).and.(flagPC.eq.1)) then

		xAM(1)=xVinP(1)
		xAM(2)=yVinP(1)
		xAN(1)=xVinP(2)
		xAN(2)=yVinP(2)

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
	


    	xCon=(xVinP(1)+xVinP(2))/2
    	yCon=(yVinP(1)+yVinP(2))/2
    	aOver=0
    	

      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!! Calculate the area of the triangle if applicable
      
	if (nVinP.gt.2) then
	
	   call sortVinP(xVinp, yVinP, nVinP)

	   xVinP(nVinP+1)=xVinP(1)
	   yVinP(nVinP+1)=yVinP(1)
   	
	
	   do iV=1,nVinP
      	
		   aOver=aOver+(xVinP(iV)*yVinP(iV+1)
     $		   -xVinP(iV+1)*yVinP(iV))
      		
         end do
   	
   	end if
      


      aOver=0.5*aOver+aOverTemp

	if (aOver.le.1e-18*rCA**2) then 
		   goto 1007
      else
		   flagPC=1
	end if
	
	lAO=sqrt((xCon-xCA)**2+(yCon-yCA)**2)
	cosA=(xCon-xCA)/lAO
	sinA=(yCon-yCA)/lAO
	cosB=-sinA
	sinB=cosA
	cosG=sinB
	sinG=-cosB


	if (abs(sinB).gt.1e-5) then
      	tanNorm=-cosB/sinB
	else
	  tanNorm=1.e5
	end if


	lOB=sqrt((xCB-xCon)**2+(yCB-yCon)**2)
	cosD=(xCB-xCon)/lOB
	sinD=(yCB-yCon)/lOB
	cosE=sinD
	sinE=-cosD
	cosBE=cosE*cosB+sinE*sinB
	cosAE=cosE*cosA+sinE*sinA


	vtCA=vxCA*cosB+vyCA*sinB+vqCA*lAO
	vtCB=vxCB*cosB+vyCB*sinB+vqCB*lOB*cosBE


	vnCA=vxCA*cosA+vyCA*sinA
	vnCB=vxCB*cosA+vyCB*sinA+vqCB*lOB*cosAE
	
!	oriB=iniOriB+qCB
!	cosEtaB=cosG*cos(oriB)+sinG*sin(oriB)
!	sinEtaB=sinG*cos(oriB)-cosG*sin(oriB)
!	cos2EtaPB=cosEtaB**2/(cosEtaB**2+elongB**2*sinEtaB**2)
!	sin2EtaPB=1-cos2EtaPB
!	liB=2*rCB/elongB*Dsqrt(elongB**2*cos2EtaPB+sin2EtaPB)

      vCn=vnCA-vnCB
	vCt=vtCB-vtCA

	Fn=aOver*E !/(2*rCA+liB)						!*( 1+1/abs( 0.15*aOver- min(aCA,aCB) ) )
	Ft=FtPair+vCt*dt*bw*E/3 !/(2*rCA+liB)

	if (vCn.lt.0.0) then
	  Ft=Ft-sign(FtPair*E*bw*vCn*dt/Fn,Ft)
	end if

	if (flagGlue.eq.1) then
			strgTensl=strgFactor*Fn
	end if

	
	omega=sqrt(E*bw*(1/massCA+1/massCB))  !/(2*rCA+liB))
	alpha=dampingRatio*omega
	beta=dampingRatio/omega
	

	dampn=vCn*(alpha/(1/massCA+1/massCB)
     $	+beta*E*bw )!/(2*rCA+liB))
	dampt=vCt*(alpha/(1/massCA+1/massCB)
     $	+beta*E*bw) !/(2*rCA+liB))
	dampM=-(vqCA-vqCB)*min(rCA,rCB)*bw*(alpha/(1/massCA+1/massCB)+
     $	beta*E*bw)*rollingDamp  !/(2*rCA+liB)

      
c	Fn=Fn+dampn
c	Ft=Ft+dampt

      if (abs(dampn).le.0.6*abs(Fn)) then
         Fn=Fn+dampn
      else
         Fn=Fn+dsign(0.6*Fn,dampn)
      end if

      if (abs(dampt).le.0.6*abs(Ft)) then
         Ft=Ft+dampt
      else
         Ft=Ft+dsign(0.6*Ft,dampt)
      end if
      
	if (Ft.ge.Fn*tanTheta) then
		Ft=Fn*tanTheta
	else if (Ft.le.(-Fn*tanTheta)) then
		Ft=-Fn*tanTheta
	end if

	fricRatio=min(1.0,abs(Ft/Fn)/max(tanTheta,0.001))
	FtPair=Ft

	FxCA=-Fn*cosA+Ft*cosB
	FyCA=-Fn*sinA+Ft*sinB
	MCA=Ft*lAO

	FxCB=-FxCA
	FyCB=-FyCA
	MCB=FxCB*lOB*sinD-FyCB*lOB*cosD
	

      if (abs(dampM).le.abs(Fn*bw*rollingDamp)) then
         MCA=MCA+dampM
         MCB=MCB-dampM
      else
         MCA=MCA+dsign(abs(Fn*bw*rollingDamp),dampM)
         MCB=MCB-dsign(abs(Fn*bw*rollingDamp),dampM)        
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

		xPtHL(1)=(xAM(1)+xAN(1))/2
		xPtHL(2)=(xAM(2)+xAN(2))/2


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

