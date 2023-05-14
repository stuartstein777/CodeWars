package kata

import (
	"strings"
)

func Reverse(s string) string {
	xs := []rune(s)

	for i, j := 0, len(xs)-1; i < j; i, j = i+1, j-1 {
		xs[i], xs[j] = xs[j], xs[i]
	}

	return string(xs)
}

func VertMirror(s string) string {
	xs := strings.Split(s, "\n")

	for i, x := range xs {
		xs[i] = Reverse(x)
	}

	return strings.Join(xs, "\n")
}

func HorMirror(s string) string {
	xs := strings.Split(s, "\n")
	for i, j := 0, len(xs)-1; i < j; i, j = i+1, j-1 {
		xs[i], xs[j] = xs[j], xs[i]
	}
	return strings.Join(xs, "\n")
}

type FParam func(string) string

func Oper(f FParam, x string) string {
	return f(x)
}
