	subroutine CalOMP(nEle,nActEle,xEle,yEle,qEle,nVertex,xVertex,yVertex,
     $	qVertex,rVertex,rEle,boundEle,MIEle,vxEle,vyEle,vqEle,
     $	nWall,x1Wall,x2Wall,y1Wall,y2Wall,nInc,dt,E,density,tanTheta,
     $	xGravity,gXgY,monitor,globdamp,rotDamp,FtPair, FtWP,dampingRatio,
     $	rollingDamp,flagDebug,xCon,yCon,FxCon,FyCon,fricRatio,tanNorm,
     $  FRGB,rCon,nCon,nPCon, pPlot,flagConBoun,pairCon,
     $	nPair,pair,nWallFrd,lWallFrd,FxC,FyC,FMC,flagGlue,
     $	flagPairCohe,dMotionWall,actWall,
     $	actEle,xCursor,rAnchor,cosQAc,sinQAc,flagDrag,
     $	cosQiAM,sinQiAM,cosQiAN,sinQiAN,cosQiBM,sinQiBM,cosQiBN,sinQiBN,
     $	rMA,rNA,rMB,rNB,ECohe,nPtHL,xPtHL,strgTensl,numThreads,
     $   alwNEleFrd,mGravEle,mInertEle,MIInertEle,zoomscale,rqCE,xCE,
     $   hSector,limitAll,vWall,aOverAll, vol, 
     $  flagLoadMode, intLoadPara, realLoadPara,iCurStep,eleOut,
     $  FWall,iniFWall,FxWall,FyWall,FMWall,Fx,Fy,FM,iniOri,elong,
     $  flagOutInied,factorSlow,hThinLayer,flagThinLayer,iDirecCyc, 
     $  flagSpecialLoad, qMax, cDisp, nLinks, iEleLink, l0Link, 
     $  kLinkPos, kLinkNeg, linkDampingRatio)
	implicit none

	integer nEle,nActEle,nWall,nCon,nPCon,nGridX,nGridY,numThreads,
     $	alwNEleFrd
	integer nVertex(nEle)
	integer iEle,iVertex,iWall,iIter,nInc,jEle,omp_get_thread_num,
     $	itemp,iPara,eleOut(0:1000)

	double precision dt,factorSlow

	double precision xEle(nEle),yEle(nEle),qEle(nEle),xVertex(nEle,10),
     $	yVertex(nEle,10),qVertex(nEle,10),rVertex(nEle,10),rEle(nEle),
     $	boundEle(nEle,4),iniOri(nEle),elong(nEle)

	double precision MIEle(nEle),mGravEle(nEle),
     $  mInertEle(nEle),MIInertEle(nEle)

	double precision vxEle(nEle),vyEle(nEle),vqEle(nEle)

	double precision lWallEff(4),x1Wall(nWall),x2Wall(nWall),
     $	y1Wall(nWall),y2Wall(nWall),dxWall,dMotionWall(4),
     $    pvx1Wall,pvx2Wall,pvy1Wall,pvy2Wall,FxCA,FyCA,
     $   FxCB,FyCB,MCA,MCB,vWall(nWall,2),mWall,pvVWall(nWall,2)
      ! lWallEff = Effective length of the walls
     

	double precision E,density,tanTheta(2),xGravity(2),gXgY(2),globdamp,
     $	rotDamp, dampingRatio,rollingDamp,m,MI,monitor(5),
     $  maxVEle,maxFCon,moni1,moni2,moni3


	double precision xPA(10),xPB(10),yPA(10),yPB(10),qPA(10),qPB(10)  ! Vertex coordinates of Polygon A and Polygon B
	
	integer nVPA,nVPB,j

	integer flagPC,flagPP,flagPW,flagCW,flagDebug,flagConBoun(nEle*10),
     $	pairCon(nEle*10,2)
	!!!! flagConBoun=0 is this contact is an element-element contact; =1 if it is a stress boundary; =2 if it is a wall boundary

	double precision PtDist
	
	double precision Fx(nEle),Fy(nEle),FM(nEle),
     $  FxWall(nEle), FyWall(nEle),FMWall(nEle)

	double precision xCon(nEle*10),yCon(nEle*10),FxCon(nEle*10),
     $	FyCon(nEle*10),xConTemp,yConTemp,rCon(nEle*10),
     $   fricRatio(nEle*10),pvFricRatio,tanNorm(nEle*10),pvtanNorm,
     $   pPlot(nEle*10,4)

	integer nPair, pair(nEle*alwNEleFrd,2), iPair,iWallFrd,FRGB(nEle*10,3),
     $	tempRGB(3)
	
	integer nWallFrd,lWallFrd(nWall*nEle,2),actWall,actEle

	double precision FxC(nEle),FyC(nEle),FMC(nELe)   ! External forces due to confinement

	integer flagGlue,flagPairCohe(nEle*alwNEleFrd),flagDrag,pvflagGlue,
     $	flagLoadMode,flagOutInied
	

	double precision FDrag(3),xCursor(2),rAnchor,cosQAc,sinQAc,zoomscale
     $   ,limitAll(4)

	double precision 
     $	cosQiAM(nEle*11),sinQiAM(nEle*11),
     $	cosQiAN(nEle*11),sinQiAN(nEle*11),
     $	cosQiBM(nEle*11),sinQiBM(nEle*11),
     $   cosQiBN(nEle*11),sinQiBN(nEle*11),
     $	rMA(nEle*11),rNA(nEle*11),
     $   rMB(nEle*11),rNB(nEle*11),
     $	ECohe(nEle*11),strgFactor,
     $   strgTensl(nEle*11)
     
c	double precision 
c     $	cosQiAM(1),sinQiAM(1),
c     $	cosQiAN(1),sinQiAN(1),
c     $	cosQiBM(1),sinQiBM(1),
c     $   cosQiBN(1),sinQiBN(1),
c     $	rMA(1),rNA(1),
c     $   rMB(1),rNB(1),
c     $	ECohe(1),strgFactor,
c     $   strgTensl(1)
     
	double precision FtPair(nEle*alwNEleFrd), FtWP(nWall,nEle)

	integer nPtHL
	double precision xPtHL(nEle*10,2),pvXPtHL(2)

	double precision FWall(nWall,2),pY,iniFWall(nWall,2)  ! iniFWall is from confinement
	
	double precision OMP_GET_WTIME,time111(200,0:10),time222
	double precision pvE,pvTanTheta,pvDt,pvAlpha,pvBeta,pvDamping,
     $   pvStrgFactor,pvgXgY(2),pvXGravity(2),pvGlobDamp,pvRotDamp,
     $   pvLimitAll(4),pvRollDamp
     
      double precision rqCE(nEle,10,4),xCE(nEle,10,2),
     $   hSector(nEle),rqPACEA(10,4),xPACEA(10,2),rqPACEB(10,4),
     $   xPACEB(10,2)
     
      double precision aOver,aOverAll,pvAOver,aOver1,aOver2,vol  ! 1 for particle-particle contact; 2 for particle-wall contact
	
	integer intLoadPara(0:100000,0:8),iCurStep(4)
      double precision realLoadPara(0:100000,8)
      integer iLoadWall(8),iLoadXY(8),iLoadSign(8),iWallLoad(8)  
      
      double precision hThinLayer
      integer flagThinLayer(2) 
      
      data  iLoadWall /1,1,2,2,3,3,4,4/,iLoadXY /2,1,2,1,1,2,1,2/,
     $      iLoadSign /1,1,-1,-1,1,1,-1,-1/,
     $      iWallLoad /2,1,4,3,5,6,7,8/
     
      integer iDirecCyc,flagUDCyc, flagConstP, flagSpecialLoad
      integer stepCount, exCount
      double precision maxVWall, maxAccWall,stressUDCyc(2),
     $ qLimit,v0,v1, pMean, stsV0, qMax, cDisp
     
     	integer nLinks, iLink, iEleLink(nLinks,2)
      double precision l0Link(nLinks),kLinkPos(nLinks),kLinkNeg(nLinks)
      double precision FLink(2),linkDampingRatio


	maxVWall=(y1Wall(2)-y1Wall(1))*0.002/1000.0/dt/nInc
	maxAccWall=maxVWall/dt/nInc/20
	flagUDCyc=0
	qLimit=qMax
      stepCount=0
      exCount=0
	
      flagConstP=0
      ! flagConstP=1 is based on stress on side particles; =2 if based on stress on walls
      pMean=realLoadPara(iCurStep(2),5)
      
      if (flagSpecialLoad.eq.0) then
        flagConstP=0
        flagUDCyc=0
      else if (flagSpecialLoad.eq.1) then
        flagUDCyc=1
        flagConstP=0
      else if (flagSpecialLoad.eq.2) then
        flagConstP=1
        flagUDCyc=0
      else if (flagSpecialLoad.eq.3) then
        flagConstP=2
        flagUDCyc=0
      end if
        
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
      !!!  These variables are either only used in the last time step or constant throughout all time steps, 
      !!!   so they are initialted here, but not in each time step
	monitor=0.
      xCon=0
      yCon=0 
	FxCon=0  
	FyCon=0
	nCon=nPCon
	flagConBoun=1
	StrgFactor=4
      mWall=vol/nActEle**0.5*density  ! Assume all walls have the same mass
      aOverAll=0
      aOver1=0
      aOver2=0
	xCon=pPlot(:,1)
	yCon=pPlot(:,2)
	FxCon=pPlot(:,3)
	FyCon=pPlot(:,4)
	rCon=0
	fricRatio=0
	tanNorm=0
	moni1=0
	moni2=0
	moni3=0
	nPtHL=0
	xPtHL=0
	FDrag=0

	
	lWallEff(1)=sqrt(vol *
     $ (limitAll(2)-limitAll(1)) / (limitAll(4)-limitAll(3)) )
      lWallEff(2)=lWallEff(1)
      lWallEff(3)=vol/lWallEff(1)
      lWallEff(4)=lWallEff(3)

	!!!!!!!!!!
	!! For undrained cyclic only
	if ((flagUDCyc.eq.1).and.(intLoadPara(iCurStep(2),1).eq.1)) then
	  intLoadPara(iCurStep(2),2)=2
        intLoadPara(iCurStep(2),3)=1
        intLoadPara(iCurStep(2),4)=2
        intLoadPara(iCurStep(2),5)=1
        intLoadPara(iCurStep(2),6)=2
        intLoadPara(iCurStep(2),7)=1
        intLoadPara(iCurStep(2),8)=2
        open (unit = 1234, file = "v.txt")
        write (1234,*) intLoadPara(iCurStep(2),1), cDisp, 
     $  realLoadPara(iCurStep(2),1), iDirecCyc, iCurStep(2)
	  v0=realLoadPara(iCurStep(2),1)/nInc/dt
	  v1=v0+maxAccWall*nInc*dt*iDirecCyc
	  if (v1.gt.cDisp/nInc/dt) then
	      v1=cDisp/nInc/dt
	  else if(v1.lt.-cDisp/nInc/dt) then
	      v1=-cDisp/nInc/dt
	  end if
	  realLoadPara(iCurStep(2),1)=v1*nInc*dt
        realLoadPara(iCurStep(2),2)=0
        realLoadPara(iCurStep(2),3)= realLoadPara(iCurStep(2),1)
        realLoadPara(iCurStep(2),4)=0
        realLoadPara(iCurStep(2),5)= -realLoadPara(iCurStep(2),1)
     $      /(y1Wall(2)-y1Wall(1))*(x1Wall(4)-x1Wall(3))  
        realLoadPara(iCurStep(2),6)=0
        realLoadPara(iCurStep(2),7)=realLoadPara(iCurStep(2),5)
        realLoadPara(iCurStep(2),8)=0
        write (1234,*) intLoadPara(iCurStep(2),1), cDisp, 
     $  realLoadPara(iCurStep(2),1), iDirecCyc, iCurStep(2)
	end if
	      

	do iIter=1,nInc
	
c      time111(iiter,0)=omp_get_Wtime()
      
	call omp_set_num_threads (1)

	  Fx=0
	  Fy=0
	  FM=0

		FxWall=0
		FyWall=0


c      time111(iiter,1)=omp_get_Wtime()


		if (iIter.gt.1) then
			flagGlue=0
		end if

      !!!!!!!!!!!!!!!!!!! Manual wall movement by button clicking  !!!!!!!!!!!
      !!! Manual wall movement should be avoided during batched loading !!!!!!
      
	x1Wall(actWall+1)=x1Wall(actWall+1)+dMotionWall(1)/nInc
	y1Wall(actWall+1)=y1Wall(actWall+1)+dMotionWall(2)/nInc
	x2Wall(actWall+1)=x2Wall(actWall+1)+dMotionWall(3)/nInc
	y2Wall(actWall+1)=y2Wall(actWall+1)+dMotionWall(4)/nInc

      vWall(actWall+1,1)=vWall(actWall+1,1)+dMotionWall(1)/nInc/dt
      vWall(actWall+1,2)=vWall(actWall+1,2)+dMotionWall(2)/nInc/dt
      
      
      
      
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!! For batch loading mode, the sequence of the four walls are: bottom, top, left, right
	! Bottom wall  
	


	
	if ((intLoadPara(iCurStep(2),1).eq.1).or.
     $  (intLoadPara(iCurStep(2),1).eq.4)) then
	  
	      y1Wall(1)=y1Wall(1)
     $	      +realLoadPara(iCurStep(2),1)/nInc/factorSlow
	      y2Wall(1)=y2Wall(1)
     $	      +realLoadPara(iCurStep(2),1)/nInc/factorSlow                          
            vWall(1,2)=realLoadPara(iCurStep(2),1)/factorSlow/nInc/dt

      end if
     
	if (intLoadPara(iCurStep(2),2).eq.1) then
	  
	      x1Wall(1)=x1Wall(1)
     $	      +realLoadPara(iCurStep(2),2)/nInc/factorSlow
	      x2Wall(1)=x2Wall(1)
     $	      +realLoadPara(iCurStep(2),2)/nInc/factorSlow
            vWall(1,1)=realLoadPara(iCurStep(2),2)/factorSlow/nInc/dt

      end if
     
      ! Top Wall
	if ((intLoadPara(iCurStep(2),3).eq.1).or.
     $	(intLoadPara(iCurStep(2),3).eq.4)) then
	  
	      y1Wall(2)=y1Wall(2)
     $	      -realLoadPara(iCurStep(2),3)/nInc/factorSlow
	      y2Wall(2)=y2Wall(2)
     $	      -realLoadPara(iCurStep(2),3)/nInc/factorSlow
            vWall(2,2)=-realLoadPara(iCurStep(2),3)/factorSlow/nInc/dt

      end if
     
	if (intLoadPara(iCurStep(2),4).eq.1) then
	  
	      x1Wall(2)=x1Wall(2)
     $	      -realLoadPara(iCurStep(2),4)/nInc/factorSlow
	      x2Wall(2)=x2Wall(2)
     $	      -realLoadPara(iCurStep(2),4)/nInc/factorSlow
            vWall(2,1)=-realLoadPara(iCurStep(2),4)/factorSlow/nInc/dt

      end if
      
      ! Left Wall
	if (intLoadPara(iCurStep(2),5).eq.1) then
	  
	      x1Wall(3)=x1Wall(3)
     $	      +realLoadPara(iCurStep(2),5)/nInc/factorSlow
	      x2Wall(3)=x2Wall(3)
     $	      +realLoadPara(iCurStep(2),5)/nInc/factorSlow
            vWall(3,1)=realLoadPara(iCurStep(2),5)/factorSlow/nInc/dt

      end if
     
	if (intLoadPara(iCurStep(2),6).eq.1) then
	  
	      y1Wall(3)=y1Wall(3)
     $	      +realLoadPara(iCurStep(2),6)/nInc/factorSlow
	      y2Wall(3)=y2Wall(3)
     $	      +realLoadPara(iCurStep(2),6)/nInc/factorSlow
            vWall(3,2)=realLoadPara(iCurStep(2),6)/factorSlow/nInc/dt

      end if

      ! Right Wall
	if (intLoadPara(iCurStep(2),7).eq.1) then
	  
	      x1Wall(4)=x1Wall(4)
     $	      -realLoadPara(iCurStep(2),7)/nInc/factorSlow
	      x2Wall(4)=x2Wall(4)
     $	      -realLoadPara(iCurStep(2),7)/nInc/factorSlow
            vWall(4,1)=-realLoadPara(iCurStep(2),7)/factorSlow/nInc/dt

      end if
     
	if (intLoadPara(iCurStep(2),8).eq.1) then
	  
	      y1Wall(4)=y1Wall(4)
     $	      -realLoadPara(iCurStep(2),8)/nInc/factorSlow
	      y2Wall(4)=y2Wall(4)
     $	      -realLoadPara(iCurStep(2),8)/nInc/factorSlow
            vWall(4,2)=-realLoadPara(iCurStep(2),8)/factorSlow/nInc/dt

      end if
	





      if (iIter.eq.nInc) then
	    call omp_set_num_threads (1)
	else
	    call omp_set_num_threads (numThreads)
	end if

	call BoundBox(nEle,nActEle,xEle,yEle,rEle,nVertex,xVertex,yVertex,
     $	boundEle,hSector)
     
     

	
	
c      time111(iiter,2)=omp_get_Wtime()

      !$omp parallel do private (iEle,jEle,FxCA,FxCB,FyCA,FyCB,
     $ MCA,MCB,xPA,yPA,qPA,qPB,xPB,yPB,flagPP,flagPC,iVertex,iTemp,
     $ xConTemp,yConTemp,pvE,pvtanTheta,pvDt,pvDamping,
     $ pvflagGlue,pvStrgFactor,rqPACEA,rqPACEB,xPACEA,xPACEB,
     $ pvFricRatio,pvtanNorm,pvXPtHL,pvAOver,pvRollDamp) 
     $ reduction (+: aOver1)



cc     $      reduction (+:Fx,Fy,FM)  ! To avoid stack-overflow error.  Memory confilicts for Fx Fy FM should be rare.

	do iPair=1,nPair
      	pvE=E
      	pvtanTheta=tanTheta(1)
      	pvDt=dt
      	pvDamping=dampingRatio
      	pvRollDamp=rollingdamp
      	pvflagGlue=flagGlue
      	pvStrgFactor=strgFactor
	   
		iEle=pair(iPair,1)
		jEle=pair(iPair,2)
		


			if ((PtDist(xEle(iEle),yEle(iEle),xEle(jEle),yEle(jEle))
     $			.lt.(rEle(iEle)+rEle(jEle))**2).and.
     $		(max(boundELe(iEle,1),boundELe(jEle,1)).lt.
     $					min(boundELe(iEle,2),boundELe(jEle,2))).and.
     $		(max(boundELe(iEle,3),boundELe(jEle,3)).lt.
     $					min(boundELe(iEle,4),boundELe(jEle,4))) )						! Bounding boxes overlap
     $		then
				
				if ((nVertex(iEle).eq.0).and.(nVertex(jEle).eq.0)) then

					!!!!!!!!!!!!!!! Circle to Circle Contact   !!!!!!!!!!!!!!!!!!!!!!
					
					
					call CC(rEle(iEle),rEle(jEle),xEle(iEle),xEle(jEle),yEle(iEle),
     $					yEle(jEle),qEle(iEle),qEle(jEle),
     $               mInertEle(iEle),mInertEle(jEle),
     $ 					vxEle(iEle),vxEle(jEle),vyEle(iEle),vyEle(jEle),vqEle(iEle),
     $					vqEle(jEle),FxCA,FyCA,FxCB,FyCB,MCA,MCB,pvE,
     $					pvTanTheta,FtPair(iPair),pvFricRatio,pvDt,pvDamping,
     $					pvRollDamp,xConTemp,yConTemp,pvFlagGlue,flagPairCohe(iPair),
     $					cosQiAM(iPair),sinQiAM(iPair),cosQiAN(iPair),sinQiAN(iPair),
     $					cosQiBM(iPair),sinQiBM(iPair),cosQiBN(iPair),sinQiBN(iPair),
     $					ECohe(iPair),pvXPtHL,pvStrgFactor,strgTensl(iPair),pvtanNorm,
     $                  pvAOver)
c					call CC(rEle(iEle),rEle(jEle),xEle(iEle),xEle(jEle),yEle(iEle),
c     $					yEle(jEle),qEle(iEle),qEle(jEle),
c     $               mInertEle(iEle),mInertEle(jEle),
c     $ 					vxEle(iEle),vxEle(jEle),vyEle(iEle),vyEle(jEle),vqEle(iEle),
c     $					vqEle(jEle),FxCA,FyCA,FxCB,FyCB,MCA,MCB,pvE,
c     $					pvTanTheta,FtPair(iPair),pvFricRatio,pvDt,pvDamping,
c     $					pvRollDamp,xConTemp,yConTemp,pvFlagGlue,flagPairCohe(iPair),
c     $					cosQiAM(1),sinQiAM(1),cosQiAN(1),sinQiAN(1),
c     $					cosQiBM(1),sinQiBM(1),cosQiBN(1),sinQiBN(1),
c     $					ECohe(1),pvXPtHL,pvStrgFactor,strgTensl(1),pvtanNorm,
c     $                  pvAOver)
     				


					Fx(iEle)=Fx(iEle)+FxCA
					Fy(iEle)=Fy(iEle)+FyCA
					Fx(jEle)=Fx(jEle)+FxCB
					Fy(jEle)=Fy(jEle)+FyCB
					FM(iEle)=FM(iEle)+MCA
					FM(jEle)=FM(jEle)+MCB
					

				if (iIter.eq.nInc) then
						nCon=ncon+1
						FxCon(nCon)=FxCA
						FyCon(nCon)=FyCA
						xCon(nCon)=xConTemp
						yCon(nCon)=yConTemp
						rCon(nCon)=sqrt(rEle(jEle)*rEle(iEle))
						call HSV2RGB(pvFricRatio,FRGB(nCon,:))
						fricRatio(nCon)=pvFricRatio
						tanNorm(nCon)=pvtanNorm
						flagConBoun(nCon)=0
						pairCon(nCon,1)=iEle
						pairCon(nCon,2)=jEle
						
						aOver1=aOver1+pvAOver
						
                     if (flagPairCohe(iPair).eq.1) then
                        nPtHL=nPtHL+1
                        xPtHL(nPtHL,1)=pvXPtHL(1)
                        xPtHL(nPtHL,2)=pvXPtHL(2)
                     end if						
					
				end if

				
				else if ((nVertex(iEle).gt.0).and.(nVertex(jEle).gt.0)) then

					!!!!!!!!!!!!!!! Polygon to Polygon Contact !!!!!!!!!!!!!!!!!!!!!!

						do iVertex=1,nVertex(iEle)+1
							xPA(iVertex)=xVertex(iEle,iVertex)
							yPA(iVertex)=yVertex(iEle,iVertex)
							qPA(iVertex)=qVertex(iEle,iVertex)
					      do iTemp=1,4
					         rqPACEA(iVertex,iTemp)=rqCE(iEle,iVertex,iTemp)
					      end do
					      xPACEA(iVertex,1)=xCE(iEle,iVertex,1)
					      xPACEA(iVertex,2)=xCE(iEle,iVertex,2)

						end do
						
						do iVertex=1,nVertex(jEle)+1
							xPB(iVertex)=xVertex(jEle,iVertex)
							yPB(iVertex)=yVertex(jEle,iVertex)
							qPB(iVertex)=qVertex(jEle,iVertex)
					      do iTemp=1,4
					         rqPACEB(iVertex,iTemp)=rqCE(jEle,iVertex,iTemp)
					      end do
					      xPACEB(iVertex,1)=xCE(jEle,iVertex,1)
					      xPACEB(iVertex,2)=xCE(jEle,iVertex,2)

						end do
						
       !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
       !!!!!!!!!  Only for thin shear !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
       !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
       
                if (flagThinLayer(1).eq.1) then
                    if ( (yEle(iEle).lt.(y1Wall(1)+hThinLayer)).or.
     $                  (yEle(jEle).lt.(y1Wall(1)+hThinLayer)).or.  
     $                  (yEle(iEle).gt.(y1Wall(2)-hThinLayer)).or.   
     $                  (yEle(jEle).gt.(y1Wall(2)-hThinLayer)) ) then
            
                            pvTanTheta=0.005
            
                    else
                            pvTanTheta=tanTheta(1)
                    end if 
                end if       

				call PPCurve(rEle(iEle),rEle(jEle),xEle(iEle),xEle(jEle),yEle(iEle),
     $				yEle(jEle),qEle(iEle),qEle(jEle),
     $            mInertEle(iEle),mInertEle(jEle),
     $				qPA,qPB,rqPACEA,rqPACEB,xPACEA,xPACEB,vxEle(iEle),
     $            vxEle(jEle),vyEle(iEle),vyEle(jEle),vqEle(iEle),
     $				vqEle(jEle),nVertex(iEle),nVertex(jEle),xPA,xPB,yPA,yPB,FxCA,
     $				FyCA,FxCB,FyCB,MCA,MCB,pvE,pvTanTheta,flagPP,FtPair(iPair),
     $				pvFricRatio,pvDt,pvDamping,pvRollDamp,xConTemp,yConTemp,
     $				pvFlagGlue,flagPairCohe(iPair),
     $				cosQiAM(iPair),sinQiAM(iPair),rMA(iPair),
     $				cosQiAN(iPair),sinQiAN(iPair),rNA(iPair),
     $				cosQiBM(iPair),sinQiBM(iPair),rMB(iPair),
     $				cosQiBN(iPair),sinQiBN(iPair),rNB(iPair),
     $				ECohe(iPair),pvXPtHL,
     $				pvStrgFactor,strgTensl(iPair),pvtanNorm,
     $              pvAOver,iniOri(iEle),iniOri(jEle),
     $              elong(iEle),elong(jEle))



				if (flagPP.eq.1) then
					
					Fx(iEle)=Fx(iEle)+FxCA
					Fy(iEle)=Fy(iEle)+FyCA
					Fx(jEle)=Fx(jEle)+FxCB
					Fy(jEle)=Fy(jEle)+FyCB
					FM(iEle)=FM(iEle)+MCA
					FM(jEle)=FM(jEle)+MCB
 				
				else
				
					flagPairCohe(iPair)=0
					FtPair(iPair)=0
				
				end if
				
				if ((iIter.eq.nInc).and.(flagPP.eq.1)) then
						nCon=nCon+1
						FxCon(nCon)=FxCA
						FyCon(nCon)=FyCA
						xCon(nCon)=xConTemp
						yCon(nCon)=yConTemp
						rCon(nCon)=sqrt(rEle(jEle)*rEle(iEle))
						call HSV2RGB(pvFricRatio,FRGB(nCon,:))
						fricRatio(nCon)=pvFricRatio
						tanNorm(nCon)=pvtanNorm
						flagConBoun(nCon)=0
                        pairCon(nCon,1)=iEle
                        pairCon(nCon,2)=jEle
						
						aOver1=aOver1+pvAOver
						
                     if (flagPairCohe(iPair).eq.1) then
                        nPtHL=nPtHL+1
                        xPtHL(nPtHL,1)=pvXPtHL(1)
                        xPtHL(nPtHL,2)=pvXPtHL(2)
                     end if						

				end if
					

				else 
			
					!!!!!!!!!!!!!!!! Polygon to Circle Contact !!!!!!!!!!!!!!!!!!!!!!
					!  A is always the circle and B is always the polygon
					if (nVertex(iEle).eq.0) then ! iEle is the circle

						do iVertex=1,nVertex(jEle)+1
							xPB(iVertex)=xVertex(jEle,iVertex)
							yPB(iVertex)=yVertex(jEle,iVertex)
							qPB(iVertex)=qVertex(jEle,iVertex)
					      do iTemp=1,4
					         rqPACEB(iVertex,iTemp)=rqCE(jEle,iVertex,iTemp)
					      end do
					      xPACEB(iVertex,1)=xCE(jEle,iVertex,1)
					      xPACEB(iVertex,2)=xCE(jEle,iVertex,2)
						end do


					   call CPCurve(rEle(iEle),rEle(jEle),xEle(iEle),xEle(jEle),
     $				   yEle(iEle),yEle(jEle),qEle(iEle),qEle(jEle),
     $               mInertEle(iEle),mInertEle(jEle),
     $               qPB,rqPACEB,xPACEB,vxEle(iEle),vxEle(jEle),
     $				  vyEle(iEle),vyEle(jEle),vqEle(iEle),
     $					vqEle(jEle),nVertex(jEle),xPB,yPB,FxCA,FyCA,FxCB,FyCB,
     $					MCA,MCB,pvE,pvTanTheta,flagPC,FtPair(iPair),pvFricRatio,pvDt,
     $					pvDamping,pvRollDamp,xConTemp,yConTemp,
     $					pvFlagGlue,flagPairCohe(iPair),
     $					cosQiAM(iPair),sinQiAM(iPair),rMA(iPair),
     $					cosQiAN(iPair),sinQiAN(iPair),rNA(iPair),
     $					cosQiBM(iPair),sinQiBM(iPair),rMB(iPair),
     $					cosQiBN(iPair),sinQiBN(iPair),rNB(iPair),
     $					ECohe(iPair),pvXPtHL,
     $					pvStrgFactor,strgTensl(iPair),pvtanNorm,
     $                  pvAOver,iniOri(jEle),elong(jEle))


					if (flagPC.eq.1) then

						Fx(iEle)=Fx(iEle)+FxCA
						Fy(iEle)=Fy(iEle)+FyCA
						Fx(jEle)=Fx(jEle)+FxCB
						Fy(jEle)=Fy(jEle)+FyCB
						FM(iEle)=FM(iEle)+MCA
						FM(jEle)=FM(jEle)+MCB
						
						
				   else
				   	flagPairCohe(iPair)=0
				   	FtPair(iPair)=0

				   end if

				    if ((iIter.eq.nInc).and.(flagPC.eq.1)) then
					    nCon=ncon+1
					    FxCon(nCon)=FxCA
					    FyCon(nCon)=FyCA
					    xCon(nCon)=xConTemp
					    yCon(nCon)=yConTemp
				       rCon(nCon)=sqrt(rEle(jEle)*rEle(iEle))
				       call HSV2RGB(pvFricRatio,FRGB(nCon,:))
                        fricRatio(nCon)=pvFricRatio
                        tanNorm(nCon)=pvtanNorm
                        flagConBoun(nCon)=0
                        pairCon(nCon,1)=iEle
                        pairCon(nCon,2)=jEle
                        

                    aOver1=aOver1+pvAOver

                        if (flagPairCohe(iPair).eq.1) then
                           nPtHL=nPtHL+1
                           xPtHL(nPtHL,1)=pvXPtHL(1)
                           xPtHL(nPtHL,2)=pvXPtHL(2)
                        end if						
				    end if



					else  ! iEle is the polygon and jEle is the circle
					
						do iVertex=1,nVertex(iEle)+1
							xPB(iVertex)=xVertex(iEle,iVertex)
							yPB(iVertex)=yVertex(iEle,iVertex)
							qPB(iVertex)=qVertex(iEle,iVertex)
					      do iTemp=1,4
					         rqPACEB(iVertex,iTemp)=rqCE(iEle,iVertex,iTemp)
					      end do
					      xPACEB(iVertex,1)=xCE(iEle,iVertex,1)
					      xPACEB(iVertex,2)=xCE(iEle,iVertex,2) 
						end do
						
						

					call CPCurve(rEle(jEle),rEle(iEle),xEle(jEle),xEle(iEle),
     $				   yEle(jEle),yEle(iEle),qEle(jEle),qEle(iEle),
     $				   mInertEle(jEle),mInertEle(iEle),qPB,rqPACEB,xPACEB,
     $               vxEle(jEle),vxEle(iEle),vyEle(jEle),vyEle(iEle),
     $					vqEle(jEle),vqEle(iEle),nVertex(iEle),xPB,yPB,FxCA,FyCA,
     $					FxCB,FyCB,MCA,MCB,pvE,pvTanTheta,flagPC,FtPair(iPair),
     $					pvFricRatio,pvDt,pvDamping,pvRollDamp,xConTemp,yConTemp,
     $					pvFlagGlue,flagPairCohe(iPair),
     $					cosQiAM(1),sinQiAM(1),rMA(1),
     $					cosQiAN(1),sinQiAN(1),rNA(1),
     $					cosQiBM(1),sinQiBM(1),rMB(1),
     $					cosQiBN(1),sinQiBN(1),rNB(1),
     $					ECohe(1),pvXPtHL,
     $					pvStrgFactor,strgTensl(iPair),pvtanNorm,
     $                  pvAOver,iniOri(iEle),elong(iEle))



					if (flagPC.eq.1) then
							Fx(iEle)=Fx(iEle)+FxCB
							Fy(iEle)=Fy(iEle)+FyCB
							Fx(jEle)=Fx(jEle)+FxCA
							Fy(jEle)=Fy(jEle)+FyCA
							FM(iEle)=FM(iEle)+MCB
							FM(jEle)=FM(jEle)+MCA
							
							
				   else
				   	flagPairCohe(iPair)=0
	   				FtPair(iPair)=0
					end if

						if ((iIter.eq.nInc).and.(flagPC.eq.1)) then
						   nCon=ncon+1
						   FxCon(nCon)=FxCA
						   FyCon(nCon)=FyCA
						   xCon(nCon)=xConTemp
						   yCon(nCon)=yConTemp
						   rCon(nCon)=sqrt(rEle(jEle)*rEle(iEle))
						   call HSV2RGB(pvFricRatio,FRGB(nCon,:))
						   fricRatio(nCon)=pvFricRatio
						   tanNorm(nCon)=pvtanNorm
						   flagConBoun(nCon)=0
                           pairCon(nCon,1)=jEle
                           pairCon(nCon,2)=iEle
						   
     						   aOver1=aOver1+pvAOver
						   
						   
                        if (flagPairCohe(iPair).eq.1) then
                           nPtHL=nPtHL+1
                           xPtHL(nPtHL,1)=pvXPtHL(1)
                           xPtHL(nPtHL,2)=pvXPtHL(2)
                        end if						
						end if


					end if  ! Which of iEle and jEle is the polygon and which one is the circle.
			
				
				end if  ! check circle-circle or circle-polygon or polygon-polygon



		else ! the bounding circles don't overlap

		   flagPairCohe(iPair)=0
	   	FtPair(iPair)=0

		end if ! Check whether bouding circles overlap


	
	end do ! iPair

c      time111(iiter,3)=omp_get_Wtime()

      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!! Temporary, for constant p test only
      if ((flagConstP.eq.2).and.(intLoadPara(iCurStep(2),1).eq.1)) then
        iniFWall(3,1)=(pMean*2-(FWall(2,2)-FWall(1,2))/2.0/
     $      (x1Wall(4)-x1Wall(3)))*(y1Wall(2)-y1Wall(1))
        iniFWall(4,1)=-iniFWall(3,1)
      end if
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!! Links !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      do iLink = 1, nLinks
        iEle = iEleLink(iLink, 1)
        jEle = iEleLink(iLink, 2)
        Call LinkForce(xEle(iEle), yEle(iEle), xEle(jEle), yEle(jEle),
     $         l0Link(iLink), kLinkPos(iLink), kLinkNeg(iLink),
     $         FLink,  mInertEle(iEle), mInertEle(jEle), vxEle(iEle), 
     $         vxEle(jEle), vyEle(iEle), vyEle(jEle),
     $         linkDampingRatio)    
     
        Fx(iEle) = Fx(iEle) + FLink(1)
        Fy(iEle) = Fy(iEle) + FLink(2)
        Fx(jEle) = Fx(jEle) - FLink(1)
        Fy(jEle) = Fy(jEle) - FLink(2)
      end do
      
      
      
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!! Walls !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      FxWall=0
      FyWall=0
      FMWall=0
      FWall=iniFWall
      
      
c       call omp_set_num_threads (1)   !  Overhead for paralellization was very high.  Couldn't figure out why.  Use one thread only for this loop.
c      time111(iiter,4)=omp_get_Wtime()

c      !$omp parallel do private (iEle,iWall,FxCA,FyCA,MCA,
c     $   xPA,yPA,qPA,flagCW,flagPW,iVertex,xConTemp,yConTemp,
c     $   pvE,pvTanTheta,pvDt,pvDamping,pvRollDamp,iTemp,
c     $   pvx1Wall,pvx2Wall,pvy1Wall,pvy2Wall,rqPACEA,xPACEA,pvFricRatio,
c     $   tempRGB,pvVWall,pvtanNorm,pvAOver)
c     $   reduction (+:aOver2) 
c     $   reduction (+:FxWall,FyWall,FMWall,FWall)   !!Be careful.  FWall gets initial value from CONFINEMENT.  If use paralle, need to use a temporary array.
      
      
	do iWallFrd=1,nWallFrd
	
	      iWall=lWallFrd(iWallFrd,1)
			iEle=lWallFrd(iWallFrd,2)
   	      pvE=E
   	      pvtanTheta=tanTheta(2)
   	      pvDt=dt
   	      pvDamping=dampingRatio
   	      pvRollDamp=rollingDamp
   	      pvVWall=VWall
   	      
   	      pvx1Wall=x1Wall(iWall)
   	      pvy1Wall=y1Wall(iWall)
   	      pvx2Wall=x2Wall(iWall)
   	      pvy2Wall=y2Wall(iWall)
			
		
			if (nVertex(iEle).eq.0) then

				call CircleWall(xEle(iEle),yEle(iEle),rEle(iEle),mInertEle(iEle),
     $				vxEle(iEle),vyEle(iEle),vqEle(iEle),
     $				pvx1Wall,pvy1Wall,pvx2Wall,pvy2Wall,FxCA,FyCA,MCA,
     $				pvE,pvTanTheta,flagCW,FtWP(iWall,iEle),pvFricRatio,pvDt,
     $				xConTemp,yConTemp,pvDamping,pvRollDamp,
     $              pvVWall(iWall,:),pvtanNorm,pvAOver)

				if (flagCW.eq.1) then 
				
					FxWall(iEle)=FxWall(iEle)+FxCA
					FyWall(iEle)=FyWall(iEle)+FyCA
					FMWall(iEle)=FMWall(iEle)+MCA
					FWall(iWall,1)=FWall(iWall,1)-FxCA
					FWall(iWall,2)=FWall(iWall,2)-FyCA


				end if

				if ((iIter.eq.nInc).and.(flagCW.eq.1)) then
						nCon=ncon+1
						FxCon(nCon)=FxCA
						FyCon(nCon)=FyCA
						xCon(nCon)=xConTemp
						yCon(nCon)=yConTemp
						rCon(nCon)=rEle(iEle)
						call HSV2RGB(pvFricRatio,FRGB(nCon,:))
						fricRatio(nCon)=pvFricRatio
						tanNorm(nCon)=pvtanNorm
						flagConBoun(nCon)=2
						pairCon(nCon,1)=iEle
						pairCon(nCon,2)=iWall
						
						aOver2=aOver2+pvAOver
						!FRGB(nCon,1)=tempRGB(1)
						!FRGB(nCon,2)=tempRGB(2)
						!FRGB(nCon,3)=tempRGB(3)
				end if
				
				
				


			else !polygon

				do ivertex=1,nVertex(iEle)+1
					xPA(iVertex)=xVertex(iEle,iVertex)
					yPA(iVertex)=yVertex(iEle,iVertex)
					qPA(iVertex)=qVertex(iEle,iVertex)
					do iTemp=1,4
					   rqPACEA(iVertex,iTemp)=rqCE(iEle,iVertex,iTemp)
					end do
					xPACEA(iVertex,1)=xCE(iEle,iVertex,1)
					xPACEA(iVertex,2)=xCE(iEle,iVertex,2)
					   
				end do
				
				call PWall(nVertex(iEle),xPA,yPA,xEle(iEle),yEle(iEle),
     $			rEle(iEle),mInertEle(iEle),vxEle(iEle),vyEle(iEle),vqEle(iEle),
     $         qEle(iEle),qPA,rqPACEA,xPACEA,
     $			pvx1Wall,pvy1Wall,pvx2Wall,pvy2Wall,FxCA,FyCA,MCA,
     $			pvE,pvTanTheta,flagPW,FtWP(iWall,iEle),pvFricRatio,pvDt,
     $			xConTemp,yConTemp,pvDamping,pvRollDamp,pvVWall(iWall,:),
     $          pvtanNorm,pvAOver,iniOri(iEle),elong(iEle))

				if (flagPW.eq.1) then
				
				
					FxWall(iEle)=FxWall(iEle)+FxCA
					FyWall(iEle)=FyWall(iEle)+FyCA
					FMWall(iEle)=FMWall(iEle)+MCA
					FWall(iWall,1)=FWall(iWall,1)-FxCA
					FWall(iWall,2)=FWall(iWall,2)-FyCA


				end if


				if ((iIter.eq.nInc).and.(flagPW.eq.1)) then
						nCon=ncon+1
						FxCon(nCon)=FxCA
						FyCon(nCon)=FyCA
						xCon(nCon)=xConTemp
						yCon(nCon)=yConTemp
						rCon(nCon)=rEle(iEle)
						call HSV2RGB(pvFricRatio,FRGB(nCon,:))
						fricRatio(nCon)=pvFricRatio
						tanNorm(nCon)=pvtanNorm
						flagConBoun(nCon)=2
						pairCon(nCon,1)=iEle
						pairCon(nCon,2)=iWall
						aOver2=aOver2+pvAOver
						!FRGB(nCon,1)=tempRGB(1)
						!FRGB(nCon,2)=tempRGB(2)
						!FRGB(nCon,3)=tempRGB(3)
				end if
				
	
			end if		

	end do ! iWallFrd
	
c      time111(iiter,5)=omp_get_Wtime()



      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!! For batch loading mode, load mode 3, add forces to the walls  !!!!!!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
c      do iPara=1,8
c        
c        if (intLoadPara(iCurStep(2),iPara).eq.3) then
c        
c            FWall(iLoadWall(iPara),iLoadXY(iPara))=
c     $        FWall(iLoadWall(iPara),iLoadXY(iPara))+
c     $	      +realLoadPara(iCurStep(2),iPara)
c     $        *lWallEff(iLoadWall(iPara))*iLoadSign(iPara)

c        end if
      
c      end do
      
	
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!!! Calculate the motions of the walls if the walls are in servo control !!!!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      do iPara=1,8
        
        if (intLoadPara(iCurStep(2),iPara).eq.3) then
        
            if (iLoadXY(iPara).eq.1) then
            
            dxWall=x1Wall(iLoadWall(iPara))
            Call Translation(x1Wall(iLoadWall(iPara)),
     $			vWall(iLoadWall(iPara),1),FWall(iLoadWall(iPara),1),
     $          mWall,dt,Globdamp)
            dxWall=x1Wall(iLoadWall(iPara))-dxWall
            x2Wall(iLoadWall(iPara))=x2Wall(iLoadWall(iPara))+dxWall
            
            else if (iLoadXY(iPara).eq.2) then
            
            dxWall=y1Wall(iLoadWall(iPara))
            Call Translation(y1Wall(iLoadWall(iPara)),
     $			vWall(iLoadWall(iPara),2),FWall(iLoadWall(iPara),2),
     $          mWall,dt,Globdamp)
            dxWall=y1Wall(iLoadWall(iPara))-dxWall
            y2Wall(iLoadWall(iPara))=y2Wall(iLoadWall(iPara))+dxWall
            
            end if        

        end if
        
        
        if (intLoadPara(iCurStep(2),iPara).ne.3) then
            
            vWall(iLoadWall(iPara),iLoadXY(iPara))=0   ! Unless in loading mode 3 (stress control via wall), the walls should not have any velocity at the end of this call
        
        end if

      
      end do
      


      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!!!!  If the active element is dragged by the mouse  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      

	if ((iIter.eq.1).and.(flagDrag.eq.1)) then  !

		call EleDrag(actEle,nEle,xEle,yEle,qEle,rEle,xCursor,
     $	rAnchor,cosQAc,sinQAc,FDrag,E)

	end if

	call omp_set_num_threads (1)
c      time111(iiter,6)=omp_get_Wtime()

	Fx(actEle+1)=Fx(actEle+1)+FDrag(1)
	Fy(actEle+1)=Fy(actEle+1)+FDrag(2)
	FM(actEle+1)=FM(actEle+1)+FDrag(3)
      
c      time111(iiter,7)=omp_get_Wtime()

      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!!!Calculate the motions of all particles  !!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

      if ((flagConstP.eq.0).or.(iIter.eq.1)) then
        Fx=Fx+FxWall+FxC
      else
        stressUDCyc(2)=(FWall(2,2)-iniFWall(2,2)
     $                   -FWall(1,2)+iniFWall(1,2))/2.0/
     $                   (vol/(y1Wall(2)-y1Wall(1)))
     
        Fx=Fx+FxWall+FxC/(pMean*2-stsV0)*(pMean*2-stressUDCyc(2))
      end if

      Fy=Fy+FyWall+FyC !/(pMean*2-stsV0)*(pMean*2-stressUDCyc(2))
      FM=FM+FMWall+FMC
      
      
      ! Don't allow the linked particles to rotate.  May make this optional in the future.
      do iLink = 1, nLinks
        iEle = iEleLink(iLink, 1)
        jEle = iEleLink(iLink, 2)
        vqEle(iEle) = 0.0
        vqEle(jEle) = 0.0
        FM(iEle) = 0.0
        FM(jEle) = 0.0
      end do
      

      
c     time111(iiter,8)=omp_get_Wtime()
      call omp_set_num_threads (numThreads)
      
      maxVEle=0
      
      !$omp parallel do private (pvgXgy,pvxGravity,
     $  pvDt,pvGlobdamp,pvRotDamp) 
     $  reduction (+ : moni1,moni2,moni3 ) 
     $  reduction (max : maxVEle,maxFCon)

	do iEle=1,nActEle

            pvgXgY=gXgY
            pvGlobdamp=globDamp
            pvRotDamp=rotDamp
            pvXGravity=xGravity
            pvDt=dt

			Fx(iEle)=Fx(iEle)+mGravEle(iEle)
     $		*sign(pvgXgY(1),pvXGravity(1)-xEle(iEle))
     
			Fy(iEle)=Fy(iEle)+mGravEle(iEle)
     $		*sign(pvgXgY(2),pvxGravity(2)-yEle(iEle))
		   
		    FM(iEle)=FM(iEle)
		   
            if (flagThinLayer(2).eq.1) then		    
		       if (yEle(iEle).lt.(y1Wall(1)+hThinLayer)) then
		         FM(iEle)=0
		       else if (yEle(iEle).gt.(y1Wall(2)-hThinLayer)) then
		         FM(iEle)=0 
		       end if
		    end if
		    
			Call Translation(xEle(iEle),vxEle(iEle),
     $			Fx(iEle),mInertEle(iEle),pvDt,pvGlobdamp)
			Call Translation(yEle(iEle),vyEle(iEle),
     $			Fy(iEle),mInertEle(iEle),pvDt,pvGlobdamp)   

      		call Rotation(qEle(iEle),vqEle(iEle),
     $			FM(iEle),MIInertEle(iEle),pvDt,pvRotDamp)
    
c            end if
      




			if (iIter.eq.nInc) then	
				moni1=moni1+vxEle(iEle)*mInertEle(iEle)
				moni2=moni2+vyEle(iEle)*mInertEle(iEle)
				moni3=moni3+mInertEle(iEle)*(vxEle(iEle)**2
     $				+vyEle(iEle)**2)+MIInertEle(iEle)*vqEle(iele)**2
               maxVEle=max(maxVEle,abs(vxEle(iEle)),
     $                        abs(vyEle(iEle)))
			end if
	end do !iEle
	
      monitor(4)=maxVEle
      monitor(1)=moni1
      monitor(2)=moni2
      monitor(3)=moni3
      
      
c      time111(iiter,9)=omp_get_Wtime()

      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!!!!update the new coordinates of Vertexes  !!!!!!!!!!!!!!!!!
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


	call udVertex(nEle,nActEle,xEle,yEle,qEle,qVertex,rVertex,
     $					 	nVertex,xVertex,yVertex,rqCE,xCE,numThreads)   ! update the new coordinates of Vertexes

c      time111(iiter,10)=omp_get_Wtime()

      if ((flagConstP.eq.1).and.(iIter.eq.1)) then
        stsV0=(FWall(2,2)-iniFWall(2,2)
     $        -FWall(1,2)+iniFWall(1,2))/2.0/
     $         (vol/(y1Wall(2)-y1Wall(1)))
     
      end if


	end do ! iIter=1,nInc

	dMotionWall=0
	monitor(5)=max(maxval(FxCon),maxval(FyCon))
	aOverAll=aOver1+aOver2
	
	
	!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	!!!!! To make a homogenous stress state !!!!!!!!!!!!!
c	realLoadPara(iCurStep(2):iCurStep(2)+1,6)=
c     $  	-(FWall(1,1)-FWall(2,1))/(lWallEff(1)+lWallEff(1))
c	realLoadPara(iCurStep(2):iCurStep(2)+1,8)=
c     $  	-(FWall(1,1)-FWall(2,1))/(lWallEff(1)+lWallEff(1))
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

	
	if ((iCurStep(4).eq.1).and.(flagOutInied.eq.1)) then
	
          write (1000,'(4I8,100E14.6)') iCurStep(1),iCurStep(2),
     $ iCurStep(3),nPair,monitor(3),monitor(4),aoverAll/vol
         
	if (factorSlow.gt.1.5) then
	
        write (1000,'(3I8,A10,100E14.6)') iCurStep(1),
     $  iCurStep(2),iCurStep(3),'Warning! ',factorSlow
	
	end if          
	write (5000,'(I8,2X,100E14.6)') iCurStep(1),
     $      (x1Wall(iTemp),y1Wall(iTemp),iTemp=1,4),
     $      ((FWall(iWall,iTemp)-iniFWall(iWall,iTemp)
     $      ,iTemp=1,2),iWall=1,4),vol, iDirecCyc
           ! iWallLoad(iPara)=iWallLoad(iWall*2-2+iTemp) is the para index of FWall(iWall,iTemp)
           ! int(intLoadPara(iCurStep(2),iWall*2-2+iTemp)/3) =0 if intLoadPara=1 or 2, =1 if intLoadPara=3
           ! if intLoadPara=3, need to deduct the force by the confinement from the total force
         
         
          if (eleOut(0).gt.0) then
          
          write (2000,'(I8,500E14.6)') iCurStep(1),
     $      ((xEle(eleOut(iTemp)),yEle(eleOut(iTemp)),
     $      qEle(eleOut(iTemp))),iTemp=1,eleOut(0))
          
          end if
     
      end if
c		write (6489,'(100E18.10)') x1Wall(1),y1Wall(1),x1Wall(3),y1Wall(3),
c     $		(FWall(iWall,1),FWall(iWall,2),iWall=1,nWall),aOverAll
      
      !!!!!!Constant P only
!      if (intLoadPara(iCurStep(2),1).eq.1) then
!      FWall(3,1)=FWall(3,1)-iniFWall(3,1)
!      FWall(4,1)=FWall(4,1)-iniFWall(3,1)
!      end if
      
c      do iIter=1,nInc
      
c       write (9482,'(I8,100E18.10)') numThreads, 
c    $   (time111(iiter,j+1)-time111(iiter,j),j=0,9)
      
c      end do
       
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
      !!!  Update the indices of steps.
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      
      if (flagLoadMode.eq.1) then 
      
          iCurStep(3)=iCurStep(3)+1
          
          if ( iCurStep(3).gt.intLoadPara(iCurStep(2),0) ) then
          
            iCurStep(2)=iCurStep(2)+1
            iCurStep(3)=1
            
            
          end if
     
      end if
      
      
      if (flagLoadMode.eq.0) then
      
        iCurStep(2)=0
      
      end if
      
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!! Temporary, for cyc UD only
      
      if (flagUDCyc.eq.1) then
        stressUDCyc(2)=(FWall(2,2)
     $                   -FWall(1,2))/2.0/
     $                   (x1Wall(4)-x1Wall(3))
        stressUDCyc(1)=(FWall(4,1)
     $                   -FWall(3,1))/2.0/
     $                   (y1Wall(2)-y1Wall(1))
!       iniFWall(4,1)=-iniFWall(3,1)
        
        if ( (iDirecCyc.eq.1).and.
     $       ((stressUDCyc(2)-stressUDCyc(1)).gt.qLimit) ) then

                iDirecCyc=-1

        end if

        if ( (iDirecCyc.eq.-1).and.
     $       ((stressUDCyc(1)-stressUDCyc(2)).gt.qLimit) ) then

                iDirecCyc=1

        end if
       
      end if 
      
        write (1234,*) iDirecCyc, stressUDCyc(2)-stressUDCyc(1), 
     $  iCurStep(2)
        close (1234)
      
      if (flagConstP.eq.1) then
        realLoadPara(iCurStep(2),5)=pMean*2-stressUDCyc(2)
        realLoadPara(iCurStep(2),7)=pMean*2-stressUDCyc(2)
      end if
!      write (3849,'(2I8,100E13.5)') iDirecCyc, nInc, stressUDCyc(1), 
!     $  stressUDCYc(2),   realLoadPara(iCurStep(2),1),
!     $  v0,v1,maxVWall,maxAccWall, dt
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      

	end subroutine 

	
	
	double precision FUNCTION PtDist(x1,y1,x2,y2)
	implicit none
		double precision x1,y1,x2,y2
			PtDist=(x1-x2)**2+(y1-y2)**2
		return
	end  Function
