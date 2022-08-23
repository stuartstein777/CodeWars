package kata

func CountBy(x, n int) []int {
	var res = make([]int, n)
	for i := 0; i < n; i++ {
		res[i] = ((i + 1) * x)
	}
	return res
}
