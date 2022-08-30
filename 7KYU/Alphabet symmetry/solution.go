package kata

import (
	"strings"
)

func alphabetical(s string) int {
	cnt := 0
	s = strings.ToLower(s)
	alphabet := "abcdefghijklmnopqrstuvwxyz"
	for i := 0; i < len(s); i++ {
		if alphabet[i] == s[i] {
			cnt++
		}
	}
	return cnt
}

func solve(slice []string) []int {
	res := make([]int, len(slice))
	for i, s := range slice {
		res[i] = alphabetical(s)
	}
	return res
}
