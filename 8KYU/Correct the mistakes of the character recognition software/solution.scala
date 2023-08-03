object Recognition {
  def correct(s: String): String = s.replace("0", "O").replace("1", "I").replace("5", "S")
}