package kata

import (
	"math"
	"sort"
)

func MinDistance(n int) int {
	factors := []int{}

	for i := 1; float64(i) <= math.Sqrt(float64(n))+1; i++ {
		if n%i == 0 {
			factors = append(factors, i)

			if n/i != i {
				factors = append(factors, n/i)
			}
		}
	}

	sort.Slice(factors, func(i, j int) bool {
		return factors[i] < factors[j]
	})

	factorsCnt := len(factors)
	smallest := 0
	if factorsCnt >= 2 {
		smallest = factors[1] - factors[0]
	}

	for i := 1; i < factorsCnt-1; i++ {
		diff := factors[i+1] - factors[i]
		if diff < smallest {
			smallest = diff
		}
	}

	return smallest
	return 0
}
