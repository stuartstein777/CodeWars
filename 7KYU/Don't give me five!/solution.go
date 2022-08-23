package kata

import (
	"math"
)

func ContainsFive(n int) bool {

	for {
		if n == 0 {
			return false
		}
		if math.Abs(float64(n%10)) == 5 {
			return true
		}
		n = n / 10
	}
	return false
}
func DontGiveMeFive(start int, end int) int {
	total := 0
	for i := start; i <= end; i++ {
		if ContainsFive(i) == false {
			total = total + 1
		}
	}
	return total
}
