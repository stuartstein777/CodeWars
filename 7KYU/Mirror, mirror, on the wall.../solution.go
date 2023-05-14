package kata

import "sort"

func Mirror(data []int) []int {
	if len(data) == 0 {
		return []int{}
	}
	// copy data to not mutate data
	xs := make([]int, len(data))
	copy(xs, data)

	// sort xs
	sort.Slice(xs, func(i, j int) bool {
		return xs[i] < xs[j]
	})

	ys := make([]int, len(xs))
	copy(ys, xs)

	// reverse ys
	for i, j := 0, len(ys)-1; i < j; i, j = i+1, j-1 {
		ys[i], ys[j] = ys[j], ys[i]
	}
	// concat xs and reverse xs
	return append(xs, ys[1:]...)
}
