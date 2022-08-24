class Kata {
  static def isDivisible(n, x, y) {
    return (n.mod(x) == 0) && (n.mod(y) == 0)
  }
}