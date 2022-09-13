package kata

func JosephusSurvivor(n, k int) int {
	r := 0
	i := 1

	for {

		r = (r + k) % i
		i = i + 1

		if i == n+1 {
			break
		}
	}

	return r + 1
}
