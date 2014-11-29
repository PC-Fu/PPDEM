subroutine LinkForce(x1, y1, x2, y2, l0, kPos, kNeg, FLink)
implicit none
    double precision x1, y1, x2, y2, l0, kPos, kNeg, FLink(2), l

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

end subroutine LinkForce  