	subroutine SortArray(A,n)
	implicit none
    integer n, i, j
    double precision A(n), temp
    do i=1,n-2
        do j=1,n-i
            if (A(j).gt.A(j+1)) then
                temp = A(j)
                A(j) = A(j+1)
                A(j+1) = temp
            end if
         end do
      end do	
	end subroutine


