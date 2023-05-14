package main

import (
	"fmt"
	"strconv"
)

func MaxRot(n int64) int64 {
	max := n
	str := fmt.Sprintf("%d", n)
	l := len(str)

	for i := 0; i < l-1; i++ {
		str = str[:i] + str[i+1:] + str[i:i+1]
		fmt.Println(str)
		v, _ := strconv.ParseInt(str, 10, 64)

		if v > max {
			max = v
		}
	}
	return max
}

func main() {
	fmt.Println(MaxRot(56789))
}

/*

56789
67895
68957
68579
68597

*/
