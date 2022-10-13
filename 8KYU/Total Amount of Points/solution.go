package kata

import (
	"strconv"
	"strings"
)

func ParseScore(game string) (int, int) {
	score := strings.Split(game, ":")
	home, _ := strconv.Atoi(score[0])
	away, _ := strconv.Atoi(score[1])
	return home, away
}

func Points(games []string) int {
	total := 0
	for _, game := range games {
		home, away := ParseScore(game)
		if home > away {
			total = total + 3
		} else if home == away {
			total = total + 1
		}
	}
	return total
}
