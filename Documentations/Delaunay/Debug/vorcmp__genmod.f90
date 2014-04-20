        !COMPILER-GENERATED INTERFACE MODULE: Tue Jan 25 14:48:23 2011
        MODULE VORCMP__genmod
          INTERFACE 
            SUBROUTINE VORCMP(IX,IY,IX2,IY2,XP,YP,ICON,IFL,NT,DSCLE,    &
     &MHALF,MFULL,ISCLP)
              INTEGER(KIND=4) :: IX(*)
              INTEGER(KIND=4) :: IY(*)
              INTEGER(KIND=4) :: IX2(*)
              INTEGER(KIND=4) :: IY2(*)
              REAL(KIND=8) :: XP(*)
              REAL(KIND=8) :: YP(*)
              INTEGER(KIND=4) :: ICON(6,*)
              INTEGER(KIND=4) :: IFL(*)
              INTEGER(KIND=4) :: NT
              REAL(KIND=8) :: DSCLE
              INTEGER(KIND=4) :: MHALF
              INTEGER(KIND=4) :: MFULL
              INTEGER(KIND=4) :: ISCLP(*)
            END SUBROUTINE VORCMP
          END INTERFACE 
        END MODULE VORCMP__genmod
