      subroutine NewVR(RGBBMPBase,wVRBox,hVRBox)

      implicit none
      
      
	 !DEC$ ATTRIBUTES DLLEXPORT :: NewVR
	 !DEC$ ATTRIBUTES ALIAS:'NewVR' :: NewVR
	 !DEC$ ATTRIBUTES Reference :: 
     $ RGBBMPBase,wVRBox,hVRBox
     
      integer wVRBox,hVRBox
      byte RGBBMPBase(4,wVRBox,hVRBox)
      
      
      end subroutine
