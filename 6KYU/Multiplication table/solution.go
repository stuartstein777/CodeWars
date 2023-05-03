package multiplicationtable

func MultiplicationTable(size int) [][]int {
	var res [][]int

	for i := 0; i < size; i++ {
		row := make([]int, size)
		res = append(res, row)
	}

	for i := 0; i < size; i++ {
		for j := 0; j < size; j++ {
			res[i][j] = (i + 1) * (j + 1)
		}
	}
	return res
}
