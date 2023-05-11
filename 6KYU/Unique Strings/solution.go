package kata

import (
	"math/big"
	"strings"
)

func Factorial(n int) *big.Int {
	res := big.NewInt(1)

	for n > 0 {
		res.Mul(res, big.NewInt(int64(n)))
		n--
	}
	return res
}

func UniqCount(s string) *big.Int {
	s = strings.ToUpper(s)
	charCounts := make(map[rune]int)

	for _, char := range s {
		charCounts[char] += 1
	}

	t := Factorial(len(s))

	for _, count := range charCounts {
		t.Div(t, Factorial(count))
	}

	return t
}
