package kata

func Multiple3And5(n int) int {
	total := 0

	for i := 1; i < n; i++ {
		if i%3 == 0 || i%5 == 0 {
			total = total + i
		}
	}
	return total
}
