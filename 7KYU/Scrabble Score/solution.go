package kata

import (
	"strings"
)

func ScrabbleScore(word string) int {
	score := 0
	for _, l := range strings.ToUpper(word) {
		score += DictScores[string(l)]
	}
	return score
}
