package kata

import "strings"

func Scale(s string, k, v int) string {

	if s == "" {
		return ""
	}

	lines := strings.Split(s, "\n")
	res := []string{}

	for _, l := range lines {
		s := ""
		for _, c := range l {
			s += strings.Repeat(string(c), k)
		}
		for i := 0; i < v; i++ {
			res = append(res, s)
		}
	}

	return strings.Join(res, "\n")
}
