package kata

import (
	"strings"
)

func row(xs string) string {
	w := len(xs)
	s := []string{}
	for i := 0; i < w; i++ {
		s = append(s, " "+string(xs[i])+" ")
	}
	return "|" + strings.Join(s, "|") + "|"
}

func seperator(w int) string {
	s := []string{}
	for i := 0; i < w; i++ {
		s = append(s, "---")
	}
	return "+" + strings.Join(s, "+") + "+"
}

func Dot(w, h int, parts []string) string {
	rows := []string{}
	rows = append(rows, seperator(w))
	for i := 0; i < h; i++ {
		rows = append(rows, row(parts[i]))
		if h-i > 1 {
			rows = append(rows, seperator(w))
		}
	}
	rows = append(rows, seperator(w))
	return strings.Join(rows, "\n")
}

func Partition(s string, n int) []string {
	res := []string{}
	for i := 0; i < len(s); i += n {
		res = append(res, s[i:i+n])
	}
	return res
}

func pattern(rows int, columns int, s string) string {
	l := len(s)
	if l < rows*columns {
		s += strings.Repeat(" ", rows*columns-l)
	}
	parts := Partition(s, columns)
	return Dot(columns, rows, parts)
}
