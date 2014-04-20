	subroutine PPCurve(rCA,rCB,xCA,xCB,yCA,yCB,qCA,qCB,massCA,massCB,
     $   	qiVA,qiVB,rqPACEA,rqPACEB,xPACEA,xPACEB,vxCA,vxCB,
     $		vyCA,vyCB,vqCA,vqCB,nVPA,nVPB,xPA,xPB,yPA,yPB,FxCA,FyCA,
     $		FxCB,FyCB,MCA,MCB,E,tanTheta,flagPP,FtPair,fricRatio,dt,
     $		dampingRatio,rollingDamp,xcon,ycon,flagGlue,flagPairCohe,
     $		cosQiAM,sinQiAM,rMA,cosQiAN,sinQiAN,rNA,
     $		cosQiBM,sinQiBM,rMB,cosQiBN,sinQiBN,rNB,ECohe,xPtHL,
     $		strgFactor,strgTensl,tanNorm,aOver,
     $      iniOriA,iniOriB,elongA,elongB)


	implicit none

	
	double precision rCA,rCB,xCA,xCB,yCA,yCB,qCA,qCB,vxCA,vxCB,vyCA,
     $	vyCB,vqCA,vqCB,xPA(10),xPB(10),yPA(10),yPB(10),FxCA,FyCA,
     $	FxCB,FyCB,MCA,MCB,E,tanTheta,massCA,massCB,fricRatio,tanNorm,
     $  iniOriA,iniOriB,elongA,elongB

	double precision aOver,Fn,Ft

	double precision cosA,sinA,cosB,sinB,cosD,sinD,cosE,sinE,cosF,sinF,
     $	cosBF,cosBE,cosG,sinG, sinBA,cosGF,cosGE
		
	double precision vtCA,vtCB,vnCA,vnCB

	double precision dx,dy,dr,D,delta,dt,alpha,beta,dampt,dampn,dampM,
     $  dampingRatio,omega,rollingDamp,vCn,vCt

	double precision xLCi,yLCi,xLC(2),yLC(2),xVinC(10),yVinC(10),
     $	xCon,yCon   ! xCon, yCon=coordinates of the contact point

	double precision angC, lAO,lOB,bw

	integer iEdge,iVertex,jEdge,iV,iTemp,iPair

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
	double precision xPtHL(2)
	
	double precision qiVA(10),qiVB(10),rqPACEA(10,4),rqPACEB(10,4),
     $	xPACEA(10,2),xPACEB(10,2),qVA(10),qVB(10),
     $   qVEdgeA(10,2),qVEdgeB(10,2),x3y3(2,2),qCIA,qCIB,ASinCos,
     $   aOverTemp,SectorArea
     
      integer typeEGA(10),typeEGB(10),flagCC,flagArcA,flagArcB,iCI,
     $   iEdgeVinP(10),jEdgeVinP(10)
     
      integer EdgePair(nVPA*nVPB,2)
      double precision qEdgeA(nVPA),qEdgeB(nVPB),qAB,qBA,lAB,
     $   qPair(nVPA*nVPB)

!      double precision oriA,cosEtaA,sinEtaA,cos2EtaPA,
!     $  sin2EtaPA,liA,oriB,cosEtaB,sinEtaB,
!     $  cos2EtaPB,sin2EtaPB,liB


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

      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!  0. Sort edge pars of the two polygon according to the possibility of intersecting with the other one
      !!!  1. Find the two intersection points 
      !!!   
      !!!  2. Check wether the two points belong to the same edge
      !!!  3. Calculate the contact area.
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      !!! Determine the type of each edge.
      !!! Type 0 is normal.  Both vertexes use the range of 0 to 2Pi.
      !!! Type 1 means that the x axis (left or right) intersect with the edge and the lower vertex should have a q negative q value.
      
      do iV=1,nVPA+1
         qVA(iV)=mod(qCA+qiVA(iV),6.283185307)
         if (qVA(iV).lt.0) then
            qVA(iV)=qVA(iV)+6.283185307
         end if
      end do
      
      do iV=1,nVPB+1
         qVB(iV)=mod(qCB+qiVB(iV),6.283185307)
         if (qVB(iV).lt.0) then
            qVB(iV)=qVB(iV)+6.283185307
         end if
      end do
      
      do iEdge=1,nVPA
         if (abs(qVA(iEdge+1)-qVA(iEdge)).gt.3.1415926535) then
            typeEGA(iEdge)=1
            qVEdgeA(iEdge,1)=max(qVA(iEdge+1),qVA(iEdge))-6.283185307
            qVEdgeA(iEdge,2)=min(qVA(iEdge+1),qVA(iEdge))
         else
            typeEGA(iEdge)=0
            qVEdgeA(iEdge,1)=min(qVA(iEdge+1),qVA(iEdge))
            qVEdgeA(iEdge,2)=max(qVA(iEdge+1),qVA(iEdge))
         end if
      end do
           
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

      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!! Sort edge pairs
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      lAB=dsqrt((xCA-xCB)**2+(yCA-yCB)**2)
      qAB=ASinCos((xCB-xCA)/lAB,(yCB-yCA))
      qBA=ASinCos((xCA-xCB)/lAB,(yCA-yCB))
      
      ! qEdgeA is the angle from the line connecting the two poligons to the line towards the center of this edge
      do iEdge=1,nVPA
         
         if (abs(qVA(iEdge)-qVA(iEdge+1)).gt.3.1415926535) then
            qEdgeA(iEdge)=abs(mod((qVA(iEdge)+qVA(iEdge+1)-6.283185307)
     $      /2-qAB,6.283185307))
         else
            qEdgeA(iEdge)=abs(mod((qVA(iEdge)+qVA(iEdge+1))/2-qAB,
     $      6.283185307))
         end if
         
         if (qEdgeA(iEdge).gt.3.1415926535) then
            qEdgeA(iEdge)=6.283185307-qEdgeA(iEdge)
         end if
      end do
      
      do iEdge=1,nVPB
         if (abs(qVB(iEdge)-qVB(iEdge+1)).gt.3.1415926535) then
            qEdgeB(iEdge)=abs(mod((qVB(iEdge)+qVB(iEdge+1)-6.283185307)
     $      /2-qBA,6.283185307))
         else
            qEdgeB(iEdge)=abs(mod((qVB(iEdge)+qVB(iEdge+1))/2-qBA,
     $      6.283185307))
         end if
         
         
         if (qEdgeB(iEdge).gt.3.1415926535) then
            qEdgeB(iEdge)=6.283185307-qEdgeB(iEdge)
         end if
      end do
      
      iTemp=0
      do iEdge=1,nVPA
         do jEdge=1,nVPB
            iTemp=iTemp+1
            EdgePair(iTemp,1)=iEdge
            EdgePair(iTemp,2)=jEdge
            qPair(iTemp)=qEdgeA(iEdge)+qEdgeB(jEdge)
         end do
      end do
      
      call SortQEdge(nVPA,nVPB,EdgePair,qPair)
      !!!!! Find the two intersection points.
      
      
      iEdge=0
      nVinP=0
      iPair=0     
      do while ((iPair.lt.nVPA*nVPB).and.(nVinP.lt.2))
         iPair=iPair+1
         iEdge=EdgePair(iPair,1)
         jEdge=EdgePair(iPair,2)
            
            call InterCircle(xPACEA(iEdge,1), xPACEA(iEdge,2),
     $         rqPACEA(iEdge,3), xPACEB(jEdge,1), xPACEB(jEdge,2), 
     $         rqPACEB(jEdge,3),flagCC,x3y3)   
            
            if (flagCC.eq.1) then
               
               do iCI=1,2
               
                  qCIA=ASinCos( (x3y3(iCI,1)-xCA)/
     $               sqrt((x3y3(iCI,1)-xCA)**2+(x3y3(iCI,2)-yCA)**2),
     $               x3y3(iCI,2)-yCA)
                  qCIB=ASinCos( (x3y3(iCI,1)-xCB)/
     $               sqrt((x3y3(iCI,1)-xCB)**2+(x3y3(iCI,2)-yCB)**2),
     $               x3y3(iCI,2)-yCB)
     
                  if ((typeEGA(iEdge).eq.1).and.(qCIA.gt.3.1415926535))
     $               then
                     qCIA=qCIA-6.283185307
                  end if
                  
                  if ((qCIA.gt.qVEdgeA(iEdge,1)).and.
     $             (qCIA.lt.qVEdgeA(iEdge,2))) then
                     flagArcA=1
                  else
                     flagArcA=0
                  end if   

                  if ((typeEGB(jEdge).eq.1).and.(qCIB.gt.3.1415926535))
     $               then
                     qCIB=qCIB-6.283185307
                  end if
                  
                  if ((qCIB.gt.qVEdgeB(jEdge,1)).and.
     $             (qCIB.lt.qVEdgeB(jEdge,2))) then
                     flagArcB=1
                  else
                     flagArcB=0
                  end if   
                  
                  
                  if ((flagArcA.eq.1).and.(flagArcB.eq.1)) then
                     nVinP=nVinp+1
                     xVinP(nVinP)=x3y3(iCI,1)
                     yVinP(nVinP)=x3y3(iCI,2)
                     iEdgeVinP(nVinP)=iEdge
                     jEdgeVinP(nVinP)=jEdge
                  end if
                     
               end do  ! iCI=1,2
            
                  
            
            end if ! 
         
      
      end do
      
      aOverTemp=0
      
      if (nVinP.eq.2) then
      
         if (iEdgeVinP(1).eq.iEdgeVinP(2)) then
            aOverTemp=aOverTemp+SectorArea
     $       (sqrt( (xVinP(1)-xVinP(2))**2+(yVinP(1)-yVinP(2))**2 ),
     $       rqPACEA(iEdgeVinP(1),3))
         
         else
            
            if (abs(iEdgeVinP(1)-iEdgeVinP(2)).eq.1) then
               nVinP=nVinP+1
               xVinP(nVinP)=xPA(max(iEdgeVinP(1),iEdgeVinP(2)))
               yVinP(nVinP)=yPA(max(iEdgeVinP(1),iEdgeVinP(2)))
            else if (abs(iEdgeVinP(1)-iEdgeVinP(2)).gt.1) then
               nVinP=nVinP+1
               xVinP(nVinP)=xPA(1)
               yVinP(nVinP)=yPA(1)
            end if
               
            aOverTemp=aOverTemp+SectorArea(sqrt
     $     ( (xVinP(1)-xVinP(nVinP))**2+(yVinP(1)-yVinP(nVinP))**2 ),
     $     rqPACEA(iEdgeVinP(1),3))
            
            aOverTemp=aOverTemp+SectorArea(sqrt
     $     ( (xVinP(2)-xVinP(nVinP))**2+(yVinP(2)-yVinP(nVinP))**2 ),
     $     rqPACEA(iEdgeVinP(2),3))
        
         end if
         
    
    
         if (jEdgeVinP(1).eq.jEdgeVinP(2)) then
            
            aOverTemp=aOverTemp+SectorArea
     $       (sqrt( (xVinP(1)-xVinP(2))**2+(yVinP(1)-yVinP(2))**2 ),
     $       rqPACEB(jEdgeVinP(1),3))
         
         else
         
            if (abs(jEdgeVinP(1)-jEdgeVinP(2)).eq.1) then
               nVinP=nVinP+1
               xVinP(nVinP)=xPB(max(jEdgeVinP(1),jEdgeVinP(2)))
               yVinP(nVinP)=yPB(max(jEdgeVinP(1),jEdgeVinP(2)))
            else if (abs(jEdgeVinP(1)-jEdgeVinP(2)).gt.1) then
               nVinP=nVinP+1
               xVinP(nVinP)=xPB(1)
               yVinP(nVinP)=yPB(1)
            end if
               
            aOverTemp=aOverTemp+SectorArea(sqrt(
     $         (xVinP(1)-xVinP(nVinP))**2+(yVinP(1)-yVinP(nVinP))**2 ),
     $         rqPACEB(jEdgeVinP(1),3))
     
            aOverTemp=aOverTemp+SectorArea(sqrt(
     $         (xVinP(2)-xVinP(nVinP))**2+(yVinP(2)-yVinP(nVinP))**2 ),
     $         rqPACEB(jEdgeVinP(2),3))

         end if  !(jEdgeVinP(1).eq.jEdgeVinP(2))
      else

 		FxCA=0
		FxCB=0
		FyCA=0
		FyCB=0
		MCA=0
		MCB=0
		FtPair=0
		flagPP=0
		goto 6033
    
      end if
      




    	xCon=(xVinP(1)+xVinP(2))/2
    	yCon=(yVinP(1)+yVinP(2))/2
    	bw=sqrt((xVinP(1)-xVinP(2))**2+(yVinP(1)-yVinP(2))**2)
    	
    	cosB=(xVinP(1)-xVinP(2))/
     $	sqrt((xVinP(1)-xVinP(2))**2+(yVinP(1)-yVinP(2))**2)
    	sinB=(yVinP(1)-yVinP(2))/
     $	sqrt((xVinP(1)-xVinP(2))**2+(yVinP(1)-yVinP(2))**2)

    	aOver=0
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
		   goto 6033
      else
		   flagPP=1
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
      	tanNorm=-cosB/sinB
	else
	  tanNorm=1.e5
	end if


	cosD=(xCB-xCon)/lOB
	sinD=(yCB-yCon)/lOB
	cosE=-sinD   ! E=D-pi()/2 
	sinE=cosD

	cosG=sinB
	sinG=-cosB

	cosBF=cosB*cosF+sinB*sinF
	cosBE=cosB*cosE+sinB*sinE
	cosGF=cosG*cosF+sinG*sinF
	cosGE=cosG*cosE+sinG*sinE

	
	vtCA=vxCA*cosB+vyCA*sinB+vqCA*lAO*cosBF
	vtCB=vxCB*cosB+vyCB*sinB-vqCB*lOB*cosBE

	vnCA=vxCA*cosG+vyCA*sinG+vqCA*lAO*cosGF
	vnCB=vxCB*cosG+vyCB*sinG-vqCB*lOB*cosGE
	
!	oriA=iniOriA+qCA
!	oriB=iniOriB+qCB
!	cosEtaA=cosG*cos(oriA)+sinG*sin(oriA)
!	sinEtaA=sinG*cos(oriA)-cosG*sin(oriA)
!	cosEtaB=cosG*cos(oriB)+sinG*sin(oriB)
!	sinEtaB=sinG*cos(oriB)-cosG*sin(oriB)
!	cos2EtaPA=cosEtaA**2/(cosEtaA**2+elongA**2*sinEtaA**2)
!	sin2EtaPA=1-cos2EtaPA
!	cos2EtaPB=cosEtaB**2/(cosEtaB**2+elongB**2*sinEtaB**2)
!	sin2EtaPB=1-cos2EtaPB
!	liA=2*rCA/elongA*Dsqrt(elongA**2*cos2EtaPA+sin2EtaPA)
!	liB=2*rCB/elongB*Dsqrt(elongB**2*cos2EtaPB+sin2EtaPB)

	 
	vCn=vnCA-vnCB
	vCt=vtCB-vtCA

	Fn=aOver*E  !/(liA+liB)					!*( 1+1/abs( 0.15*aOver- min(aCA,aCB) ) )
	Ft=FtPair+vCt*dt*bw*E/3  !/(liA+liB)
	
	if (vCn.lt.0.0) then
	  Ft=Ft-sign(FtPair*E*bw*vCn*dt/Fn,Ft)
	end if
	

	if (flagGlue.eq.1) then
	
		strgTensl=strgFactor*Fn

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
 
		
		ECohe=((xAM(1)-xAN(1))**2+(xAM(2)-xAN(2))**2)
     $		*E*StrgFactor*2

		flagPairCohe=1


	end if 


	
	omega=sqrt(E*bw*(1/massCA+1/massCB)) !/(liA+liB)
	alpha=dampingRatio*omega
	beta=dampingRatio/omega
	
	dampn=vCn*(alpha/(1/massCA+1/massCB)+beta*E*bw)  !/(liA+liB)
	dampt=vCt*(alpha/(1/massCA+1/massCB)+beta*E*bw)  !/(liA+liB)
	dampM=-(vqCA-vqCB)*min(rCA,rCB)*bw*
     $	(alpha/(1/massCA+1/massCB)+beta*E*bw)*rollingDamp

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
      
	if (Ft.ge.Fn*tanTheta) then
		Ft=Fn*tanTheta
	else if (Ft.le.(-Fn*tanTheta)) then
		Ft=-Fn*tanTheta
	end if
	
	fricRatio=min(1.0,abs(Ft/Fn)/max(tanTheta,0.001))

	FtPair=Ft

	FxCA=-Fn*cosG+Ft*cosB
	FxCB=Fn*cosG-Ft*cosB
	FyCA=-Fn*sinG+Ft*sinB
	FyCB=Fn*sinG-Ft*sinB
	MCA=-FxCA*lAO*sinA+FyCA*lAO*cosA
	MCB=FxCB*lOB*sinD-FyCB*lOB*cosD
	flagPP=1
	


      if (abs(dampM).le.
     $ abs(Fn*bw*rollingDamp)) then
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
