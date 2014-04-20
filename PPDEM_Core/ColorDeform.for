	subroutine ColorDeform(nEle,nActEle,xEleTrace,yEleTrace,qEleTrace,
     $   rangeContour,relaMin,relaMax,nStep,iStep,jStep,iMode,jMode,
     $   kMode,mMode,TraceRGB,ptcStress,areaEle,iniOri,ori,refOri,
     $   numECon)
	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: ColorDeform
	 !DEC$ ATTRIBUTES ALIAS:'ColorDeform' :: ColorDeform
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,nActEle,xEleTrace,yEleTrace,qEleTrace,
     $   rangeContour,relaMin,relaMax,nStep,iStep,jStep,iMode,jMode,
     $   kMode,mMode,TraceRGB,ptcStress,areaEle,iniOri,ori,refOri,
     $   numECon
	
	integer nEle,nActEle,iStep,jStep,iEle,iMode,jMode,kMode,
     $  mMode,nStep,TraceRGB(nEle,3),numECon(nEle)
	!iMode = 1: Horizontal translation
	!        2: Vertical translation
	!        3: Total translation
	!        4: Rotation
	!        5: Particle bulk stress/force
	!        6: Particle max shear stress/force
	!        7: Particle stress/force xx
	!        8: Particle stress/force yy
	!        9: Particle stress/force xy
	!        10: Particle current orientation 
	!        11: Particle orientation relative to a given reference angle 
	!        12: coordination number
	
	!jMode = 0: Fix rangeContour
      !      = 1: Fix relaMin and relaMax	
      
	!kMode = 0: Color contour
      !      = 1: Grayscale contour	
      !      = 2: dye particles in black
      
      !mMode = 0: stress
      !mMode = 1: force 
	
	double precision xEleTrace(nEle,nStep),yEleTrace(nEle,nStep),
     $   qEleTrace(nEle,nStep),Fvalue(nEle),
     $   valueMax,valueMin,rangeContour(2),relaValue,relaMin,relaMax, 
     $   ptcStress(nEle,6),areaEle(nEle),ori(nEle),iniOri(nEle),refOri
     
      TraceRGB=100
      
      
      FValue=0
      
      do iEle=1,nActEle
      
         ori(iEle)=mod(iniOri(iEle)+qEleTrace(iELe,iStep),3.1416)
      
         if (ori(iEle).lt.0) then
            ori(iEle)=ori(iEle)+3.1416
         end if
      
      end do
      
      
      if (iMode.eq.1) then
      
         FValue=xEleTrace(:,jStep)-xEleTrace(:,iStep)
      
      else if (iMode.eq.2) then
      
         FValue=yEleTrace(:,jStep)-yEleTrace(:,iStep)
      
      else if (iMode.eq.3) then
      
         FValue=sqrt((xEleTrace(:,jStep)-xEleTrace(:,iStep))**2+
     $       (yEleTrace(:,jStep)-yEleTrace(:,iStep))**2)
      
      else if (iMode.eq.4) then
      
         FValue=qEleTrace(:,jStep)-qEleTrace(:,iStep)
      
      else if (iMode.eq.5) then
      
         FValue=ptcStress(:,5)
      
      else if (iMode.eq.6) then
      
         FValue=ptcStress(:,5)

      else if (iMode.eq.7) then
      
         FValue=ptcStress(:,1)
      
      else if (iMode.eq.8) then
      
         FValue=ptcStress(:,4)
      
      else if (iMode.eq.9) then
      
         FValue=ptcStress(:,2)
         
      else if (iMode.eq.10) then
      
         FValue=ori
      else if (iMode.eq.11) then
        do iEle=1,nActEle
         FValue(iEle)=abs(ori(iEle)-refOri)
         if (FValue(iEle).gt.1.570795) then
            FValue(iEle)=3.1415926-FValue(iEle)
         end if
         
        end do
    
      else if (iMode.eq.12) then
      
        FValue=numECon
        
      end if 
      
      if ((iMode.gt.4).and.(mMode.eq.1)) then
      
        FValue=FValue*areaEle
      
      end if
           
      valueMax=maxval(FValue(1:nActEle))
      valueMin=minval(FValue(1:nActEle))
      
      
      
      if (valueMax-valueMin.gt.1e-6) then
      
        if (iMode.ne.4) then  ! Translation
            if (jMode.eq.0) then
        
                relaMin=valueMin+
     $            (valueMax-ValueMin)/1000*(rangeContour(1)+500)
     
                relaMax=valueMin+
     $            (valueMax-ValueMin)/1000*(rangeContour(2)+500)

        
            else
        
                rangeContour(1)=(relaMin-valueMin)/(valueMax-ValueMin)
     $          *1000-500
            
                rangeContour(2)=(relaMax-valueMin)/(valueMax-ValueMin)
     $          *1000-500
     
                rangeContour(1)=min(500.,rangeContour(1))
                rangeContour(1)=max(-500.,rangeContour(1))
                rangeContour(2)=min(500.,rangeContour(2))
                rangeContour(2)=max(-500.,rangeContour(2))
                    
        
            end if
        
        else  ! Rotation
 
 
            if (jMode.eq.0) then
        
               relaMin=valueMin/1000*(500-rangeContour(1))
               relaMax=valueMax/1000*(rangeContour(2)+500)
            else
        
                rangeContour(1)=500-relaMin/valueMin*1000
                rangeContour(2)=relaMax/valueMax*1000-500
         
                rangeContour(1)=min(500.,rangeContour(1))
                rangeContour(1)=max(-500.,rangeContour(1))
                rangeContour(2)=min(500.,rangeContour(2))
                rangeContour(2)=max(-500.,rangeContour(2))
                    
        
            end if

 
      
        end if
      
      
      
        do iEle=1,nActEle
           
            if (iMode.ne.4) then
            

               relaValue=(FValue(iEle)-relaMin)/(relaMax-relaMin)
               
               
            else   !  for rotation, zero is always in the middle of the spectrum
               
               
               if (FValue(iEle).ge.0) then
                  relaValue=FValue(iEle)/relaMax+0.5
               else
                  relaValue=-FValue(iEle)/relaMin+0.5
               end if
            
            end if         
            
            relaValue=min(relaValue,1.)
            relavalue=max(0.,relaValue)
            
            if (kMode.eq.0) then

                call HSV2RGB(relaValue,TraceRGB(iEle,:))
            
            else if (kMode.eq.1) then
            
                Call Value2Gray(relaValue,TraceRGB(iEle,:))
            
            else
                TraceRGB(iEle,:)=0
                
            end if    
        end do
      
      end if
      
      end subroutine