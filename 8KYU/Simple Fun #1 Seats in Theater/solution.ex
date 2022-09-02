defmodule SeatsInTheater do
  def seats_in_theater(n_cols, n_rows, col, row) do
    ((n_cols+1) - col) * (n_rows - row);
  end
end
