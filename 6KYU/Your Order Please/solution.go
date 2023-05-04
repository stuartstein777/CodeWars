package kata

import (
	"regexp"
	"strconv"
	"strings"
)

func Order(sentence string) string {
	words := strings.Split(sentence, " ")
	wordsIndexes := make(map[int]string)
	biggest := 0

	re := regexp.MustCompile("\\d+")

	for _, word := range words {
		ns := re.FindString(word)
		n, _ := strconv.Atoi(ns)
		wordsIndexes[n] = word

		if n > biggest {
			biggest = n
		}
	}

	var res []string
	for i := 1; i <= biggest; i++ {
		res = append(res, wordsIndexes[i])
	}
	return strings.Join(res, " ")
}
