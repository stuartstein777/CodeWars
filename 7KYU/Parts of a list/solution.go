package kata

import (
	"fmt"
	"strings"
)

func PartList(xs []string) string {
	l := len(xs)
	res := ""
	for i := 1; i < l; i++ {
		s1 := strings.Join(xs[0:i], " ")
		s2 := strings.Join(xs[i:], " ")
		res += fmt.Sprintf("(%s, %s)", s1, s2)
	}
	return res
}
