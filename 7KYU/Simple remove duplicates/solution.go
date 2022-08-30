package kata

func itemExists(numbers []int, i int) bool {

	for _, n := range numbers {
		if n == i {
			return true
		}
	}
	return false
}

func reverse(numbers []int) []int {
	reversed := make([]int, len(numbers))
	for i, j := 0, len(numbers)-1; i <= j; i, j = i+1, j-1 {
		reversed[i], reversed[j] = numbers[j], numbers[i]
	}
	return reversed
}

func Solve(arr []int) []int {
	rev := reverse(arr)
	distinct := make([]int, 0)

	for i := 0; i < len(arr); i++ {
		if !itemExists(distinct, rev[i]) {
			distinct = append(distinct, rev[i])
		}
	}

	return reverse(distinct)
}
