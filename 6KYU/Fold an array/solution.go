package kata

func fold(xs []int) []int {
	l := len(xs)
	res := []int{}

	for i, j := 0, l-1; i < l/2; i, j = i+1, j-1 {
		res = append(res, xs[i]+xs[j])
	}

	if l&1 == 1 {
		res = append(res, xs[int32(l/2)])
	}
	return res
}

func FoldArray(xs []int, runs int) []int {
	res := make([]int, len(xs))
	copy(res, xs[:])

	for i := 0; i < runs; i++ {
		res = fold(res)
	}
	return res
}
