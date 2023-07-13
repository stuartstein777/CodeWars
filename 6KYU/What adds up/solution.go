package kata

func toDict(arr []int) map[int]struct{} {

	res := make(map[int]struct{})

	for _, i := range arr {
		res[i] = struct{}{}
	}

	return res
}

func AddsUp(arr1, arr2, arr3 []int) [][3]int {
	totals := toDict(arr3)
	res := [][3]int{}

	for _, i := range arr1 {
		for _, j := range arr2 {
			tot := i + j
			if _, exists := totals[tot]; exists {
				res = append(res, [3]int{i, j, tot})
			}
		}
	}

	return res
}
