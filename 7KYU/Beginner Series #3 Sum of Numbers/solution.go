package kata

func GetSum(a, b int) int {
	start := a
	end := b

	if a > b {
		start = b
		end = a
	}

	total := 0
	for i := start; i <= end; i++ {
		total = total + i
	}
	return total
}
