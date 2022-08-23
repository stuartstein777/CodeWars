class Kata {
  public static function rowSumOddNumbers(n: Int): Int {
    var last = (n * n) + (n - 1);
    var start = last - (2 * (n-1));
    return Std.int(((start + last) / 2) * n);
  }
}