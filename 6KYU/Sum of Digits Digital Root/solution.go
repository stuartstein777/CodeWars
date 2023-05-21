package kata

func Digits(n int) []int {
	var digits []int

	for {
		if n == 0 {
			break
		}

		r := n % 10
		n /= 10
		digits = append(digits, r)
	}
	return digits
}

func DigitalRoot(n int) int {
	if n < 10 {
		return n
	}
	digits := Digits(n)
	total := 0

	for _, d := range digits {
		total += d
	}
	return DigitalRoot(total)
}
