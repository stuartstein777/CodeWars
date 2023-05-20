package kata

func Solve(a, b int) []int {
	if a == 0 || b == 0 {
		return []int{a, b}
	} else if a >= 2*b {
		return Solve(a-2*b, b)
	} else if b >= 2*a {
		return Solve(a, b-2*a)
	} else {
		return []int{a, b}
	}
}
