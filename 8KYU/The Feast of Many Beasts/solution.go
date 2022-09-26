package kata

import (
	"strings"
)

func Feast(beast string, dish string) bool {
	return strings.HasPrefix(strings.ToLower(dish), strings.ToLower(beast[0:1])) &&
		strings.HasSuffix(strings.ToLower(dish), strings.ToLower(beast[len(beast)-1:]))
}
