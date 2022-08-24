package kata

func century(year int) int {
	if year <= 100 {
		return 1
	}

	if year%100 == 0 {
		return year / 100
	}

	return (year / 100) + 1
}
