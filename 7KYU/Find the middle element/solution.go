package kata

func Gimme(xs [3]int) int {
	if (xs[0] < xs[1] && xs[1] < xs[2]) ||
		(xs[2] < xs[1] && xs[1] < xs[0]) {
		return 1
	}

	if (xs[1] < xs[0] && xs[0] < xs[2]) ||
		(xs[2] < xs[0] && xs[0] < xs[1]) {
		return 0
	}

	if (xs[1] < xs[2] && xs[2] < xs[0]) ||
		(xs[0] < xs[2] && xs[2] < xs[1]) {
		return 2
	}

	return 0

}
