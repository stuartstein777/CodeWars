package kata

import (
	"sort"
)
 
func SumOfIntervals(xs [][2]int) int {
  res := 0
	sort.Slice(xs, func(i, j int) bool {
		if xs[i][0] != xs[j][0] {
			return xs[i][0] < xs[j][0]
		}
		return xs[i][1] < xs[j][1]
	})

	lenxs := len(xs)
	curIdx := 1   // current index of the sorted ranges
	curRange := xs[0]

	for {
		if curIdx == lenxs {
			res += (curRange[1] - curRange[0])
			break
		}

		if xs[curIdx][0] >= curRange[0] && xs[curIdx][0] <= curRange[1] && xs[curIdx][1] > curRange[1] {
			curRange[1] = xs[curIdx][1]
		} else if xs[curIdx][0] > curRange[1] {
			res += (curRange[1] - curRange[0])
			curRange = xs[curIdx]
		} 
		curIdx += 1
	}

	return res
}
