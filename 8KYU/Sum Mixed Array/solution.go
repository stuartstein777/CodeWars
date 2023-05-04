package kata

import (
	"fmt"
	"strconv"
)

func SumMix(arr []any) int {
	total := 0
	length := len(arr)
	for i := 0; i < length; i++ {
		x := fmt.Sprint(arr[i])
		n, _ := strconv.Atoi(x)
		total += n
	}

	return total
}
