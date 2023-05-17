package kata

func GetIndexOf2LargestItems(xs []int) []int {
	if xs[0] >= xs[2] && xs[1] >= xs[2] {
		return []int{0, 1}
	}

	if xs[0] >= xs[1] && xs[2] >= xs[1] {
		return []int{0, 2}
	}

	return []int{1, 2}
}

func CanPlay(xs []int) bool {
	return (xs[0] > 0 && xs[1] > 0) ||
		(xs[0] > 0 && xs[2] > 0) ||
		(xs[1] > 0 && xs[2] > 0)
}

func Solve(xs []int) int {
	daysPlayed := 0

	for CanPlay(xs) {
		ys := GetIndexOf2LargestItems(xs)
		xs[ys[0]] -= 1
		xs[ys[1]] -= 1
		daysPlayed += 1
	}

	return daysPlayed
}
