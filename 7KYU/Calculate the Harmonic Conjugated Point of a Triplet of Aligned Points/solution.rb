def harmon_pointTrip(xA, xB, xC)
    (((2.0 * xA * xB) - (xA * xC) - (xB * xC))/(xA + xB - (2.0 * xC))).round(4)
end