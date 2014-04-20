      double precision Function SectorArea(lChord,R)
      implicit none
      double precision lChord,R,angC,aFan,aTri
      if (lChord.gt.1e-20)  then
      
        if (lChord/R.le.0.3) then
      
            SectorArea=exp(3.000035313*log(lChord/R)-2.483277557)*R**2
            
        else
            
            angC=asin(lChord/R/2)  ! half of the central angle
            aFan=angC*R**2
            aTri=lChord/2*R*cos(angC)
            SectorArea=aFan-aTri
        
        end if
      else
      SectorArea=0
      end if
      return
      end function