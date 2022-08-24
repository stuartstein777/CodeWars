package kata

func SequenceSum(start, end, step int) int {
	total := 0

	for i := start; i <= end; i += step {
		total = total + i
	}

	return total
}
