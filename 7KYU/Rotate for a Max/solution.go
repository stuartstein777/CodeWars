package kata

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
		v, _ := strconv.ParseInt(str, 10, 64)

		if v > max {
			max = v
		}
	}
	return max
}
