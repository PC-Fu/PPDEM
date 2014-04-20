	SUBROUTINE Translation(u,v,F,m,dt,globdamp)

	implicit none
		double precision u,v,a,F,dt,m,globdamp
		double precision beta
		a=(F-v*m*globdamp)/m   !i
		v=v+a*dt  !i+1/2
		u=u+v*dt	!i+1
	
	end subroutine
