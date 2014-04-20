      subroutine InheritPair(nEle,nPair,oldnPair,pair,oldPair,
     $   nEleFrd,oldNEleFrd,pairIndex,oldPairIndex,
     $   FtPair,oldFtpair,flagPairCohe,oldFlagPairCohe,
     $	cosQiAM,oldCosQiAM,sinQiAM,oldSinQiAM,cosQiAN,oldCosQiAN,
     $   sinQiAN,oldSinQiAN,cosQiBM,oldCosQiBM,sinQiBM,oldSinQiBM,
     $   cosQiBN,oldCosQiBN,sinQiBN,oldSinQiBN,rMA,oldRMA,rNA,oldRNA,
     $	rMB,oldRMB,rNB,oldRNB,ECohe,oldECohe,strgTensl,oldStrgTensl,
     $   alwNEleFrd)
     
     	 !DEC$ ATTRIBUTES DLLEXPORT :: InheritPair
	 !DEC$ ATTRIBUTES ALIAS:'InheritPair' :: InheritPair
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,nPair,oldnPair,pair,oldPair,
     $   nEleFrd,oldNEleFrd,pairIndex,oldPairIndex,
     $   FtPair,oldFtpair,flagPairCohe,oldFlagPairCohe,
     $	cosQiAM,oldCosQiAM,sinQiAM,oldSinQiAM,cosQiAN,oldCosQiAN,
     $   sinQiAN,oldSinQiAN,cosQiBM,oldCosQiBM,sinQiBM,oldSinQiBM,
     $   cosQiBN,oldCosQiBN,sinQiBN,oldSinQiBN,rMA,oldRMA,rNA,oldRNA,
     $	rMB,oldRMB,rNB,oldRNB,ECohe,oldECohe,strgTensl,oldStrgTensl,
     $   alwNEleFrd

	 implicit none
	 
	 integer nEle,alwNEleFrd
	 integer nPair,oldnPair,pair(nEle*alwNEleFrd,2),
     $   oldPair(nEle*alwNEleFrd,2),
     $   nEleFrd(nEle),oldNEleFrd(nEle),
     $   pairIndex(nEle,alwNEleFrd,2),
     $   oldPairIndex(nEle,alwNEleFrd,2),
     $   flagPairCohe(nEle*alwNEleFrd),
     $   oldFlagPairCohe(nEle*alwNEleFrd)
     
      double precision 
     $   FtPair(nEle*alwNEleFrd),oldFtPair(nEle*alwNEleFrd),
     $   cosQiAM(nEle*11),oldCosQiAM(nEle*11),
     $   sinQiAM(nEle*11),oldSinQiAM(nEle*11),
     $   cosQiAN(nEle*11),oldCosQiAN(nEle*11),
     $   sinQiAN(nEle*11),oldSinQiAN(nEle*11),
     $   cosQiBM(nEle*11),oldCosQiBM(nEle*11),
     $   sinQiBM(nEle*11),oldSinQiBM(nEle*11),
     $   cosQiBN(nEle*11),oldCosQiBN(nEle*11),
     $   sinQiBN(nEle*11),oldSinQiBN(nEle*11),
     $   rMA(nEle*11),oldRMA(nEle*11),
     $   rNA(nEle*11),oldRNA(nEle*11),
     $	rMB(nEle*11),oldRMB(nEle*11),
     $   rNB(nEle*11),oldRNB(nEle*11),
     $   ECohe(nEle*11),oldECohe(nEle*11),
     $   strgTensl(nEle*11),oldStrgTensl(nEle*11)
     
     
c      double precision 
c     $   FtPair(nEle*alwNEleFrd),oldFtPair(nEle*alwNEleFrd),
c     $   cosQiAM(1),oldCosQiAM(1),
c     $   sinQiAM(1),oldSinQiAM(1),
c     $   cosQiAN(1),oldCosQiAN(1),
c     $   sinQiAN(1),oldSinQiAN(1),
c     $   cosQiBM(1),oldCosQiBM(1),
c     $   sinQiBM(1),oldSinQiBM(1),
c     $   cosQiBN(1),oldCosQiBN(1),
c     $   sinQiBN(1),oldSinQiBN(1),
c     $   rMA(1),oldRMA(1),
c     $   rNA(1),oldRNA(1),
c     $	rMB(1),oldRMB(1),
c     $   rNB(1),oldRNB(1),
c     $   ECohe(1),oldECohe(1),
c     $   strgTensl(1),oldStrgTensl(1)
     
      integer iPair,iEle,jEle,oldIPair

      
      oldFtpair=FtPair
      oldFlagPairCohe=flagPairCohe
      oldCosQiAM=cosQiAM
      oldSinQiAM=sinQiAM
      oldCosQiAN=cosQiAN
      oldSinQiAN=sinQiAN
      oldCosQiBM=cosQiBM
      oldSinQiBM=sinQiBM
      oldCosQiBN=cosQiBN
      oldSinQiBN=sinQiBN
      oldRMA=rMA
      oldRNA=rNA
      oldRMB=rMB
      oldRNB=rNB
      oldECohe=ECohe
      oldStrgTensl=strgTensl
      
      FtPair=0
      flagPairCohe=0
      cosQiAM=0
      sinQiAM=0
      cosQiAN=0
      sinQiAN=0
      cosQiBM=0
      sinQiBM=0
      cosQiBN=0
      sinQiBN=0
      rMA=0
      rNA=0
      rMB=0
      rNB=0
      ECohe=0
      strgTensl=0
      
      
      do iPair=1,nPair
      
         iEle=pair(iPair,1)
         jEle=pair(iPair,2)
            
         call FindOldPair(nEle,iEle,jEle,nEleFrd(iEle),
     $      oldPairIndex,oldIPair,alwNEleFrd)
     
         if (oldIPair.gt.0) then
            FtPair(iPair)=oldFtPair(oldIPair)
            flagPairCohe(iPair)=oldflagPairCohe(oldIPair)
            cosQiAM(iPair)=oldcosQiAM(oldIPair)
            sinQiAM(iPair)=oldsinQiAM(oldIPair)
            cosQiAN(iPair)=oldcosQiAN(oldIPair)
            sinQiAN(iPair)=oldsinQiAN(oldIPair)
            cosQiBM(iPair)=oldcosQiBM(oldIPair)
            sinQiBM(iPair)=oldsinQiBM(oldIPair)
            cosQiBN(iPair)=oldcosQiBN(oldIPair)
            sinQiBN(iPair)=oldsinQiBN(oldIPair)
            rMA(iPair)=oldrMA(oldIPair)
            rNA(iPair)=oldrNA(oldIPair)
            rMB(iPair)=oldrMB(oldIPair)
            rNB(iPair)=oldrNB(oldIPair)
            ECohe(iPair)=oldECohe(oldIPair)
            strgTensl(iPair)=oldstrgTensl(oldIPair)
          end if

         iEle=pair(iPair,2)
         jEle=pair(iPair,1)
            
         call FindOldPair(nEle,iEle,jEle,nEleFrd(iEle),
     $      oldPairIndex,oldIPair,alwNEleFrd)
     
         if (oldIPair.gt.0) then
            FtPair(iPair)=oldFtPair(oldIPair)
            flagPairCohe(iPair)=oldflagPairCohe(oldIPair)
            cosQiAM(iPair)=oldcosQiAM(oldIPair)
            sinQiAM(iPair)=oldsinQiAM(oldIPair)
            cosQiAN(iPair)=oldcosQiAN(oldIPair)
            sinQiAN(iPair)=oldsinQiAN(oldIPair)
            cosQiBM(iPair)=oldcosQiBM(oldIPair)
            sinQiBM(iPair)=oldsinQiBM(oldIPair)
            cosQiBN(iPair)=oldcosQiBN(oldIPair)
            sinQiBN(iPair)=oldsinQiBN(oldIPair)
            rMA(iPair)=oldrMA(oldIPair)
            rNA(iPair)=oldrNA(oldIPair)
            rMB(iPair)=oldrMB(oldIPair)
            rNB(iPair)=oldrNB(oldIPair)
            ECohe(iPair)=oldECohe(oldIPair)
            strgTensl(iPair)=oldstrgTensl(oldIPair)
          end if
      end do
      
      

      end subroutine