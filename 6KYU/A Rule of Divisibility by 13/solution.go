package kata

func NumberToDigits(n int) ([]int, int) {
	var digits []int
	l := 0
	for {
		if n == 0 {
			break
		}
		r := n % 10
		n /= 10
		digits = append(digits, r)
		l += 1
	}

	return digits, l
}

func Thirt(n int) int {
	powers := []int{1, 10, 9, 12, 3, 4}
	x := 0
	for x <= 5 {
		digits, l := NumberToDigits(n)
		x += 1
		res := 0
		powerIdx := 0
		for i := 0; i < l; i++ {
			d := digits[i] * powers[powerIdx]
			res += d
			powerIdx += 1
			if powerIdx > 5 {
				powerIdx = 0
			}
		}
		if res == n {
			return res
		} else {
			n = res
		}
	}

	return 0

}
