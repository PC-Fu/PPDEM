	subroutine StrainCell(nEle,xEleTrace,yEleTrace,vXEle,vYEle,
     $   nStep,iStep,jStep,strain,drctStn,areaCell,numCell,eleStnCell,
     $   flagEffCell,flagStnOut,flagDrctStnOut,flagStnMode,angN)
     
       implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: StrainCell
	 !DEC$ ATTRIBUTES ALIAS:'StrainCell' :: StrainCell
	 !DEC$ ATTRIBUTES Reference :: 
     $   nEle,xEleTrace,yEleTrace,vXEle,vYEle,
     $   nStep,iStep,jStep,strain,drctStn,areaCell,numCell,eleStnCell,
     $   flagEffCell,flagStnOut,flagDrctStnOut,flagStnMode, angN
     
     
      integer nEle,nStep,iStep,jStep,numCell,flagEffCell(numCell),
     $  eleStnCell(numCell,3),flagStnOut,flagDrctStnOut,flagStnMode
      
      ! flagMode=1 if strain increment; =2 if strain rate
      
      double precision xEleTrace(nEle,nStep),yEleTrace(nEle,nStep),
     $  vXEle(nEle),vYEle(nEle),    
     $  strain(numCell),drctStn(numCell),angN, areaCell(numCell)
     
      integer iCell,E1,E2,E3
      
      double precision TriArea,areaI,areaJ,strainV,strainXX,strainYY,
     $   strainXY,strainYX,strainShear,strainI,strainII,
     $   gammaMax,shearFlowRate, u11,u12,u21,u22,u31,u32,
     $   A,B,C,D,E,angA,angB,angI,aSinCos
      
      
      !!!!!  Use tensor shear strain to enable the use of strain mohr circle.
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!  flagStnOut  type of outputs !!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!  flagStnOut=0  volumetric strain; =1 strainXX; =2 strainYY; =3 strainXY
      !!!!!  =4 major principal strain StainI; =5 minor principal strain StrainII; 
      !!!!!  =6 max shear strian gammaMax; =7 strainN in given direction; =8 shear strain in given direction StrainT
      !!!!!  =9 shear flow rate calculated based on the L matrix; =10 spin tensor value
      
      !!!!!  flagDrctStnOut=0 drctStn = shear flow direction
      !!!!!  flagDrctStnOut=1,  drctStn = direction of the max principal strain
      !!!!!  flagDrctStnOut=2,  drctStn = direction of the min principal strain
      !!!!!  flagDrctStnOut=3  drctStn = given direction
      !!!!!  flagDrctStnOut=4  drctStn = max shear strain direction
      
      do iCell=1,numCell
      
        if (flagEffCell(iCell).eq.1) then
        
            E1=eleStnCell(iCell,1)
            E2=eleStnCell(iCell,2)
            E3=eleStnCell(iCell,3)
            
            if (flagStnMode.eq.1) then
                u11=xEleTrace(E1,iStep)-xEleTrace(E1,jStep)
                u12=yEleTrace(E1,iStep)-yEleTrace(E1,jStep)
                u21=xEleTrace(E2,iStep)-xEleTrace(E2,jStep)
                u22=yEleTrace(E2,iStep)-yEleTrace(E2,jStep)
                u31=xEleTrace(E3,iStep)-xEleTrace(E3,jStep)
                u32=yEleTrace(E3,iStep)-yEleTrace(E3,jStep)
            else 
                u11=vXEle(E1)
                u12=vYEle(E1)
                u21=vXEle(E2)
                u22=vYEle(E2)
                u31=vXEle(E3)
                u32=vYEle(E3)
            end if
        
            areaI=TriArea( xEleTrace(E1,iStep),yEleTrace(E1,iStep),
     $                     xEleTrace(E2,iStep),yEleTrace(E2,iStep),
     $                     xEleTrace(E3,iStep),yEleTrace(E3,iStep))

            areaJ=TriArea( xEleTrace(E1,jStep),yEleTrace(E1,jStep),
     $                     xEleTrace(E2,jStep),yEleTrace(E2,jStep),
     $                     xEleTrace(E3,jStep),yEleTrace(E3,jStep))
     
            areaCell(iCell)=(areaI+areaI)/2
     
            strainXX =1.0/(areaI+areaJ)* 
     $               ( (yEleTrace(E2,jStep)-yEleTrace(E3,jStep))*u11 
     $                +(yEleTrace(E3,jStep)-yEleTrace(E1,jStep))*u21
     $                +(yEleTrace(E1,jStep)-yEleTrace(E2,jStep))*u31 )

            strainYY =1.0/(areaI+areaJ)* 
     $               ( (xEleTrace(E3,jStep)-xEleTrace(E2,jStep))*u12
     $                +(xEleTrace(E1,jStep)-xEleTrace(E3,jStep))*u22
     $                +(xEleTrace(E2,jStep)-xEleTrace(E1,jStep))*u32 )

            strainXY =1.0/(areaI+areaJ)* 
     $               ( (xEleTrace(E3,jStep)-xEleTrace(E2,jStep))*u11
     $                +(xEleTrace(E1,jStep)-xEleTrace(E3,jStep))*u21
     $                +(xEleTrace(E2,jStep)-xEleTrace(E1,jStep))*u31 )

            strainYX =1.0/(areaI+areaJ)* 
     $               ( (yEleTrace(E2,jStep)-yEleTrace(E3,jStep))*u12
     $                +(yEleTrace(E3,jStep)-yEleTrace(E1,jStep))*u22
     $                +(yEleTrace(E1,jStep)-yEleTrace(E2,jStep))*u32 )
        
            A=strainXX
            B=strainXY
            C=strainYX
            D=strainYY
            E=0.5*(B+C)
            
            strainShear=strainXY+strainYX  ! Engineering shear strain, not tensor

            if (flagStnMode.eq.1) then
                strainV=(areaI-areaJ)/areaJ
            else
                strainV=strainXX+strainYY
            end if

            gammaMax=sqrt( (strainXX-strainYY)**2+strainShear**2 )  
            ! Careful.  Strainshear is the engineering strain, so half of its value should be used in Mohr circle.
            
            strainI=0.5*(strainXX+strainYY)+gammaMax/2
            strainII=0.5*(strainXX+strainYY)-gammaMax/2
            
            if ( sqrt((D-A)**2+(B+C)**2).gt.1.0D-40) then
                angA=aSinCos( (D-A)/sqrt((D-A)**2+(B+C)**2), B+C )
            else
                angA=0
            end if
            
            if (C-B.ge.0) then
                angB=0.5*(3.1415926*0.5-angA)
            else
                angB=0.5*(3.1415926*1.5-angA)
            end if
            
            angI=aSinCos((strainXX-strainYY)/gammaMax,strainShear)/2.
            
            shearFlowRate = (A*cos(angB)+B*sin(angB))*(-sin(angB)) +
     $                      (C*cos(angB)+D*sin(angB))*cos(angB)    
            
            if (flagStnOut.eq.0) then
            
                Strain(iCell)=strainV
            
            else if (flagStnOut.eq.1) then
            
                Strain(iCell)=strainXX
            
            else if (flagStnOut.eq.2) then
            
                Strain(iCell)=strainYY
            
            else if (flagStnOut.eq.3) then
            
                Strain(iCell)=strainShear
            
            else if (flagStnOut.eq.4) then
            
                Strain(iCell)=strainI
            
            else if (flagStnOut.eq.5) then
            
                Strain(iCell)=strainII
            
            else if (flagStnOut.eq.6) then
            
                Strain(iCell)=gammaMax
            
            else if (flagStnOut.eq.7) then
            
                angI=angI*2.-angN*2.
                Strain(iCell)=(strainXX+StrainYY)/2+cos(angI)*gammaMax
            
            else if (flagStnOut.eq.8) then
            
                angI=angI*2.-angN*2.
                Strain(iCell)=sin(angI)*gammaMax
            
            else if (flagStnOut.eq.9) then
            
                Strain(iCell)=abs(shearFlowRate)
                
            else if (flagStnOut.eq.10) then
            
                Strain(iCell)= 0.5* (strainXY - strainYX)

            
            end if
            
            if (flagDrctStnOut.eq.0) then
                drctStn(iCell)=angB+3.1415926*0.5   ! B is the normal direction of the max flow 
                if (drctStn(iCell).lt.0) then
                    drctStn(iCell)=drctStn(iCell)+3.1415926
                else if (drctStn(iCell).gt.3.1415926) then
                    drctStn(iCell)=drctStn(iCell)-3.1415926
                end if
            else if (flagDrctStnOut.eq.1) then
                drctStn(iCell)=angI
            else if (flagDrctStnOut.eq.2) then
                drctStn(iCell)=angI+1.57
            else if (flagDrctStnOut.eq.3) then
                drctStn(iCell)=angN
            else if (flagDrctStnOut.eq.4) then
                drctStn(iCell)=angI+3.14159/4.0
            end if


        end if
      
      end do




      end subroutine StrainCell
      