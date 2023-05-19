package kata

func Incrementer(xs []int) []int {
	res := []int{}

	for idx, n := range xs {
		res = append(res, (n+idx+1)%10)
	}

	return res
}
