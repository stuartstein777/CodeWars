package kata

func Dominator(arr []int) int {
	l := len(arr)
	freqs := make(map[int]int)

	for _, i := range arr {
		freqs[i] += 1
	}

	for k, v := range freqs {
		if v > l/2 {
			return k
		}
	}
	return -1
}
