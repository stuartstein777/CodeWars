package kata

func PyramidHeight(n int) int {
	var i = 0

	for {
		i = i + 1

		n = n - (i * i)

		if n < 0 {
			return i - 1
		}

		if n == 0 {
			return i
		}
	}

	return i
}
