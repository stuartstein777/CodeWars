package kata

import "math"

func SquareOrSquareRoot(arr []int) []int {
	var res []int

	for _, a := range arr {
		sqrt := int(math.Sqrt(float64(a)))
		if sqrt*sqrt == a {
			res = append(res, int(math.Sqrt(float64(a))))
		} else {
			res = append(res, a*a)
		}
	}
	return res
}
