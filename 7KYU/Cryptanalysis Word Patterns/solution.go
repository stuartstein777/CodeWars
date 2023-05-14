package kata

import (
	"fmt"
	"strings"
)

func WordPattern(word string) string {
	word = strings.ToLower(word)
	res := []string{}
	c := 0
	var chars = make(map[rune]int)

	for _, letter := range word {
		if _, ok := chars[letter]; !ok {
			chars[letter] = c
			c++
		}
		res = append(res, fmt.Sprint(chars[letter]))
	}
	return strings.Join(res, ".")
}
