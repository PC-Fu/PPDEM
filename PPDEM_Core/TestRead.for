      Program Test
      implicit none
      
      integer i
      open (101, file = "test" )
      
      write (101, *) 0
      
      flush (101)
      
      rewind (101)
      
      read(101, *) i
      
      end 