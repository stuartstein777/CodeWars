package kata

import (
	"fmt"
	"strings"
)

func ToCsv(xs []int) string {
	ys := make([]string, len(xs))
	for i, x := range xs {
		ys[i] = fmt.Sprint(x)
	}
	return strings.Join(ys, ",")
}

func RangeToString(xs []int) string {
	l := len(xs)

	if l >= 3 {
		return fmt.Sprintf("%d-%d", xs[0], xs[l-1])
	} else {
		return ToCsv(xs)
	}
}

func Solution(xs []int) string {
	var res []string
	last := xs[0]
	currentRange := []int{last}
	l := len(xs)

	for i := 1; i < l; i++ {
		if xs[i] == last+1 {
			currentRange = append(currentRange, xs[i])
		} else {
			res = append(res, RangeToString(currentRange))
			currentRange = currentRange[:0]
			currentRange = append(currentRange, xs[i])
		}
		last = xs[i]
	}

	res = append(res, RangeToString(currentRange))
	return strings.Join(res, ",")
}
