package kata

func ExpressionMatter(a int, b int, c int) int {
	var xs []int
	xs = append(xs, a*(b*c))
	xs = append(xs, a*(b+c))
	xs = append(xs, a*b*c)
	xs = append(xs, a+b+c)
	xs = append(xs, (a+b)*c)
	xs = append(xs, (a*b)+c)

	max := xs[0]

	for _, x := range xs {
		if x > max {
			max = x
		}
	}
	return max
}
