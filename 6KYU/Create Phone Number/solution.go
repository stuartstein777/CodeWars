package kata

import (
	"fmt"
)

func CreatePhoneNumber(numbers [10]uint) string {
	a := ""
	b := ""
	c := ""

	for i := 0; i < 3; i++ {
		a += fmt.Sprint(numbers[i])
	}

	for i := 3; i < 6; i++ {
		b += fmt.Sprint(numbers[i])
	}

	for i := 6; i < len(numbers); i++ {
		c += fmt.Sprint(numbers[i])
	}

	return fmt.Sprintf("(%s) %s-%s", a, b, c)
}
