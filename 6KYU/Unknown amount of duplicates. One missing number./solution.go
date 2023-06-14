package kata

import "sort"

func FindDupsMiss(arr []int) (int, []int) {
	sort.Ints(arr)
	occured := make(map[int]int)
	dupes := []int{}
	last := arr[0]
	missing := -1

	for i := 0; i < len(arr); i++ {
		v := arr[i]
		if v != last && v-last > 1 {
			missing = v - 1
		}
		if _, ok := occured[v]; ok {
			dupes = append(dupes, v)
		} else {
			occured[v] = 1
		}
		last = v
	}

	return missing, dupes
}
