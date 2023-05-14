package kata

func MinMax(arr []int) [2]int {
	res := [2]int{}
	min := arr[0]
	max := arr[0]
	l := len(arr)
	for i := 1; i < l; i++ {
		if arr[i] < min {
			min = arr[i]
		} else if arr[i] > max {
			max = arr[i]
		}
	}
	res[0] = min
	res[1] = max
	return res
}
