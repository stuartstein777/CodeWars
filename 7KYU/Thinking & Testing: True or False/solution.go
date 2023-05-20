package kata

import "strconv"

func Testit(n uint32) int {
	ones := 0

	binary := strconv.FormatInt(int64(n), 2)

	for _, c := range binary {
		if c == '1' {
			ones++
		}
	}

	return ones
}
