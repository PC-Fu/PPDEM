	subroutine EleDrag(actEle,nEle,xEle,yEle,qEle,rEle,xCursor,
     $	rAnchor,cosQAc,sinQAc,FDrag,E)

	implicit none
	
	
	integer nEle,actEle

	double precision xEle(nEle),yEle(nEle),qEle(nEle),rEle(nEle)

	double precision xCursor(2),xAnchor(2),rAnchor

	double precision cosQAc,sinQAc,cosA,sinA,cosB,sinB,lAB
	
	double precision FDrag(3),E,Fx,Fy,FM

	actEle=actEle+1
	FDrag=0


	cosA=cosQAc*cos(qEle(actEle))-sinQAc*Dsin(qEle(actEle))
	sinA=sinQAc*cos(qEle(actEle))+cosQAc*Dsin(qEle(actEle))
	
		
	xAnchor(1)=xEle(actEle)+rAnchor*cosA
	xAnchor(2)=yEle(actEle)+rAnchor*sinA

	lAB=sqrt((xCursor(1)-xAnchor(1))**2+(xCursor(2)-xAnchor(2))**2)

	if (lAB.gt.1e-12) then
		cosB=(xCursor(1)-xAnchor(1))/lAB
		sinB=(xCursor(2)-xAnchor(2))/lAB
		FDrag(1)=0.0001*lAB*E*cosB
		FDrag(2)=0.0001*lAB*E*sinB
		FDrag(3)=-FDrag(1)*rAnchor*sinA+FDrag(2)*rAnchor*cosA


	
	
	
	end if

	
	actEle=actEle-1

	end subroutine 