package main

import (
	"fmt"
	"strings"
)

// func Fusc(n int) int {
// 	total := 0
// 	for n != 0 {
// 		if n == 1 {
// 			total += 1
// 		}

// 		if n&1 == 0 {
// 			n /= 2
// 		} else {
// 			n = (n - 1) / 2
// 		}
// 	}
// 	return total
// }

func main() {
	var d = "abcd\nefgh\nijkl\nmnop"
	k := 2
	v := 3
	lines := strings.Split(d, "\n")
	res := []string{}

	for _, l := range lines {
		s := ""
		for _, c := range l {
			s += strings.Repeat(string(c), k)
		}
		for i := 0; i < v; i++ {
			res = append(res, s)
		}
	}

	fmt.Println(strings.Join(res, "\n"))
}
