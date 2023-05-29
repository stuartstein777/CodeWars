package kata

import "fmt"

func Seven(n int64) []int {
	steps := 0
	for {
		sn := len(fmt.Sprint(n))
		if sn < 3 {
			return []int{int(n), steps}
		}

		n = (n / 10) - (2 * (n % 10))
		steps += 1
	}
}
