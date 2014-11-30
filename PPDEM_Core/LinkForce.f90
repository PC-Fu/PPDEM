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

end subroutine LinkForce  
xEle(iEle), yEle(iEle), xEle(jEle), yEle(jEle),
     $         l0Link(iLink), kLinkPos(iLink), kLinkNeg(iLink),
     $         FLink,  mInertEle(iEle), mInertEle(jEle), vxEle(iEle), 
     $         vxEle(jEle), vyEle(iEle), vyEle(jEle),
     $         linkDampingRatio