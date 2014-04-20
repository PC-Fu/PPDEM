	subroutine CircleWall(xP,yP,rP,mP,vxP,vyP,vqP,
     $x1,y1,x2,y2,Fx,Fy,M,E,tanTheta,flagCW,FtWP,fricRatio,dt,
     $xCon,yCon,dampingRatio,rollingDamp,vWall,tanNorm,aOver)
	
	implicit none

	double precision xP,yP,rP,mP,vxP,vyP,vqP,x1,y1,
     $	x2,y2,Fx,Fy,M,x3,y3,dist,Fn,Ft,xCon,yCon,fricRatio,tanNorm


	integer flagCW

	double precision cosA,sinA,cosC,sinC,cosB,sinB,sinCA,sinBA,
     $		cosD,sinD,cosE,sinE,cosF,sinF,cosAE

	double precision aOver,E,tantheta,lChord,lWall,lOB,vt,vn,FtWP,dt,
     $  alpha,beta,dampingRatio,dampn,dampt,dampM,vWall(2),
     $  vtWall,vnWall,tempTheta,bw,omega,rollingDamp
     
     
      tempTheta=tanTheta
	flagCW=0
	Fx=0
	Fy=0
	Fn=0
	Ft=0
	M=0


	call PtLine(xP,yP,x1,y1,x2,y2,x3,y3,dist)	


	if ((dist.ge.rP).or.(x3.gt.(max(x1,x2)+1e-12)).or.
     $	(x3.lt.(min(x1,x2)-1e-12)).or.(y3.gt.(max(y1,y2)+1e-12)).
     $	or.(y3.lt.(min(y1,y2)-1e-12))) then
		
		flagCW=0
		goto 8765
	end if


	xCon=x3
	yCon=y3

	lChord=2*sqrt(rP**2-dist**2)
	bw=lChord 
	aOver=lChord*(rP-dist)/2                          ! Rough estimate
	!!aOver=exp(3.0001*log(lChord/rP)-2.4832)*rP**2  !Relatively precise

	lWall=sqrt((x1-x2)**2+(y1-y2)**2)
	sinA=(y2-y1)/lWall
	cosA=(x2-x1)/lWall
	
	if (abs(sinA).gt.1e-5) then
      	tanNorm=-cosA/sinA
	else
	  tanNorm=1.e3
	end if

	lOB=sqrt((xP-x1)**2+(yP-y1)**2)
	cosC=(xP-x1)/lOB
	sinC=(yP-y1)/lOB
	sinCA=sinC*cosA-cosC*sinA
	
	if (sinCA.gt.0) then
	   cosD=-sinA
	   sinD=cosA
	else
	   cosD=sinA  
	   sinD=-cosA
	end if


	Fn=E*aOver*2   !/4/rP

	vtWall=vWall(1)*cosA+vWall(2)*sinA
	vnWall=vWall(1)*cosD+vWall(2)*sinD

      vn=vxP*cosD+vyP*sinD-vnWall
	vt=vxP*cosA+vyP*sinA+vqP*dist*dsign(1.,sinCA)-vtWall

	Ft=FtWP-vt*dt*bw*E/3*2  !/4/rP
	
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
		Ft=-Fn*tempTheta
	end if
      
     	fricRatio=min(1.0,abs(Ft/Fn)/max(tempTheta,0.001))
      FtWP=Ft

      
	
	Fx=Fn*cosD+Ft*cosA
	Fy=Fn*sinD+Ft*sinA
	M=Ft*dist*dsign(1.,sinCA)
	
	
	dampM=-vqP*rP*bw*(alpha*mP+beta*E*bw*2)/2*rollingDamp
	
	M=M+dampM
	
      if (abs(dampM).le.abs(Fn*bw/6*rollingDamp)) then
         M=M+dampM
      else
         M=M+dsign(abs(Fn*bw/6*rollingDamp),dampM)
      end if
	
	
	flagCW=1




8765	tanTheta=tanTheta
      end subroutine
