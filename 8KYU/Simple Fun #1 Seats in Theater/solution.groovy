class Kata {
    static def seatsInTheater(totCols, totRows, col, row) {
        return ((totCols+1) - col) * (totRows - row);
    }
}
