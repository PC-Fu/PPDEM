      subroutine IniOutput(eleOut,eleMaskOut,Filename,lName,
     $  curDir,lCurDir )
     
      implicit none
     
       !DEC$ ATTRIBUTES DLLEXPORT :: IniOutput
	 !DEC$ ATTRIBUTES ALIAS:'IniOutput' :: IniOutput
	 !DEC$ ATTRIBUTES Reference :: eleOut,eleMaskOut,Filename,curDir
	
	integer eleOut(0:1000),eleMaskOut(0:100,0:8),i,j,lName,lCurDir
	CHARACTER*(lName) Filename
	Character (len=lCurDIr) curDir
	Character (len=lCurDIr+11) OutFile


      open (145,file=FileName)
      
      
      read (145,*) eleOut(0)
      
      do i=1,eleOut(0)
        read(145,*) eleOut(i)
      end do
      
      read (145,*) eleMaskOut(0,0)
      
      do i=1,eleMaskOut(0,0)
      read(145,*) eleMaskOut(i,0),(eleMaskOut(i,j),j=1,eleMaskOut(i,0))
      end do

      OutFile(1:lCurDir)=CurDir
      OutFile(lCurDir+1:lCurDir+11)="Out_Sys.dat" 
      open (1000, file=OutFile)
      OutFile(1:lCurDir)=CurDir
      OutFile(lCurDir+1:lCurDir+11)="Out_Ele.dat"
      open (2000, file=OutFile)
      OutFile(1:lCurDir)=CurDir
      OutFile(lCurDir+1:lCurDir+11)="Out_Fbr.dat"
      open (3000, file=OutFIle)
      OutFile(1:lCurDir)=CurDir
      OutFile(lCurDir+1:lCurDir+11)="Out_Sts.dat"
      open (4000, file=OutFIle)
      OutFile(1:lCurDir)=CurDir
      OutFile(lCurDir+1:lCurDir+11)="Out_Wal.dat"
      open (5000, file=OutFIle)
         
      write (1000,'(4A8,100A14)') "iStep","iLoad","subStep",
     $ "nPair","PotnEngy","maxVel","OverlapRatio"
     
      write (5000,'(A8,100A14)')
     $  "iStep","xWall1","yWall1","xWall2","yWall2","xWall3","yWall3",
     $  "xWall4","yWall4","FxWall1","FyWall1","FxWall2","FyWall2",
     $  "FxWall3","FyWall3","FxWall4","FyWall4","BulkVol"    
     
      write (2000,'(A8,500I14)')
     $ "iEle", ((eleOut(i),eleOut(i),eleOut(i)),i=1,eleOut(0))
     
      write (2000,'(A8,500A14)')
     $  "iStep", (("xEle","yEle","thetaEle"),i=1,eleOut(0))
     
      write (3000,'(A8,A56,"   *   ",100(A30,i3,23X,"   *   "))')
     $  "Masks","Global          ",(("Mask",i),i=1,eleMaskOut(0,0) )
      write (4000,'(A8,A56,"   *   ",100(A30,i3,23X,"   *   "))')
     $  "Masks","Global          ",(("Mask",i),i=1,eleMaskOut(0,0) )
     
      write (3000, '(A8,100(4A14,"   *   "))')  "iStep",
     $  (("Fabric11","Fabric12","Fabric21","Fabric22"),
     $  i=1,eleMaskOut(0,0)+1)
      write (4000, '(A8,100(4A14,"   *   "))')  "iStep",
     $  (("Stress11","Stress12","Stress21","Stress22"),
     $  i=1,eleMaskOut(0,0)+1)
     
      write (3000,'(I8,$)') 1
      write (4000,'(I8,$)') 1
      
     
      end subroutine