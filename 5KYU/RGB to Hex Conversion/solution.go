package kata

import (
	"fmt"
	"strings"
)

func Clamp(n int) int {
	if n < 0 {
		return 0
	}

	if n > 255 {
		return 255
	}

	return n
}

func RGB(r, g, b int) string {
	rx := strings.ToUpper(fmt.Sprintf("%02x", Clamp(r)))
	gx := strings.ToUpper(fmt.Sprintf("%02x", Clamp(g)))
	bx := strings.ToUpper(fmt.Sprintf("%02x", Clamp(b)))

	return rx + gx + bx
}
