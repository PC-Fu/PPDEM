      double precision Function TriArea(xA,yA,xB,yB,xC,yC)
      
      implicit none
      
      double precision xA,yA,xB,yB,xC,yC
      
      TriArea=abs(xA*yC-xA*yB+xB*yA-xB*yC+xC*yB-xC*yA)/2
      
      Return
      
      End function