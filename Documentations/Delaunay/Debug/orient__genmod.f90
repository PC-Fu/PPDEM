        !COMPILER-GENERATED INTERFACE MODULE: Tue Jan 25 14:48:23 2011
        MODULE ORIENT__genmod
          INTERFACE 
            SUBROUTINE ORIENT(X,Y,IX,IY,IX2,IY2,ICON,NT,MHALF,MFULL,    &
     &ISCLP,EPF)
              REAL(KIND=8) :: X(*)
              REAL(KIND=8) :: Y(*)
              INTEGER(KIND=4) :: IX(*)
              INTEGER(KIND=4) :: IY(*)
              INTEGER(KIND=4) :: IX2(*)
              INTEGER(KIND=4) :: IY2(*)
              INTEGER(KIND=4) :: ICON(6,*)
              INTEGER(KIND=4) :: NT
              INTEGER(KIND=4) :: MHALF
              INTEGER(KIND=4) :: MFULL
              INTEGER(KIND=4) :: ISCLP(*)
              REAL(KIND=8) :: EPF
            END SUBROUTINE ORIENT
          END INTERFACE 
        END MODULE ORIENT__genmod
