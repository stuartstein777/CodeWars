package kata

func SquareSum(numbers []int) int {
	var res = 0
	for a := 0; a < len(numbers); a++ {
		res = res + (numbers[a] * numbers[a])
	}
	return res
}
