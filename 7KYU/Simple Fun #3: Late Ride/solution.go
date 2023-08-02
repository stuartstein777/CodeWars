package kata

func SumDigits(n int) int {
	res := 0
	for {
		if n == 0 {
			break
		}

		res = res + (n % 10)
		n /= 10
	}
	return res
}

func LateRide(n int) int {
	hours := n / 60
	n = n - (hours * 60)

	return SumDigits(n) + SumDigits(hours)
}
