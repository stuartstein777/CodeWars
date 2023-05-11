package kata

import (
	"regexp"
	"strconv"
	"strings"
)

func GetArrowsToReplace(s string) string {
	if s == "<" {
		return s
	}
	n, _ := strconv.Atoi(s[2:])
	res := ""
	for i := 0; i < n; i++ {
		res += "<"
	}
	return res
}

func Solve(s string) string {
	s = strings.Replace(s, "[backspace]", "<", -1)

	r := regexp.MustCompile(`<(?:\*\d+)?`)
	matches := r.FindAllStringSubmatch(s, -1)

	for _, match := range matches {
		replacement := GetArrowsToReplace(match[0])
		s = strings.Replace(s, match[0], replacement, 1)
	}

	res := ""
	l := len(s)
	backSpaceCnt := 0
	for i := l - 1; i >= 0; i-- {
		if s[i] == '<' {
			backSpaceCnt += 1
		} else {
			if backSpaceCnt == 0 {
				res = string(s[i]) + res
			} else {
				backSpaceCnt -= 1
			}
		}
	}

	return res
}
