      subroutine Mass(nEle,nActEle,areaEle,mGravEle,mInertEle,MIEle,
     $    MIInertEle,dt,density,E,flagMassNorm)
      
      implicit none
       !DEC$ ATTRIBUTES DLLEXPORT :: Mass
	 !DEC$ ATTRIBUTES ALIAS:'Mass' :: Mass
	 !DEC$ ATTRIBUTES Reference :: 
     $	 nEle,nActEle,areaEle,mGravEle,mInertEle,MIEle,
     $    MIInertEle,dt,density,E,flagMassNorm
	 
      ! mGravEle = gravitational mass
      ! mInertEle = inertial mass
      ! MIEle = moment of inertial assuming density=1
      ! MIInertEle = inertial MI
      
      integer nEle,nActEle,iEle,flagMassNorm
      double precision areaEle(nEle),mGravEle(nEle),mInertEle(nEle),
     $   MIEle(nEle),MIInertEle(nEle)
     
      double precision dt, density,E
      
      do iEle=1,nActELe 
      
         mGravEle(iEle)=areaEle(iEle)*density
         
         if (flagMassNorm.eq.1) then
            mInertEle(iEle)=dt**2*E*sqrt(areaEle(iEle)/3.1415926535)*10
         else
            mInertEle(iEle)=mGravEle(iEle)
         end if
         
         MIInertEle(iEle)=MIEle(iEle)*mInertEle(iEle)/areaEle(iEle)
 
         ! mInertEle(iEle)/areaEle(iEle) is the gravitational density
      end do
      
      end subroutine