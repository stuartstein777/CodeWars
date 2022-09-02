export function seatsInTheater(nCols: number, nRows: number, col: number, row: number) {
    return ((nCols+1) - col) * (nRows - row);
}