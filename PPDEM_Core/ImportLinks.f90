	subroutine ImportLinks(nLinks, iEleLink, coordEleLink, l0Link, kLinkPos, kLinkNeg, &
	                       nEle, xEle, yEle, rEle, Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ImportLinks
	 !DEC$ ATTRIBUTES ALIAS:'ImportLinks' :: ImportLinks
	 !DEC$ ATTRIBUTES Reference :: nLinks, iEleLink, coordEleLink, l0Link, kLinkPos, kLinkNeg, nEle, xEle, yEle, rEle, Filename
	
	
	integer nLinks, iEleLink(nLinks,2), lName, iLink, nEle, iCoord
	double precision l0Link(nLinks), kLinkPos(nLinks), kLinkNeg(nLinks), xEle(nEle), yEle(nEle), rEle(nEle), coordEleLink(nLinks,4), iDis, jDis, distance, aveREle

    
      CHARACTER*(lName) Filename

	open (177, file=Filename)
    aveREle = 0.0
	do iCoord = 1, nEle
        aveREle = aveREle + rEle(iCoord)
    end do
    iDis = aveREle
    jDis = aveREle
    aveREle = aveREle / nEle
	if (nLinks .eq. 0) then
	  read (177, *) nLinks
	else
	  read (177, *) nLinks
	  do iLink = 1, nLinks
	      read (177, *) coordEleLink(iLink,1), coordEleLink(iLink,2), coordEleLink(iLink,3), coordEleLink(iLink,4), &
	                    l0Link(iLink), kLinkPos(iLink), kLinkNeg(iLink)
          
          do iCoord = 1, nEle
              distance = (xEle(iCoord) - coordEleLink(iLink,1))**2 &
                        +(yEle(iCoord) - coordEleLink(iLink,2))**2
              distance = distance**0.5
              if (distance .lt. iDis .and. rEle(iCoord) .le. 1.5*aveREle .and. rEle(iCoord) .ge. aveREle/1.5) then
                 iEleLink(iLink,1) = iCoord
                 iDis = distance
              end if
              distance = (xEle(iCoord) - coordEleLink(iLink,3))**2 &
                        +(yEle(iCoord) - coordEleLink(iLink,4))**2
              distance = distance**0.5
              if (distance .lt. jDis .and. rEle(iCoord) .le. 1.5*aveREle .and. rEle(iCoord) .ge. aveREle/1.5) then
                 iEleLink(iLink,2) = iCoord
                 jDis = distance
              end if
          end do
	      if (l0Link(iLink) .le. 0.0D0) then
	          l0Link(iLink) = (xEle(iEleLink(iLink,1)) - xEle(iEleLink(iLink,2)))**2 &
	                         +(yEle(iEleLink(iLink,1)) - yEle(iEleLink(iLink,2)))**2
	          l0Link(iLink) = l0Link(iLink)**0.5
              
              if (l0Link(iLink) .le. 0.0D0) then
                  iEleLink(iLink,2) = iEleLink(iLink,2) + 1
                  l0Link(iLink) = (xEle(iEleLink(iLink,1)) - xEle(iEleLink(iLink,2)))**2 &
	                             +(yEle(iEleLink(iLink,1)) - yEle(iEleLink(iLink,2)))**2
	              l0Link(iLink) = l0Link(iLink)**0.5
              end if
              
	      end if
	  end do
	end if
	
	close (177)
	
	end subroutine ImportLinks
