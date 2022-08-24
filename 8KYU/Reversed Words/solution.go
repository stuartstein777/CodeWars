package kata

import (
	"strings"
)

func ReverseArray(xs []string) {
	for i, j := 0, len(xs)-1; i < j; i, j = i+1, j-1 {
		xs[i], xs[j] = xs[j], xs[i]
	}
}

func ReverseWords(str string) string {
	xs := strings.Split(str, " ")

	for i, j := 0, len(xs)-1; i < j; i, j = i+1, j-1 {
		xs[i], xs[j] = xs[j], xs[i]
	}

	return strings.Join(xs, " ")
}
