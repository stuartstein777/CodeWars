package kata

import (
	"strings"
)

func FindShort(s string) int {
	var words = strings.Split(s, " ")
	var shortest = len(s)

	for _, w := range words {
		var l = len(w)
		if l < shortest {
			shortest = l
		}
	}

	return shortest
}
