package kata

func SumDigits(a int) int {
	res := 0
	for {
		if a == 0 {
			break
		}
		d := a % 10
		a /= 10
		res += d
	}
	return res
}

func TestIt(a, b int) int {
	return SumDigits(a) * SumDigits(b)
}
