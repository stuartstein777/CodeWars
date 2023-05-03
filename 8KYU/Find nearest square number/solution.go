package kata

import (
	"math"
)

func NearestSq(n int) int {
	sq := int(math.Round(math.Sqrt(float64(n))))

	return sq * sq
}
