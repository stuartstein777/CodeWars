package kata

import "math"

func StackHeight2d(layers int) float64 {
	if layers == 0 {
		return 0
	} else {
		return math.Sqrt(math.Pow(float64((layers-1)), 2)-math.Pow(((float64(layers-1))/2), 2)) + 1
	}
}
