package kata

import (
	"fmt"
	"strings"
)

func ToCsvText(array [][]int) string {
	var rs []string

	for i := 0; i < len(array); i++ {
		var r []string

		for j := 0; j < len(array[i]); j++ {
			r = append(r, fmt.Sprint(array[i][j]))
		}
		rs = append(rs, strings.Join(r, ","))
	}

	return strings.Join(rs, "\n")
}
