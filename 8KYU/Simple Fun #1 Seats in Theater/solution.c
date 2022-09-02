int seats_in_theater(int n_cols, int n_rows, int col, int row)
{
    return ((n_cols+1) - col) * (n_rows - row);
}
