package kata

import (
	"strconv"
)

func MultiTable(number int) string {
	s := ""

	for i := 1; i <= 10; i++ {
		s += strconv.Itoa(i) + " * " + strconv.Itoa(number) + " = " + strconv.Itoa((i * number))

		if i != 10 {
			s += "\n"
		}
	}
	return s
}
