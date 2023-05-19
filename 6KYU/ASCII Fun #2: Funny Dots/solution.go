package kata

import "strings"

func row(w int) string {
	s := []string{}
	for i := 0; i < w; i++ {
		s = append(s, " o ")
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

func Dot(w, h int) string {
	rows := []string{}
	rows = append(rows, seperator(w))
	for i := 0; i < h; i++ {
		rows = append(rows, row(w))
		if h-i > 1 {
			rows = append(rows, seperator(w))
		}
	}
	rows = append(rows, seperator(w))
	return strings.Join(rows, "\n")
}
