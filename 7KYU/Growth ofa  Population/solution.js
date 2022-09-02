function nbYear(p0, percent, aug, p) {
    var years = 0;
    while(p0 < p)
    {
        p0 = Math.floor(p0 + aug + (p0 * percent  / 100));
        years++;
    }
    
    return years;
}