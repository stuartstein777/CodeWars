package kata

func Smaller(arr []int) []int {
	l := len(arr)
	res := []int{}

	for i := 0; i < l; i++ {
		smaller := 0
		for j := i + 1; j < l; j++ {
			if arr[j] < arr[i] {
				smaller += 1
			}
		}
		res = append(res, smaller)
	}

	return res
}
