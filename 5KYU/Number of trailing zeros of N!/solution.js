function zeros (n) {
    var res = 0;
    var i = 5;
    while(n / i >= 1) {
      res += Math.floor(n / i);
      i *= 5;
    }
    return res;
  }