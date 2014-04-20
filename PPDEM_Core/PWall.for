	subroutine PWall(nVP,xVP,yVP,xP,yP,rP,mP,vxP,vyP,vqP,qP,qiPV,
     $rqPACE,xPACE,x1,y1,x2,y2,Fx,Fy,M,E,tanTheta,flagPW,FtWP,
     $fricRatio,dt,xcon,ycon,dampingRatio,rollingDamp,
     $vWall,tanNorm,aOver,iniOri,elong)
	
	implicit none

	double precision xVP(10),yVP(10),xP,yP,rP,mP,vxP,vyP,vqP,
     $	qP,qiPV(10),rqPACE(10,4),xPACE(10,2),
     $	x1,y1,x2,y2,Fx,Fy,M,x3,y3,dist,xtemp,ytemp,xCon,yCon,
     $	Fn,Ft,alpha,beta,dampt,dampn,dampM,fricRatio,vWall(2),
     $  dampingRatio,omega,rollingDamp,iniOri,elong

	double precision xP1,xP2,yP1,yP2

	integer nVP,iV,flagPW,nVinP,flagEE,flagLineCircle,iCI,iEdgeVinP(2)

	double precision xVinP(10),yVinP(10)

	double precision lOB,lOV,lWall,lCB,FtWP,dt,bw

	double precision cosA,sinA,cosC,sinC,sinCA,vt,vn,
     $		cosD,sinD,cosE,sinE,cosF,sinF,cosAE,cosFE,vtWall,vnWall

	double precision aOver,E,tanTheta,tempTheta
	
	double precision xCI(2,2),qCVA,qCVB,cosqCI,sinqCI,qCI,lCIACIB,CACI,
     $ 	tempqP,temp1,temp2,ltemp,aOverTemp,angTemp,SectorArea,tanNorm
     
!      double precision ori,cosEta,sinEta,cos2EtaP,sin2EtaP,li

	

      tempTheta=tanTheta
	flagPW=0
	Fx=0
	Fy=0   
	Fn=0
	Ft=0
	M=0

      !write (4789,'(2e20.12)') yP,vyP    
	call PtLine(xP,yP,x1,y1,x2,y2,x3,y3,dist)	

	if ((dist.gt.rP).or.(x3.gt.(max(x1,x2)+1e-12)).or.
     $	(x3.lt.(min(x1,x2)-1e-12)).or.(y3.gt.(max(y1,y2)+1e-12)).
     $	or.(y3.lt.(min(y1,y2)-1e-12))) then
		
		flagPW=0
		goto 7034
	end if

	nVinP=0

	!!!!!!!!  Search the edges whose boudning arcs intersect the Wall  !!!!!!!!!!!!!!
      !!!!!!!!  Stop when finding two intersecting points                !!!!!!!!!!!!!!
      
      iV=1
      do while ((iV.le.nVP).and.(nVinP.lt.2)) 
      
         call LineCircle(x1,y1,x2,y2,iV,xPACE,rqPACE,xCI,flagLineCircle)
         
         if (flagLineCircle.eq.1) then
         
            qCVA=Dmod(qP+qiPV(iV),6.283185307)
            qCVB=Dmod(qP+qiPV(iV+1),6.283185307)
            
            if (qCVA.lt.0) then
               qCVA=qCVA+6.283185307
            end if
            if (qCVB.lt.0) then
               qCVB=qCVB+6.283185307
            end if
            
            temp1=min(qCVA,qCVB)
            temp2=max(qCVA,qCVB)
            
            qCVA=temp1
            qCVB=temp2
            
            if((qCVB-qCVA).gt.3.1415926535) then
               qCVB=qCVB-6.283185307
            
               do iCI=1,2
               
                  cosqCI=(xCI(iCI,1)-xP)/sqrt((xCI(iCI,1)-xP)**2+
     $             (xCI(iCI,2)-yP)**2)
               
                  qCI=dacos(cosqCI)
                  
                  if ((xCI(iCI,2)-yP).lt.0) then
                     qCI=-qCI
                  end if
               
                  
                  if ( (qCI.gt.qCVB).and.(qCI.lt.qCVA)
     $            .and.(((xCI(iCI,1).lt.max(x1,x2)).and.
     $            (xCI(iCI,1).gt.min(x1,x2))).or.
     $            ((xCI(iCI,2).lt.max(y1,y2)).and.
     $              (xCI(iCI,2).gt.min(y1,y2))) )
     $              .and.(nVinP.lt.2) ) then
                     nVinP=nVinP+1
                     xVinP(nVinP)=xCI(iCI,1)
                     yVinP(nVinP)=xCI(iCi,2)
                     iEdgeVinP(nVinP)=iV
                  end if
                  
               end do  ! iCI=1,2
               
            else
            
               do iCI=1,2
               
                  cosqCI=(xCI(iCI,1)-xP)/sqrt((xCI(iCI,1)-xP)**2+
     $             (xCI(iCI,2)-yP)**2)
               
                  qCI=dacos(cosqCI)
                  
                  if ((xCI(iCI,2)-yP).lt.0)  then
                     qCI=6.283185307-qCI
                  end if
                     
                  if ( (qCI.lt.qCVB).and.(qCI.gt.qCVA)
     $            .and.(((xCI(iCI,1).lt.max(x1,x2)).and.
     $            (xCI(iCI,1).gt.min(x1,x2))).or.
     $            ((xCI(iCI,2).lt.max(y1,y2)).and.
     $              (xCI(iCI,2).gt.min(y1,y2))) ) 
     $              .and.(nVinP.lt.2) ) then
                     nVinP=nVinP+1
                     xVinP(nVinP)=xCI(iCI,1)
                     yVinP(nVinP)=xCI(iCi,2)
                     iEdgeVinP(nVinP)=iV
                  end if
                  
               end do  ! iCI=1,2

            end if
            
         end if
         iV=iV+1
      end do
      
      if (nVinP.ne.2) then
		goto 7034
	end if
	
	
	if (iEdgeVinP(1).eq.iEdgeVinP(2)) then
	! The wall intersect with only one arc (edge).
         lCIACIB=sqrt((xVinP(1)-xVinP(2))**2+(yVinP(1)-yVinP(2))**2)
	   aOver=SectorArea(lCIACIB,rqPACE(iEdgeVinP(1),3))
	   xCon=0.5*(xVinP(1)+xVinP(2))
         yCon=0.5*(yVinP(1)+yVinP(2))
    	   bw=sqrt((xVinP(1)-xVinP(2))**2+(yVinP(1)-yVinP(2))**2)
	
	else
	! The wall intersect with two arcs (edges).
	! Total area = the area of the triangle + the areas of the two circular sectors

         nVinP=3
         if (abs(iEdgeVinP(1)-iEdgeVinP(2)).gt.1) then
            
            xVinP(nVinP)=xVP(1)
            yVinP(nVinP)=yVP(1)
         else
            xVinP(nVinP)=xVP(max(iEdgeVinP(1),iEdgeVinP(2)))
            yVinP(nVinP)=yVP(max(iEdgeVinP(1),iEdgeVinP(2)))
	
	   end if
	   
         xCon=0.5*(xVinP(1)+xVinP(2))
         yCon=0.5*(yVinP(1)+yVinP(2))
    	   bw=sqrt((xVinP(1)-xVinP(2))**2+(yVinP(1)-yVinP(2))**2)
         
         aOverTemp=0
         
         do iCI=1,2
          lTemp=sqrt((xVinP(iCI)-xVinP(3))**2+(yVinP(iCI)-yVinP(3))**2)
          aOverTemp=aOverTemp+SectorArea(lTemp,rqPACE(iEdgeVinP(iCI),3))
         end do
         

	   call sortVinP(xVinp, yVinP, nVinP)

	   xVinP(nVinP+1)=xVinP(1)
	   yVinP(nVinP+1)=yVinP(1)
	   aOver=0
c	   xcon=0
c	   ycon=0

	   do iV=1,nVinP
   	
		   aOver=aOver+(xVinP(iV)*yVinP(iV+1)
     $		   -xVinP(iV+1)*yVinP(iV))
   		
c		   xcon=xcon+(xVinP(iV)+xVinP(iV+1))*(xVinp(iV)
c     $		   *yVinP(iV+1)-xVinp(iV+1)*yVinP(iV))
c		   ycon=ycon+(yVinP(iV)+yVinP(iV+1))*(xVinp(iV)
c     $		   *yVinP(iV+1)-xVinp(iV+1)*yVinP(iV))
	   end do
   	
	   aOver=0.5*aOver
	   if (aOver.le.1e-18*rP**2) then
		   goto 7034
	   end if
c	   xCon=xCon/6/aOver  
c	   yCon=yCon/6/aOver
	   
	   aOver=aOver+aOverTemp

	end if
	
	
	if (aOver.le.1e-12*rP**2) then
		goto 7034
	end if
	
	lOB=sqrt((xP-x1)**2+(yP-y1)**2)
	sinC=(yP-y1)/lOB
	cosC=(xP-x1)/lOB

	lWall=sqrt((x1-x2)**2+(y1-y2)**2)
	sinA=(y2-y1)/lWall
	cosA=(x2-x1)/lWall
	
	if (abs(sinA).gt.1e-5) then
      	tanNorm=-cosA/sinA
	else
	  tanNorm=1.e3
	end if

	
	sinCA=sinC*cosA-cosC*sinA
	
	
	if (sinCA.gt.0) then
	   cosF=-sinA
	   sinF=cosA
	else
	   cosF=sinA
	   sinF=-cosA
	end if


	lCB=sqrt((xP-xCon)**2+(yP-yCon)**2)
	cosD=(xP-xCon)/lCB
	sinD=(yP-yCon)/lCB 
	sinE=-cosD 
	cosE=sinD
	cosAE=cosA*cosE+sinA*sinE
	cosFE=cosF*cosE+sinF*sinE
	
!	ori=iniOri+qP
!	cosEta=cosF*cos(ori)+sinF*sin(ori)
!	sinEta=sinF*cos(ori)-cosF*sin(ori)
!	cos2EtaP=cosEta**2/(cosEta**2+elong**2*sinEta**2)
!	sin2EtaP=1-cos2EtaP
!	li=2*rP/elong*Dsqrt(elong**2*cos2EtaP+sin2EtaP)

 
	vtWall=vWall(1)*cosA+vWall(2)*sinA 
	vnWall=vWall(1)*cosF+vWall(2)*sinF
	
	Fn=E*aOver*2  !/li
	vt=vxP*cosA+vyP*sinA+vqP*lCB*cosAE-vtWall             !*dsign(1.,sinCA)
      vn=vxP*cosF+vyP*sinF+vqP*lCB*cosFE-vnWall             !*dsign(1.,sinCA)

	Ft=FtWP-vt*dt*bw*E/3*2 !/li
	
	if (vn.lt.0.0) then
	  Ft=Ft-sign(FtWP*E*bw*vn*dt*2/Fn,Ft)
	end if

	omega=sqrt(E*bw/mP*2)
	alpha=dampingRatio*omega
	beta=dampingRatio/omega
 
	
	dampn=-vn*(alpha*mP+beta*E*bw*2)
	dampt=-vt*(alpha*mP+beta*E*bw*2)
	
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

	if (Ft.ge.Fn*tempTheta) then
		Ft=Fn*tempTheta
	else if (Ft.le.(-Fn*tempTheta)) then
		Ft=-Fn*tempTheta	!tanTheta
	end if
	
	fricRatio=min(1.0,abs(Ft/Fn)/max(tempTheta,0.001))

	FtWP=Ft

 

	Fx=Fn*cosF+Ft*cosA
	Fy=Fn*sinF+Ft*sinA
	M=Fx*lCB*cosE+Fy*lCB*sinE
	
	
	dampM=-vqP*rP*bw*(alpha*mP+beta*E*bw*2)*rollingDamp
	
	
      if (abs(dampM).le.abs(Fn*bw*rollingDamp)) then
         M=M+dampM
      else
         M=M+dsign(abs(Fn*bw*rollingDamp),dampM)
      end if
	
	flagPW=1

	 
	
	 

7034	tanTheta=tanTheta
	end subroutine 