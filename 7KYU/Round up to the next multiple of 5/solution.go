package kata

func RoundToNext5(n int) int {
	for i := 0; i < 5; i++ {
		m := n + i
		if m%5 == 0 {
			return m
		}
	}
	return n
}
