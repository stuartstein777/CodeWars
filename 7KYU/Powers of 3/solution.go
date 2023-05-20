package kata

import "math"

func LargestPower(n uint64) int {
	if n == 1 {
		return -1
	}
	r := 1
	for {
		if math.Pow(float64(3), float64(r)) >= float64(n) {
			r--
			break
		}
		r++
	}
	return r
}
