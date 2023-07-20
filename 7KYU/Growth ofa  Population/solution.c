int nbYear(int p0, double percent, int aug, int p) {
    int years = 0;
  
    while(p0 < p) {
      p0 = (int)floor(p0 + aug + (p0 * percent / 100.0));
      years++;
    }
      
    return years;
}