	subroutine ReadResult(nEle,nActEle,xEle,yEle,qEle,
     $	 vxEle,vyEle,vqEle,
     $   qVertex,rVertex,xVertex,yVertex,rqCE,xCE,nVertex   ,   	
     $	 nWall,x1Wall,x2Wall,y1Wall,y2Wall,
     $   nCon,xCon,yCon,rCon,FxCon,FyCon,fricRatio,tanNorm,
     $   flagConBoun,pairCon,
     $   FRGB,nPtHL,xPtHL,strgTensl,strgRatio,params,alwNEleFrd,
     $   nStep,iStep,preStep,
     $   flagReadOpen,verRead,iCurStep,FileName,lName)

	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: ReadResult
	 !DEC$ ATTRIBUTES ALIAS:'ReadResult' :: ReadResult
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,nActEle,xEle,yEle,qEle,
     $	 vxEle,vyEle,vqEle,
     $   qVertex,rVertex,xVertex,yVertex,rqCE,xCE,nVertex   ,   	
     $	 nWall,x1Wall,x2Wall,y1Wall,y2Wall,
     $   nCon,xCon,yCon,rCon,FxCon,FyCon,fricRatio,tanNorm,
     $   flagConBoun,pairCon,
     $   FRGB,nPtHL,xPtHL,strgTensl,strgRatio,params,alwNEleFrd,
     $   nStep,iStep,preStep,
     $   flagReadOpen,verRead,iCurStep,FileName
     
     
	
	integer nEle,nActEle,nWall,nCon,nPtHL,alwNEleFrd,lName
	
	double precision xEle(nEle),yEle(nEle),qEle(nEle),
     $	 vxEle(nEle),vyEle(nEle),vqEle(nEle),
     $   qVertex(nEle,10),rVertex(nEle,10),xVertex(nEle,10),
     $   yVertex(nEle,10),rqCE(nEle,10,4),xCE(nEle,10,2),	
     $	x1Wall(nWall),x2Wall(nWall),y1Wall(nWall),y2Wall(nWall),
     $	xCon(nEle*10),yCon(nEle*10),rCon(nEle*10),
     $  FxCon(nEle*10),FyCon(nEle*10),
     $	fricRatio(nEle*10),tanNorm(nEle*10),xPtHL(nEle*10,2),params(20),
     $  strgTensl(1),strgRatio(1)
c     $  strgTensl(nEle*11),strgRatio(nEle*11)

	integer flagReadOpen,iRecord,nStep,iStep,nRcdStep,iSkip,
     $   iEle,iWall,iCon,iPtHL,nVertex(nEle),iParam,nParams,
     $   flagConBoun(nEle*10),pairCon(nEle*10,2), preStep
     
	integer FRGB(nEle*10,3),verRead,iCurStep(4)
	
	character *8 Version
	CHARACTER*(lName) Filename
	
	!!! Version0 does not have the version information
	!!! Version1 has version information, added a line for tanNorm
	!!! Version2 added a line for flagConBoun  
	
	
	nParams=20
	
	
	if (flagReadOpen.eq.1) then
		 open (999,file=FileName, form="unformatted")
		 
		 read (999) Version
		 
		 if (version.eq."Version1") then
			nRcdStep=19
			verRead=1
		 else if((version.eq."Version2").or.
     $          (version.eq."Version3").or.
     $          (version.eq."Version4")) then
			nRcdStep=21
			verRead=2
		 else
			nRcdStep=18
			verRead=0   
			rewind(999)   ! Old version files don't have a version line
		 end if

		 nStep=0
		 DO WHILE (.NOT. EOF(999))
		   read (999) 
		   nStep=nStep+1
		 end do
		 
		 nStep=nStep/nRcdStep-1   ! Does not read the last step, in case the last step writing was not complete
		 
		 rewind(999)
		 read(999) version
	end if

	if (flagReadOpen.eq.0) then
	
		 if (.false.) then !version.eq."Version1") then
			nRcdStep=19
			verRead=1
		 else if(.true.) then !(version.eq."Version2").or.
!     $            (version.eq."Version3").or.
!     $            (version.eq."Version4")) then
			nRcdStep=21
			verRead=2
		 else
			nRcdStep=18
			verRead=0   
			rewind(999)  ! Old version files don't have a version line
		 end if
		 
		 if (preStep.eq.0) then
		    rewind(999)
		    read(999)
		end if

	   if (iStep.gt.preStep) then
		     do iSkip=1, (iStep-preStep-1)*nRcdStep
			    read (999)
		     end do
	   
	   else 
		     rewind(999)
    		     read (999) Version
		     do iSkip=1, (iStep-1)*nRcdStep
			    read (999)
		     end do
	   
	   end if

	
		 if (.true.) then !(version.eq."Version4") then 
		    read (999) nActEle,(xEle(iEle),iEle=1,nActEle),
     $       (vxEle(iEle),iEle=1,nActEle),iCurStep(1)
		 else if (version.eq."Version3") then
			read (999) nActEle,(xEle(iEle),iEle=1,nActEle),iCurStep(1)
		 else 
			read (999) nActEle,(xEle(iEle),iEle=1,nActEle)
		 end if
		 
		 if (version.eq."Version4") then 
			read (999) nActEle,(yEle(iEle),iEle=1,nActEle),
     $       (vyEle(iEle),iEle=1,nActEle)
			read (999) nActEle,(qEle(iEle),iEle=1,nActEle),
     $       (vqEle(iEle),iEle=1,nActEle)
		 else 
			read (999) nActEle,(yEle(iEle),iEle=1,nActEle)
			read (999) nActEle,(qEle(iEle),iEle=1,nActEle)
		 end if
		 
		 
		 read (999) nWall,(x1Wall(iWall),iWall=1,nWall)
		 read (999) nWall,(y1Wall(iWall),iWall=1,nWall)
		 read (999) nWall,(x2Wall(iWall),iWall=1,nWall)
		 read (999) nWall,(y2Wall(iWall),iWall=1,nWall)
		 
		 read (999) nCon,(xCon(iCon),iCon=1,nCon)
		 read (999) nCon,(yCon(iCon),iCon=1,nCon)
		 read (999) nCon,(rCon(iCon),iCon=1,nCon)
		 read (999) nCon,(FxCon(iCon),iCon=1,nCon)
		 read (999) nCon,(FyCon(iCon),iCon=1,nCon)
		 read (999) nCon,(fricRatio(iCon),iCon=1,nCon)
		 if (verRead.eq.1) then
			 read (999) nCon,(tanNorm(iCon),iCon=1,nCon)
		 end if
		 if (verRead.eq.2) then
			 read (999) nCon,(tanNorm(iCon),iCon=1,nCon)
			 read (999) nCon,(flagConBoun(iCon),iCon=1,nCon)
			 read (999) nCon,((pairCon(iCon,1),pairCon(iCon,2)),
     $        iCon=1,nCon)
		 end if
		 
		 do iCon=1,nCon
			call HSV2RGB(fricRatio(iCon),FRGB(iCon,:))
		 end do
		 
		 read (999) nPtHL,(xPtHL(iPtHL,1),iPtHL=1,nPtHL)
		 read (999) nPtHL,(xPtHL(iPtHL,2),iPtHL=1,nPtHL)
		 read (999) nPtHL,(StrgTensl(1),iPtHL=1,nPtHL)
		 read (999) nPtHL,(StrgRatio(1),iPtHL=1,nPtHL)
c         read (999) nPtHL,(StrgTensl(iPtHL),iPtHL=1,nPtHL)
c         read (999) nPtHL,(StrgRatio(iPtHL),iPtHL=1,nPtHL)
		 
		 read (999) nParams,(params(iParam),iParam=1,nParams)
		 
		call udVertex(nEle,nActEle,xEle,yEle,qEle,qVertex,rVertex,
     $					 	nVertex,xVertex,yVertex,rqCE,xCE,1)   

        preStep=iStep
	end if 
	
	flagReadOpen=0


	end subroutine