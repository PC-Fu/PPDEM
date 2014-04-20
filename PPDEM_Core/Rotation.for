	SUBROUTINE Rotation(u,v,FM,MI,dt,globDamp)
	implicit none
	double precision u,v,a,FM,MI,dt,du,beta,globDamp

		a=(FM-v*MI*globdamp)/MI
		v=v+a*dt  !i+1/2
		u=u+v*dt	!i+1
		du=v*dt
	end subroutine Rotation
