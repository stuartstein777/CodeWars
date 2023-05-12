package kata

import (
	"fmt"
	"strings"
)

func gcd(a, b int64) int64 {
	if a == 0 {
		return b
	}
	return gcd(b%a, a)
}

func AllCoPrimePairwise(xs []int64) bool {
	l := len(xs)
	for i := 0; i < l; i++ {
		for j := i + 1; j < l; j++ {
			if gcd(xs[i], xs[j]) != 1 {
				return false
			}
		}
	}
	return true
}

func ProductOfSystem(system []int64) int64 {
	n := int64(1)
	for _, s := range system {
		n *= s
	}
	return n
}

func FromNbToStr(n int64, system []int64) string {
	if AllCoPrimePairwise(system) && ProductOfSystem(system) > int64(n) {
		res := make([]string, len(system))
		for i, x := range system {
			res[i] = fmt.Sprint(int64(n) % x)
		}
		return "-" + strings.Join(res, "--") + "-"
	} else {
		return "Not applicable"
	}
}
