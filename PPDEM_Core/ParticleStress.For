      subroutine ParticleStress(nEle,nActEle,xEle,yEle,areaEle,
     $   nCon,xCon,yCon,FxCon,FyCon,flagConBoun,pairCon,ptcStress)
     
      implicit none
     
       !DEC$ ATTRIBUTES DLLEXPORT :: ParticleStress
	 !DEC$ ATTRIBUTES ALIAS:'ParticleStress' :: ParticleStress
	 !DEC$ ATTRIBUTES Reference :: nEle,nActEle,xEle,yEle,areaEle,
     $   nCon,xCon,yCon,FxCon,FyCon,flagConBoun,pairCon,ptcStress
	 
	 
      integer nEle, nActEle,iCon,iEle,nCon
      
      integer flagConBoun(nEle*10),pairCon(nEle*10,2)
      
      double precision xEle(nEle),yEle(nEle),areaEle(nEle),
     $ xCon(nEle*10),yCon(nEle*10),FxCon(nEle*10),FyCon(nEle*10),
     $ ptcStress(nEle,6)
      
      ptcStress=0 
      
      do iCon=1,nCon
      
        if ((flagConBoun(iCon).eq.1).or.(flagConBoun(iCon).eq.2)) then  
        
            ptcStress(pairCon(iCon,1),1)=ptcStress(pairCon(iCon,1),1)
     $          +FxCon(iCon)*(xCon(iCon)-xEle(pairCon(iCon,1)))   ! Using the center of the element as the origin of a local coordinate system can minimize the error induced by unbalanced force.

            ptcStress(pairCon(iCon,1),2)=ptcStress(pairCon(iCon,1),2)
     $          +FyCon(iCon)*(xCon(iCon)-xEle(pairCon(iCon,1)))

            ptcStress(pairCon(iCon,1),3)=ptcStress(pairCon(iCon,1),3)
     $          +FxCon(iCon)*(yCon(iCon)-yEle(pairCon(iCon,1)))

            ptcStress(pairCon(iCon,1),4)=ptcStress(pairCon(iCon,1),4)
     $          +FyCon(iCon)*(yCon(iCon)-yEle(pairCon(iCon,1)))
     
     
        else if (flagConBoun(iCon).eq.0) then
        
            ptcStress(pairCon(iCon,1),1)=ptcStress(pairCon(iCon,1),1)
     $          +FxCon(iCon)*(xCon(iCon)-xEle(pairCon(iCon,1)))   ! Using the center of the element as the origin of a local coordinate system can minimize the error induced by unbalanced force.

            ptcStress(pairCon(iCon,1),2)=ptcStress(pairCon(iCon,1),2)
     $          +FyCon(iCon)*(xCon(iCon)-xEle(pairCon(iCon,1)))

            ptcStress(pairCon(iCon,1),3)=ptcStress(pairCon(iCon,1),3)
     $          +FxCon(iCon)*(yCon(iCon)-yEle(pairCon(iCon,1)))

            ptcStress(pairCon(iCon,1),4)=ptcStress(pairCon(iCon,1),4)
     $          +FyCon(iCon)*(yCon(iCon)-yEle(pairCon(iCon,1)))
        
            ptcStress(pairCon(iCon,2),1)=ptcStress(pairCon(iCon,2),1)
     $          -FxCon(iCon)*(xCon(iCon)-xEle(pairCon(iCon,2)))   

            ptcStress(pairCon(iCon,2),2)=ptcStress(pairCon(iCon,2),2)
     $          -FyCon(iCon)*(xCon(iCon)-xEle(pairCon(iCon,2)))

            ptcStress(pairCon(iCon,2),3)=ptcStress(pairCon(iCon,2),3)
     $          -FxCon(iCon)*(yCon(iCon)-yEle(pairCon(iCon,2)))

            ptcStress(pairCon(iCon,2),4)=ptcStress(pairCon(iCon,2),4)
     $          -FyCon(iCon)*(yCon(iCon)-yEle(pairCon(iCon,2)))
        
     
        end if
      
      end do
      
      do iEle=1,nActele
      
        ptcStress(iEle,:)=-ptcStress(iEle,:)/areaEle(iEle)
        
      
      end do
      
      ptcStress(:,2)=(ptcStress(:,2)+ptcStress(:,3))/2
      ptcStress(:,5)=ptcStress(:,1)+ptcStress(:,4)
      ptcStress(:,6)=sqrt(  (ptcStress(:,1)-ptcStress(:,4))**2/4  
     $              +ptcStress(:,2)**2)

      end subroutine
      

