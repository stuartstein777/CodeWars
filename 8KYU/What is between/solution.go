package kata

func Between(a, b int) []int {
	xs := make([]int, b-a+1)
	c := 0
	for i := a; i <= b; i++ {
		xs[c] = i
		c = c + 1
	}
	return xs
}
