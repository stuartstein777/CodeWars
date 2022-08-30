object LowIntSum {

  def sumTwoSmallest(numbers: List[Int]): Int = numbers.sorted.take(2).sum
}