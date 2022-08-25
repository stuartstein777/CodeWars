package kata

import (
	"fmt"
)

func Derive(coefficient, exponent int) string {
	return fmt.Sprint(coefficient*exponent, "x^", exponent-1)
}
