package kata

import (
	"strings"
)

func duplicate_count(s1 string) int {
	counts := make(map[rune]int)

	for _, char := range strings.ToLower(s1) {
		counts[char] = counts[char] + 1
	}

	dupes := 0

	for _, val := range counts {
		if val >= 2 {
			dupes = dupes + 1
		}
	}
	return dupes
}
