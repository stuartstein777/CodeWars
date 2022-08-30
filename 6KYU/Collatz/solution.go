package kata

import (
	"fmt"
	"strconv"
)

func appendN(s string, n int) string {
	if s == "" {
		return strconv.Itoa(n)
	} else {
		return s + "->" + strconv.Itoa(n)
	}
}

func Collatz(n int) string {
	res := ""

	for {
		fmt.Println(n)
		fmt.Println(res)
		if n == 1 {
			res = appendN(res, n)
			return res
		}
		res = appendN(res, n)

		if n%2 == 0 {
			n = n / 2
		} else {
			n = (3 * n) + 1
		}
	}

	return res
}
