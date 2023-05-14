package main

import (
	"fmt"
	"strings"
)

func main() {
	xs := []string{"az", "toto", "picaro", "zone", "kiwi"}

	l := len(xs)
	res := []string{}
	for i := 1; i < l; i++ {
		s1 := strings.Join(xs[0:i], " ")
		s2 := strings.Join(xs[i:], " ")
		res = append(res, fmt.Sprintf("(%s, %s)", s1, s2))
	}

	fmt.Println(fmt.Sprint(res))
}
