	subroutine CalPOLY(nEle,nActEle,xEle,yEle,qEle,nVertex,xVertex,yVertex,
     $	qVertex,rVertex,rEle,boundEle,MIEle,vxEle,vyEle,vqEle,
     $	nWall,x1Wall,x2Wall,y1Wall,y2Wall,nInc,dt,E,density,tanTheta,
     $	xGravity,gXgY,monitor,globdamp,rotDamp,FtPair, FtWP,dampingRatio,
     $  rollingDamp,flagDebug,xCon,yCon,FxCon,FyCon,fricRatio,tanNorm,
     $  FRGB,rCon,nCon,nPCon, pPlot,flagConBoun,pairCon,
     $	nPair,pair,nWallFrd,lWallFrd,FxC,FyC,FMC,flagGlue,
     $	flagPairCohe,dMotionWall,actWall,
     $	actEle,xCursor,rAnchor,cosQAc,sinQAc,flagDrag,
     $	cosQiAM,sinQiAM,cosQiAN,sinQiAN,cosQiBM,sinQiBM,cosQiBN,sinQiBN,
     $	rMA,rNA,rMB,rNB,ECohe,nPtHL,xPtHL,strgTensl,numThreads,
     $  alwNEleFrd,mGravEle,mInertEle,MIInertEle,zoomscale,rqCE,xCE,
     $  hSector, limitAll,vWall,aOverAll, vol, 
     $  flagLoadMode, intLoadPara, realLoadPara,iCurStep, 
     $  eleOut,FWall,iniFWall,FxWall,FyWall,FMWall,Fx,Fy,FM,iniOri,
     $  elong,flagOutInied,factorSlow,
     $  hThinLayer,flagThinLayer,iDirecCyc, 
     $  flagSpecialLoad) 
		implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: CalPOLY
	 !DEC$ ATTRIBUTES ALIAS:'CalPOLY' :: CalPOLY
	 !DEC$ ATTRIBUTES Reference :: 
     $  nEle,nActEle,xEle,yEle,qEle,nVertex,xVertex,yVertex,
     $	qVertex,rVertex,rEle,boundEle,MIEle,vxEle,vyEle,vqEle,
     $	nWall,x1Wall,x2Wall,y1Wall,y2Wall,nInc,dt,E,density,tanTheta,
     $	xGravity,gXgY,monitor,globdamp,rotDamp,FtPair, FtWP,dampingRatio,
     $  rollingDamp,flagDebug,xCon,yCon,FxCon,FyCon,fricRatio,tanNorm,
     $  FRGB,rCon,nCon,nPCon, pPlot,flagConBoun,pairCon,
     $	nPair,pair,nWallFrd,lWallFrd,FxC,FyC,FMC,flagGlue,
     $	flagPairCohe,dMotionWall,actWall,
     $	actEle,xCursor,rAnchor,cosQAc,sinQAc,flagDrag,
     $	cosQiAM,sinQiAM,cosQiAN,sinQiAN,cosQiBM,sinQiBM,cosQiBN,sinQiBN,
     $	rMA,rNA,rMB,rNB,ECohe,nPtHL,xPtHL,strgTensl,numThreads,
     $  alwNEleFrd,mGravEle,mInertEle,MIInertEle,zoomscale,rqCE,xCE,
     $  hSector, limitAll,vWall,aOverAll, vol, 
     $  flagLoadMode, intLoadPara, realLoadPara,iCurStep, 
     $  eleOut,FWall,iniFWall,FxWall,FyWall,FMWall,Fx,Fy,FM,iniOri,
     $  elong,flagOutInied,factorSlow,
     $  hThinLayer,flagThinLayer,iDirecCyc, 
     $  flagSpecialLoad
     
     
     
     
     	integer nEle,nActEle,nWall,nCon,nPCon,nGridX,nGridY,numThreads,
     $   alwNEleFrd
	integer nVertex(nEle)
	integer iEle,iVertex,iWall,iIter,nInc,jEle

	double precision dt,factorSlow

	double precision xEle(nEle),yEle(nEle),qEle(nEle),xVertex(nEle,10),
     $	yVertex(nEle,10),qVertex(nEle,10),rVertex(nEle,10),rEle(nEle),
     $	boundEle(nEle,4),iniOri(nEle),elong(nEle)

	double precision MIEle(nEle),mGravEle(nEle),
     $  mInertEle(nEle),MIInertEle(nEle)

	double precision vxEle(nEle),vyEle(nEle),vqEle(nEle)

	double precision x1Wall(nWall),x2Wall(nWall),
     $	y1Wall(nWall),y2Wall(nWall),dxWall,dMotionWall(4),vWall(nWall,2)

	double precision E,tanTheta(2),xGravity(2),gXgY(2),pY,density

	integer flagDebug,flagConBoun(nEle*10),flagLoadMode


	double precision Fx(nEle),Fy(nEle),FM(nEle),globdamp,rotDamp,
     $            dampingRatio,monitor(5),maxVEle,rollingDamp


	double precision FtPair(nEle*alwNEleFrd), FtWP(nWall,nEle)

	double precision xCon(nEle*10),yCon(nEle*10),FxCon(nEle*10),
     $	FyCon(nEle*10),rCon(nEle*10),fricRatio(nEle*10),tanNorm(nEle*10),
     $  pPlot(nEle*10,4)

	integer nPair, pair(nEle*alwNEleFrd,2),FRGB(nEle*10,3), 
     $	pairCon(nEle*10,2)
	
	integer nWallFrd,lWallFrd(nWall*nEle,2),actWall,actEle


	double precision FxC(nEle),FyC(nEle),FMC(nELe),     
     $  FxWall(nEle), FyWall(nEle),FMWall(nEle),
     $  FWall(nWall,2),iniFWall(nWall,2)


	integer flagGlue,flagPairCohe(nEle*alwNEleFrd),flagDrag,flagOutInied
	
	double precision FDrag(3),xCursor(2),rAnchor,cosQAc,sinQAc,zoomscale,
     $ limitAll(4),aOverAll, vol

	double precision cosQiAM(nEle*11),
     $	sinQiAM(nEle*11),cosQiAN(nEle*11),
     $   sinQiAN(nEle*11),cosQiBM(nEle*11),
     $	sinQiBM(nEle*11),cosQiBN(nEle*11),
     $	sinQiBN(nEle*11),rMA(nEle*11),
     $   rNA(nEle*11),rMB(nEle*11),
     $	rNB(nEle*11),ECohe(nEle*11),strgFactor,
     $   strgTensl(nEle*11)

c	double precision cosQiAM(1),
c     $	sinQiAM(1),cosQiAN(1),
c     $   sinQiAN(1),cosQiBM(1),
c     $	sinQiBM(1),cosQiBN(1),
c     $	sinQiBN(1),rMA(1),
c     $   rNA(1),rMB(1),
c     $	rNB(1),ECohe(1),strgFactor,
c     $   strgTensl(1)

	integer nPtHL
	double precision xPtHL(nEle*10,2)

	
      double precision rqCE(nEle,10,4),xCE(nEle,10,2),hSector(nEle)
      
      integer intLoadPara(0:100000,0:8),iCurStep(4)
      double precision realLoadPara(0:100000,8)     
      
	integer eleOut(0:1000)
	
	double precision hThinLayer
	integer flagThinLayer(2)
 
      integer iDirecCyc, flagSpecialLoad

	
	
	call CalOMP(nEle,nActEle,xEle,yEle,qEle,nVertex,xVertex,yVertex,
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
     $  flagLoadMode, intLoadPara, realLoadPara,iCurStep, 
     $  eleOut,FWall,iniFWall,FxWall,FyWall,FMWall,Fx,Fy,FM,iniOri,
     $  elong,flagOutInied,factorSlow,
     $  hThinLayer,flagThinLayer,iDirecCyc,flagSpecialLoad)



	end subroutine 

	
	
