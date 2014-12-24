	subroutine ImportLinksByID(nLinks,iEleLink, l0Link, kLinkPos, kLinkNeg, &
	                       nEle, xEle, yEle,  Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ImportLinksByID
	 !DEC$ ATTRIBUTES ALIAS:'ImportLinksByID' :: ImportLinksByID
	 !DEC$ ATTRIBUTES Reference :: nLinks, iEleLink, l0Link, kLinkPos, kLinkNeg, nEle, xEle, yEle, Filename
	
	
	integer nLinks, iEleLink(nLinks,2), lName, iLink, nEle
	double precision  l0Link(nLinks), kLinkPos(nLinks), kLinkNeg(nLinks), xEle(nEle), yEle(nEle), distance, rTemp

    
      CHARACTER*(lName) Filename

	open (177, file=Filename)



	if (nLinks .eq. 0) then
	  read (177, *) nLinks
	else
	  read (177, *) nLinks
	  do iLink = 1, nLinks
	      read (177, *) rTemp, rTemp, rTemp, rTemp, &
	                    l0Link(iLink), kLinkPos(iLink), kLinkNeg(iLink), &
	                    iEleLink(iLink,1), iEleLink(iLink,2)
                              
	      if (l0Link(iLink) .le. 0.0D0) then
	          l0Link(iLink) = (xEle(iEleLink(iLink,1)) - xEle(iEleLink(iLink,2)))**2 &
	                         +(yEle(iEleLink(iLink,1)) - yEle(iEleLink(iLink,2)))**2
	          l0Link(iLink) = l0Link(iLink)**0.5
	      end if
	      
	  end do
	end if
	
	close (177)
	end subroutine ImportLinksByID
