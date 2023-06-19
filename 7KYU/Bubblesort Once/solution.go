package kata

func BubblesortOnce(xs []int) []int {
	l := len(xs)
	res := make([]int, l)
	copy(res, xs)

	for i := 0; i < l-1; i++ {
		if res[i] > res[i+1] {
			t := res[i+1]
			res[i+1] = res[i]
			res[i] = t
		}
	}
	return res
}
