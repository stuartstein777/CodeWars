package kata

import (
	"strings"
)

func ModifyMultiply(str string, loc, num int) string {
	words := strings.Split(str, " ")
	word := words[loc]
	reps := []string{word}

	for i := 0; i < num-1; i++ {
		reps = append(reps, word)
	}

	return strings.Join(reps, "-")
}
