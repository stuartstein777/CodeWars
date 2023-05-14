package kata

import "strings"

func Compose(s1, s2 string) string {
	s1lines := strings.Split(s1, "\n")
	s2lines := strings.Split(s2, "\n")

	n := len(s1lines)
	res := []string{}
	for i := 0; i < n; i++ {
		s := string(s1lines[i][:i+1]) + s2lines[n-1-i][0:n-i]
		res = append(res, s)
	}

	return strings.Join(res, "\n")
}
