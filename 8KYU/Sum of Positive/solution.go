package kata

func PositiveSum(numbers []int) int {
	x := 0

	for _, v := range numbers {
		if v > 0 {
			x = x + v
		}
	}

	return x
}
