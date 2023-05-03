package kata

import "strings"

func ScoreWord(s string) int {
	score := 0
	for _, c := range s {
		score = score + (int(c) - 96)
	}
	return score
}

func High(s string) string {
	words := strings.Split(s, " ")
	res := ""
	highestScore := 0
	for _, word := range words {
		score := ScoreWord(word)
		if score > highestScore {
			highestScore = score
			res = word
		}
	}
	return res
}
