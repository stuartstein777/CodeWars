package kata

func ReverseSeq(n int) []int {
	sol := make([]int, n)
	for i := n; i > 0; i-- {
		sol[n-i] = i
	}
	return sol
}
