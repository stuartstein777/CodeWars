package kata

func gcd(a, b int) int {
	for {
		if b == 0 {
			return a
		}
		c := a % b
		a = b
		b = c
	}
}

func Solve(s int, g int) []int {
	y := s - g
	if g == gcd(g, y) {
		return []int{g, y}
	} else {
		return []int{-1, -1}
	}
}
