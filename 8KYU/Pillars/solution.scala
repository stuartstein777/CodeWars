object Pillars {
  def distance(n: Int, d: Int, w: Int ): Int =
    if(n == 1) {
      return 0
    } else {
      return ((n -1) * d) * 100 + (n-2) * w
    }
}