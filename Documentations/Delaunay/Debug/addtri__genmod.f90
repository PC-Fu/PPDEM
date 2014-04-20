        !COMPILER-GENERATED INTERFACE MODULE: Tue Jan 25 14:48:23 2011
        MODULE ADDTRI__genmod
          INTERFACE 
            SUBROUTINE ADDTRI(X,Y,IX,IY,IX2,IY2,ICON,EPF,MHALF,MFULL,   &
     &ISCLP,IVCUR,INDX,ISITE,ISADJ,ISCUR)
              REAL(KIND=8) :: X(*)
              REAL(KIND=8) :: Y(*)
              INTEGER(KIND=4) :: IX(*)
              INTEGER(KIND=4) :: IY(*)
              INTEGER(KIND=4) :: IX2(*)
              INTEGER(KIND=4) :: IY2(*)
              INTEGER(KIND=4) :: ICON(6,*)
              REAL(KIND=8) :: EPF
              INTEGER(KIND=4) :: MHALF
              INTEGER(KIND=4) :: MFULL
              INTEGER(KIND=4) :: ISCLP(*)
              INTEGER(KIND=4) :: IVCUR
              INTEGER(KIND=4) :: INDX
              INTEGER(KIND=4) :: ISITE
              INTEGER(KIND=4) :: ISADJ
              INTEGER(KIND=4) :: ISCUR
            END SUBROUTINE ADDTRI
          END INTERFACE 
        END MODULE ADDTRI__genmod
