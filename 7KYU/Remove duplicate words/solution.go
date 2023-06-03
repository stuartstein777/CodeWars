package kata

import (
	"strings"
)

func RemoveDuplicateWords(str string) string {
	words := strings.Split(str, " ")
	used := map[string]interface{}{}
	res := []string{}

	for _, word := range words {
		if _, ok := used[word]; !ok {
			res = append(res, word)
			used[word] = nil
		}
	}

	return strings.Trim(strings.Join(res, " "), " ")
}
