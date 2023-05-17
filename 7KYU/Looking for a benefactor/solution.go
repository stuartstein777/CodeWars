package kata

import "math"

func Sum(arr []float64) float64 {
	sum := 0.0

	for _, a := range arr {
		sum += a
	}
	return sum
}

func NewAvg(arr []float64, navg float64) int64 {
	b := int64(math.Ceil((float64(len(arr))+1.0)*navg - Sum(arr)))
	if b < 0 {
		return -1
	}
	return b
}
