	subroutine ColorValue(rValue, rMin, rMax, RGB)
	implicit none

	 !DEC$ ATTRIBUTES DLLEXPORT :: ColorValue
	 !DEC$ ATTRIBUTES ALIAS:'ColorValue' :: ColorValue
	 !DEC$ ATTRIBUTES Reference :: rValue, rMin, rMax, RGB
	
	integer RGB(3)
	double precision rValue, rMin, rMax, r
	
    r=(rValue-rMin)/(rMax-rMin)
    call HSV2RGB(r,RGB)
            
      
    end subroutine