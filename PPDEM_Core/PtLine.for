	subroutine PtLine(x0,y0,x1,y1,x2,y2,x3,y3,dist)
	implicit none
		double precision x1,y1,x2,y2,x0,y0,x3,y3,dist
		double precision x2x1,y2y1,xy2
		x2x1=x2-x1
		y2y1=y2-y1 
		xy2=x2x1**2+y2y1**2
		x3=((y0-y1)*y2y1*x2x1+x0*x2x1**2+x1*y2y1**2)/xy2
		y3=((x0-x1)*y2y1*x2x1+y1*x2x1**2+y0*y2y1**2)/xy2
		dist=sqrt((x0-x3)**2+(y0-y3)**2)
	
	end subroutine PtLine