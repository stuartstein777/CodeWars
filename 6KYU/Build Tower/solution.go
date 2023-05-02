package kata

func BuildRow(n, rowWidth int) string {
	row := ""
	for i := 0; i < n; i++ {
		row = row + "*"
	}

	if n < rowWidth {
		diff := (rowWidth - n)

		for i := 0; i < diff; i += 2 {
			row = " " + row + " "
		}
	}
	return row
}

func TowerBuilder(n int) []string {
	rowWidth := (2*n - 1)
	var res []string

	for i, j := 0, 1; i < n; i, j = i+1, j+2 {
		res = append(res, BuildRow(j, rowWidth))
	}
	return res
}
