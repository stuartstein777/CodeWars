function pillars(numpill, dist, width)
    numpill == 1 ? 0 : (((numpill -1) * dist) * 100) + ((numpill-2) * width)
end