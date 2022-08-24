package kata

func MaxMultiple(d, b int) int {
	max := 0
	for i := 1; i <= b; i++ {
		if i%d == 0 && i > max {
			max = i
		}
	}
	return max
}
