      subroutine BoxCN(x, y, lBox, CN,
     $   nEle,nActEle,xEle,yELe,
     $   nCon,xCon,yCon, flagConBoun, pairCon, flagEMask)
     
      implicit none    
     
       !DEC$ ATTRIBUTES DLLEXPORT :: BoxCN
	 !DEC$ ATTRIBUTES ALIAS:'BoxCN' :: BoxCN
	 !DEC$ ATTRIBUTES Reference :: 
     $   x, y, lBox, CN,
     $   nEle,nActEle,xEle,yELe,
     $   nCon,xCon,yCon, flagConBoun, pairCon, flagEMask
	 
	 
	 
	integer nEle, nActEle, nCon, nEleMask, nConMask

	double precision xEle(nEle),yEle(nEle),xCon(nEle*10),yCon(nEle*10)

      integer flagConBoun(nEle*10),flagEMask(nEle), pairCon(nEle*10,2)
      
      double precision x, y, lBox, CN
      
      integer iEle, iCon

      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!     
      !!!!!!!! Judge whether each element is masked   !!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      flagEMask = 0
      nEleMask = 0
      CN = 0
      do iEle=1,nActEle
          if ( (xEle(iEle).ge.(x-lBox/2)) .and.
     $           (xEle(iEle).le.(x+lBox/2)) .and.
     $          (yEle(iEle).ge.(y-lBox/2)) .and.
     $          (yEle(iEle).le.(y+lBox/2)) ) then
               
            flagEMask(iEle) = 1
            nEleMask=nEleMask+flagEMask(iEle)
          end if
         
      end do
      
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      !!!!!Calculate the coordination number !!!!!!!!!!!!!!!!!!!!
      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      
      do iCon=1,nCon
      
      
        if ( (flagConBoun(iCon).eq.0) .and. 
     $     (flagEMask(pairCon(iCon,1)).eq.1) ) then
            CN=CN+1        
        end if
        
        if ( (flagConBoun(iCon).eq.0) .and. 
     $     (flagEMask(pairCon(iCon,2)).eq.1) ) then
            CN=CN+1        
        end if

        if ( (flagConBoun(iCon).eq.2) .and. 
     $     (flagEMask(pairCon(iCon,1)).eq.1) ) then
            CN=CN+1        
        end if
        
      end do
      
      if (nEleMask > 0) then
        CN = CN/nEleMask   
      else
        CN = -1.0
      end if   
        
      end subroutine
      
       
