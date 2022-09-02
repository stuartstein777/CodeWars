object Seats {

  def seatsInTheater(totCols: Int, totRows: Int, col: Int, row: Int): Int = {
    ((totCols+1) - col) * (totRows - row)
  }
}