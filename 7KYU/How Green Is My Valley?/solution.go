package kata

import "sort"

func MakeValley(arr []int) []int {
	sort.Slice(arr, func(i, j int) bool {
		return arr[i] > arr[j]
	})

	evens := []int{}
	odds := []int{}

	for idx, x := range arr {
		if idx&1 == 0 {
			evens = append(evens, x)
		} else {
			odds = append(odds, x)
		}
	}

	l := len(odds)
	for i, j := 0, l-1; i < j; i, j = i+1, j-1 {
		odds[i], odds[j] = odds[j], odds[i]
	}

	return append(evens, odds...)
}
