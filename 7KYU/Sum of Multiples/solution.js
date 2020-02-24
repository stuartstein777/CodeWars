function sumMul(n,m){
  return (n <= 0 || m <= 0 || m < n || m == n)
    ? "INVALID"
    : [...Array(m).keys()].filter(f => f % n == 0).reduce((acc, i) => acc+i, 0);
}