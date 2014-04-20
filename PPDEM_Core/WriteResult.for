	subroutine WriteResult(nEle,nActEle,xEle,yEle,qEle,
     $		   vxEle,vyEle,vqEle,nWall,x1Wall,x2Wall,y1Wall,y2Wall,
     $         nCon,xCon,yCon,rCon,FxCon,FyCon,fricRatio,tanNorm,
     $         flagConBoun,pairCon, 
     $         nPtHL,xPtHL,strgTensl,strgRatio,params,
     $         alwNEleFrd,flagWriteOpen,iCurStep,FileName,lName)

	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: WriteResult
	 !DEC$ ATTRIBUTES ALIAS:'WriteResult' :: WriteResult
	 !DEC$ ATTRIBUTES Reference :: 
     $         nEle,nActEle,xEle,yEle,qEle,
     $		   vxEle,vyEle,vqEle,nWall,x1Wall,x2Wall,y1Wall,y2Wall,
     $         nCon,xCon,yCon,rCon,FxCon,FyCon,fricRatio,tanNorm,
     $         flagConBoun,pairCon, 
     $         nPtHL,xPtHL,strgTensl,strgRatio,params,
     $         alwNEleFrd,flagWriteOpen,iCurStep,FileName
	
	
	integer nEle,nActEle,nWall,nCon,nPtHL,alwNEleFrd,lName
	
	double precision xEle(nEle),yEle(nEle),qEle(nEle),
     $	vxEle(nEle),vyEle(nEle),vqEle(nEle),
     $	x1Wall(nWall),x2Wall(nWall),y1Wall(nWall),y2Wall(nWall),
     $	xCon(nEle*10),yCon(nEle*10),rCon(nEle*10),
     $  FxCon(nEle*10),FyCon(nEle*10),fricRatio(nEle*10),
     $	tanNorm(nEle*10),xPtHL(nEle*10,2),params(20),
     $  strgRatio(1),strgTensl(1)
c     $  strgRatio(nEle*11),strgTensl(nEle*11)

      integer flagWriteOpen,iRecord,nRcdStep,iSkip,iEle,iWall,
     $   iCon,iPtHL,iParam,nParams,flagConBoun(nEle*10),
     $   pairCon(nEle*10,2),iCurStep(4)
      
	CHARACTER*(lName) Filename

      nRcdStep=21
      nParams=20
      
      
      if (flagWriteOpen.eq.1) then
         flagWriteOpen=0
         open (888,file=FileName,form="unformatted")
         write (888) "Version4"

      end if

      if (flagWriteOpen.eq.0) then
        
        write (888) nActEle,(xEle(iEle),iEle=1,nActEle),
     $    (vxEle(iEle),iEle=1,nActEle),iCurStep(1)
        write (888) nActEle,(yEle(iEle),iEle=1,nActEle),
     $    (vyEle(iEle),iEle=1,nActEle)
       write (888) nActEle,(qEle(iEle),iEle=1,nActEle),
     $    (vqEle(iEle),iEle=1,nActEle)
         
        write (888) nWall,(x1Wall(iWall),iWall=1,nWall)
        write (888) nWall,(y1Wall(iWall),iWall=1,nWall)
        write (888) nWall,(x2Wall(iWall),iWall=1,nWall)
        write (888) nWall,(y2Wall(iWall),iWall=1,nWall)
         
        write (888) nCon,(xCon(iCon),iCon=1,nCon)
        write (888) nCon,(yCon(iCon),iCon=1,nCon)
        write (888) nCon,(rCon(iCon),iCon=1,nCon)
        write (888) nCon,(FxCon(iCon),iCon=1,nCon)
        write (888) nCon,(FyCon(iCon),iCon=1,nCon)
        write (888) nCon,(fricRatio(iCon),iCon=1,nCon)
        write (888) nCon,(tanNorm(iCon),iCon=1,nCon)
        write (888) nCon,(flagConBoun(iCon),iCon=1,nCon)
        write (888) nCon,((pairCon(iCon,1),pairCon(iCon,2)),iCon=1,nCon)
         
         
        write (888) nPtHL,(xPtHL(iPtHL,1),iPtHL=1,nPtHL)
        write (888) nPtHL,(xPtHL(iPtHL,2),iPtHL=1,nPtHL)
        write (888) nPtHL,(StrgTensl(1),iPtHL=1,nPtHL)
        write (888) nPtHL,(StrgRatio(1),iPtHL=1,nPtHL)
c        write (888) nPtHL,(StrgTensl(iPtHL),iPtHL=1,nPtHL)
c        write (888) nPtHL,(StrgRatio(iPtHL),iPtHL=1,nPtHL)
        
        write (888) nParams,(params(iParam),iParam=1,nParams)
         
      end if 
      
      do iEle=1,nActEle
c        write (1232,'(I8,E13.5)') iEle,qEle(iEle)
      end do


      end subroutine