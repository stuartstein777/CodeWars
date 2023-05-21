package kata

import "fmt"

func Solve(s string, a, b int) string {
	fmt.Printf("%s\n%d %d\n", s, a, b)
	if b > len(s) {
		b = len(s) - 1
	}
	s1 := s[:a]
	s2 := s[b+1:]

	// reverse sr
	r := []rune(s[a : b+1])

	for i, j := 0, len(r)-1; i < j; i, j = i+1, j-1 {
		r[i], r[j] = r[j], r[i]
	}

	sr := string(r)

	return s1 + sr + s2
}
