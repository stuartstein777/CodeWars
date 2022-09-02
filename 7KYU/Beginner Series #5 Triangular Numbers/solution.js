function isTriangular(t) {
    var sol = (Math.sqrt((1 + (8 * t))) - 1) * 0.5;
    return sol === Math.floor(sol);
}
  