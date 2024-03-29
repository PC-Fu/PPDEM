	subroutine ImportLinks(nLinks, minR, maxR, iEleLink, l0Link, kLinkPos, kLinkNeg, &
	                       nEle, xEle, yEle, rEle, nActEle, Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ImportLinks
	 !DEC$ ATTRIBUTES ALIAS:'ImportLinks' :: ImportLinks
	 !DEC$ ATTRIBUTES Reference :: nLinks, minR, maxR, iEleLink, l0Link, kLinkPos, kLinkNeg, nEle, xEle, yEle, rEle, nActEle, Filename
	
	
	integer nLinks, iEleLink(nLinks,2), lName, iLink, nEle, iCoord, nActEle
	double precision  minR, maxR, l0Link(nLinks), kLinkPos(nLinks), kLinkNeg(nLinks), xEle(nEle), yEle(nEle), rEle(nEle), coordEleLink(4), oldCoordEleLink(4), iDis, jDis, distance

    
      CHARACTER*(lName) Filename

	open (177, file=Filename)



	if (nLinks .eq. 0) then
	  read (177, *) nLinks
	else
	  read (177, *) nLinks, minR, maxR
	  do iLink = 1, nLinks
	      read (177, *) coordEleLink(1), coordEleLink(2), coordEleLink(3), coordEleLink(4), &
	                    l0Link(iLink), kLinkPos(iLink), kLinkNeg(iLink)
          iDis = 1.0e6
          jDis = 1.0e6
          do iCoord = 1, nActEle
              distance = (xEle(iCoord) - coordEleLink(1))**2 &
                        +(yEle(iCoord) - coordEleLink(2))**2
              distance = distance**0.5
              if ((distance .lt. iDis) .and. (rEle(iCoord) .le. maxR) .and. (rEle(iCoord) .ge. minR)) then
                 iEleLink(iLink,1) = iCoord
                 iDis = distance
              end if
              distance = (xEle(iCoord) - coordEleLink(3))**2 &
                        +(yEle(iCoord) - coordEleLink(4))**2
              distance = distance**0.5
              if ((distance .lt. jDis) .and. (rEle(iCoord) .le. maxR) .and. (rEle(iCoord) .ge. minR)) then
                 iEleLink(iLink,2) = iCoord
                 jDis = distance
              end if
          end do
          if (iDis .eq. 1.0e6) then
              do iCoord = 1, nActEle
                  distance = (xEle(iCoord) - coordEleLink(1))**2 &
                            +(yEle(iCoord) - coordEleLink(2))**2
                  distance = distance**0.5
                  if ((distance .lt. iDis)) then
                     iEleLink(iLink,1) = iCoord
                     iDis = distance
                  end if
              end do
          end if
          if (jDis .eq. 1.0e6) then
              do iCoord = 1, nActEle
                  distance = (xEle(iCoord) - coordEleLink(3))**2 &
                            +(yEle(iCoord) - coordEleLink(4))**2
                  distance = distance**0.5
                  if ((distance .lt. jDis)) then
                     iEleLink(iLink,2) = iCoord
                     jDis = distance
                  end if
              end do
          end if
          if (iEleLink(iLink,1) .eq. iEleLink(iLink,2)) then
              jDis = 1.0e6
              do iCoord = 1, nActEle
                  distance = (xEle(iCoord) - coordEleLink(3))**2 &
                            +(yEle(iCoord) - coordEleLink(4))**2
                  distance = distance**0.5
                  if ((distance .lt. jDis) .and. (iCoord .ne. iEleLink(iLink,1))) then
                     iEleLink(iLink,2) = iCoord
                     jDis = distance
                  end if
              end do
          end if
          
          if (iLink .gt. 1) then
              if ((coordEleLink(1) .eq. oldCoordEleLink(3)) .and. (coordEleLink(2) .eq. oldCoordEleLink(4))) then
                 iEleLink(iLink,1) = iEleLink(iLink-1,2)
              end if
          end if
                              
	      if (l0Link(iLink) .le. 0.0D0) then
	          l0Link(iLink) = (xEle(iEleLink(iLink,1)) - xEle(iEleLink(iLink,2)))**2 &
	                         +(yEle(iEleLink(iLink,1)) - yEle(iEleLink(iLink,2)))**2
	          l0Link(iLink) = l0Link(iLink)**0.5
	      end if
	      oldCoordEleLink = coordEleLink
	      
	  end do
	end if
	
	close (177)
	end subroutine ImportLinks
