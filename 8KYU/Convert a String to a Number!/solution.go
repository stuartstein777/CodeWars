package kata

import "strconv"

func StringToNumber(str string) int {
	x, _ := strconv.Atoi(str)
	return x
}
