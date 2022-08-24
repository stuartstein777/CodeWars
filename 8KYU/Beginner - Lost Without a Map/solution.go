package kata

func Maps(x []int) []int {
	s := make([]int, len(x))

	for idx, i := range x {
		s[idx] = i * 2
	}
	return s
}
