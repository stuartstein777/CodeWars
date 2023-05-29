package kata

func BreakChocolate(n, m int) int {
	if n == 0 || m == 0 {
		return 0
	}
	return (n * m) - 1
}
