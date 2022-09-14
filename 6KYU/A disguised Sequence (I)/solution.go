package kata

import (
	"math"
)

func Fct(n uint) uint {
	return uint(math.Pow(2, float64(n)))
}
