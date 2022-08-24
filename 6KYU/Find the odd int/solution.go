package kata

func FindOdd(seq []int) int {
	var xs = make(map[int]int)

	for _, i := range seq {
		_, exists := xs[i]

		if exists {
			xs[i] = xs[i] + 1
		} else {
			xs[i] = 1
		}
	}

	for key, val := range xs {
		if val%2 != 0 {
			return key
		}
	}
	panic("No integer appeared an odd number of times")
}
