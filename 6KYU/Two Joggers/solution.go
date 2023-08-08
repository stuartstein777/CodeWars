package kata

func gcd(a, b int) int {
	if b == 0 {
		return a
	}
	return gcd(b, a%b)
}

func lcm(a, b int) int {
	if a == 0 {
		return 0
	} else {
		g := gcd(a, b)
		x := a * b
		res := x / g
		return res
	}
}

func NbrOfLaps(x, y uint16) [2]uint16 {
	lcm := lcm(int(x), int(y))
	xl := uint16(lcm / int(x))
	yl := uint16(lcm / int(y))
	return [2]uint16{xl, yl}
}
