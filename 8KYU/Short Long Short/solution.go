package kata

import (
	"fmt"
)

func Solution(a, b string) string {
	if len(a) < len(b) {
		return fmt.Sprint(a, b, a)
	}
	return fmt.Sprint(b, a, b)
}
