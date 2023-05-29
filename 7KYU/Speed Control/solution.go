package kata

import "fmt"

func Gps(s int, x []float64) int {
	fmt.Sprintf("%v\n%d\n", x, s)
	max := 0.0
	l := len(x)

	for i := 1; i < l; i++ {
		cmax := ((x[i] - x[i-1]) * 3600.00) / float64(s)

		if cmax > max {
			max = cmax
		}
	}

	return int(max)
}
