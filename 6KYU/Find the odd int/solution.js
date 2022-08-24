function findOdd(xs) {
    return xs.reduce((acc, i) => acc ^ i, 0);
  }