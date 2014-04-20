      subroutine InitPauseFile(curDir,lCurDir )
     
      implicit none
     
       !DEC$ ATTRIBUTES DLLEXPORT :: InitPauseFile
	 !DEC$ ATTRIBUTES ALIAS:'InitPauseFile' :: InitPauseFile
	 !DEC$ ATTRIBUTES Reference :: curDir
	
	integer lCurDir
	Character (len=lCurDir) curDir
	Character (len=lCurDIr+11) OutFile

      OutFile(1:lCurDir)=CurDir
      OutFile(lCurDir+1:lCurDir+11)="PauseMe.txt"
      
      open (3245, file=OutFile)
      
      write (3245, *) 0
      
      close (3245)
      
      end subroutine InitPauseFile
      
      
      subroutine ReadPauseFile(flagPause, curDir, lCurDir )
     
      implicit none
     
       !DEC$ ATTRIBUTES DLLEXPORT :: ReadPauseFile
	 !DEC$ ATTRIBUTES ALIAS:'ReadPauseFile' :: ReadPauseFile
	 !DEC$ ATTRIBUTES Reference :: flagPause, curDir
	
	integer lCurDir, flagPause
	Character (len=lCurDir) curDir
	Character (len=lCurDIr+11) OutFile

      OutFile(1:lCurDir)=CurDir
      OutFile(lCurDir+1:lCurDir+11)="PauseMe.txt"
      
      open (3245, file=OutFile)
      
      read (3245, *) flagPause
      
      close (3245)
      
      end subroutine ReadPauseFile

 

	
