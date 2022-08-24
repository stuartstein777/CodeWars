package kata

func LeastLarger(a []int, n int) int {
	diff := -1
	idx := -1

	for i := 0; i < len(a); i++ {
		if a[i] > a[n] && (diff == -1 || a[i]-a[n] < diff) {
			diff = a[i] - a[n]
			idx = i
		}
	}
	return idx
}
