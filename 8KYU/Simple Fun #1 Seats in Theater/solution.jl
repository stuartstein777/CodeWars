module Solution
  export seatsintheater
  
  function seatsintheater(ncols, nrows, col, row)
     ((ncols+1) - col) * (nrows - row)
  end
end