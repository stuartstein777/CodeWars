function arrayMadness(a, b) {
  return a.reduce((acc, n) => acc+(n*n), 0) >
         b.reduce((acc, n) => acc+(n*n*n), 0);
}