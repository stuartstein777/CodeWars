func isLeapYear(_ year: Int) -> Bool {
  year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)
}
