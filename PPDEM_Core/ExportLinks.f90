	subroutine ExportLinks(nLinks, iEleLink, l0Link, kLinkPos, kLinkNeg, &
	                       nEle, xEle, yEle, Filename,lName)

	implicit none
	 !DEC$ ATTRIBUTES DLLEXPORT :: ExportLinks
	 !DEC$ ATTRIBUTES ALIAS:'ExportLinks' :: ExportLinks
	 !DEC$ ATTRIBUTES Reference :: nLinks, iEleLink, l0Link, kLinkPos, kLinkNeg, nEle, xEle, yEle, Filename
	
	
	integer nLinks, iEleLink(nLinks,2), lName, iLink, nEle, iCoord, i, j
	double precision  l0Link(nLinks), kLinkPos(nLinks), kLinkNeg(nLinks), xEle(nEle), yEle(nEle)
    
    CHARACTER*(lName) Filename

	open (158, file=Filename)

    write (158, *) nLinks, 0.0, 1.0e6, "maxR and minR are placeholders here."
    do iLink = 1, nLinks
        i = iEleLink(iLink,1)
        j = iEleLink(iLink,2)
        write (158, '(7e15.7, 2I8)') xEle(i), yEle(i), xEle(j), yEle(j), l0Link(iLink), kLinkPos(iLink), kLinkNeg(iLink), &
                      i, j
    end do
	write (158, *) "Note: You will have to manually change minR and maxR if you use this file in ImportByCoordinate.  Also, if you change element ID and then import the new file, you need to either manually correct the l0 value or change it to a negative value so that it is automatically recalculated when importing."
	close (158)
	end subroutine ExportLinks
