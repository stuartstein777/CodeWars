class Kata {
    public static function past(h: Int, m: Int, s: Int): Int {
      return s * 1000 + m * 60000 + h * 3600000;
    }
}