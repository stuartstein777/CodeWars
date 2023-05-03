package kata

import (
	"strings"
	"unicode"
)

func solve(str string) string {

	lowerCase := 0
	upperCase := 0
	for _, s := range str {
		if unicode.IsLower(s) {
			lowerCase = lowerCase + 1
		} else {
			upperCase = upperCase + 1
		}
	}

	if lowerCase >= upperCase {
		return strings.ToLower(str)
	}
	return strings.ToUpper(str)

}
