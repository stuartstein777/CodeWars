package kata

func EachCons(arr []int, n int) [][]int {

	res := [][]int{}

	if n <= len(arr) {
		for i := 0; i < len(arr)-n+1; i++ {
			res = append(res, arr[i:i+n])
		}
	}

	return res
}
