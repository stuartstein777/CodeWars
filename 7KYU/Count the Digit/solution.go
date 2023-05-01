package kata

func getDigitCount(n int, d int) int {
	if n == d {
		return 1
	}
	var count int = 0

	for {
		if n%10 == d {
			count++
		}
		n = n / 10
		if n < 1 {
			break
		}
	}

	return count
}

func NbDig(n int, d int) int {
	var count int = 0

	for i := 0; i <= n; i++ {
		count = count + getDigitCount(i*i, d)
	}

	return count
}
