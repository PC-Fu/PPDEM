subroutine LinkForce(x1, y1, x2, y2, l0, kPos, kNeg, FLink, &
    m1, m2, vx1, vx2, vy1, vy2, dampingRatio)
implicit none
    double precision x1, y1, x2, y2, l0, kPos, kNeg, FLink(2), l
    double precision m1, m2, vx1, vx2, vy1, vy2, dampingRatio

    l = (x1-x2)**2 + (y1-y2)**2
    l = dsqrt(l)
    FLink(1) = x2 - x1
    FLink(2) = y2 - y1
    FLink = Flink / l

    if (l .ge. l0) then
        FLink = FLink * (l - l0) * kPos
    else
        FLink = FLink * (l - l0) * kNeg
    end if

    if (l .ge. l0) then
        FLink(1) = FLink(1) + 2* dampingRatio * dsqrt(kPos / (1/m1 + 1/m2)) * dsign(vx2 - vx1, (vx2 - vx1) * (x2-x1))
        FLink(2) = FLink(2) + 2* dampingRatio * dsqrt(kPos / (1/m1 + 1/m2)) * dsign(vy2 - vy1, (vy2 - vy1) * (y2-y1))
    else
        FLink(1) = FLink(1) + 2* dampingRatio * dsqrt(kNeg / (1/m1 + 1/m2)) * dsign(vx2 - vx1, (vx2 - vx1) * (x2-x1))
        FLink(2) = FLink(2) + 2* dampingRatio * dsqrt(kNeg / (1/m1 + 1/m2)) * dsign(vy2 - vy1, (vy2 - vy1) * (y2-y1))
    end if
    
end subroutine LinkForce  