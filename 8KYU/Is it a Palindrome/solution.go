package kata

import (
	"strings"
)

func reverse(s string) string {
	rns := []rune(s)
	for i, j := 0, len(rns)-1; i < j; i, j = i+1, j-1 {
		rns[i], rns[j] = rns[j], rns[i]
	}
	return string(rns)
}

func IsPalindrome(str string) bool {
	if reverse(strings.ToLower(str)) == strings.ToLower(str) {
		return true
	}
	return false
}
