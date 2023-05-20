package kata

import (
	"sort"
)

func Comp(array1 []int, array2 []int) bool {
	if array1 == nil || array2 == nil {
		return false
	}
	l1 := len(array1)
	l2 := len(array2)

	for i := 0; i < l1; i++ {
		if array1[i] < 0 {
			array1[i] = -array1[i]
		}
	}

	sort.Ints(array1)
	sort.Ints(array2)

	if l1 != l2 {
		return false
	}

	for i := 0; i < l1; i++ {
		if array1[i]*array1[i] != array2[i] {
			return false
		}
	}
	return true
}
