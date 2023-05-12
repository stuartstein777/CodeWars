package kata

import "math"

func F(x float64) float64 {
	return x / (math.Sqrt(x+1) + 1)
}
