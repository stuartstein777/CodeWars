package kata

func Zeros(n int) int {
	c := 0
	i := 5
	for {
		if n/i >= 1 {
			c = c + n/i
			i = i * 5
		} else {
			break
		}

	}
	return c
}
