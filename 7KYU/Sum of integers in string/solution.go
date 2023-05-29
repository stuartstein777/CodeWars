package kata

import (
	"regexp"
	"strconv"
)

func SumOfIntegersInString(strng string) int {
	re := regexp.MustCompile(`\d+`)

	matches := re.FindAllString(strng, -1)
	res := 0
	for _, match := range matches {
		n, _ := strconv.Atoi(match)
		res += n
	}
	return res
}
