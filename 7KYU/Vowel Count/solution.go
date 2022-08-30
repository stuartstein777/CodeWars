package kata

import (
	"regexp"
)

func GetCount(str string) int {
	re := regexp.MustCompile(`[aeiou]`)
	return len(re.FindAllString(str, -1))
}
