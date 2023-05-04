package kata

func Transpose(matrix [][]int) [][]int {

	numRows := len(matrix)
	numCols := len(matrix[0])

	transposed := make([][]int, numCols)
	for i := range transposed {
		transposed[i] = make([]int, numRows)
	}

	for x := 0; x < len(matrix); x++ {
		for y := 0; y < len(matrix[x]); y++ {
			transposed[y][x] = matrix[x][y]
		}
	}

	return transposed
}
