package kata

import (
	"fmt"
	"strings"
)

func PadErrorCount(errors int) string {
	s := fmt.Sprintf("%-6s", fmt.Sprint(errors))
	return s
}

func BuildHistogram(errors map[rune]int) string {
	res := []string{}

	if errors['u'] > 0 {
		res = append(res, "u  "+PadErrorCount(errors['u'])+strings.Repeat("*", errors['u']))
	}
	if errors['w'] > 0 {
		res = append(res, "w  "+PadErrorCount(errors['w'])+strings.Repeat("*", errors['w']))
	}
	if errors['x'] > 0 {
		res = append(res, "x  "+PadErrorCount(errors['x'])+strings.Repeat("*", errors['x']))
	}
	if errors['z'] > 0 {
		res = append(res, "z  "+PadErrorCount(errors['z'])+strings.Repeat("*", errors['z']))
	}
	return strings.Join(res, "\r")
}

func Hist(s string) string {
	errors := map[rune]int{
		'x': 0,
		'u': 0,
		'w': 0,
		'z': 0}

	for _, r := range s {
		if r == 'x' {
			errors['x'] += 1
		} else if r == 'u' {
			errors['u'] += 1
		} else if r == 'w' {
			errors['w'] += 1
		} else if r == 'z' {
			errors['z'] += 1
		}
	}

	return BuildHistogram(errors)
}
