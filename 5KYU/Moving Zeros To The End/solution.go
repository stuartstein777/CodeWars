package kata

func MoveZeros(arr []int) []int {
	res := make([]int, len(arr))
	ci := 0
	zerosCount := 0
	for i := 0; i < len(arr); i++ {
		if arr[i] == 0 {
			zerosCount = zerosCount + 1
		} else {
			res[ci] = arr[i]
			ci = ci + 1
		}
	}

	for i := 0; i < zerosCount; i++ {
		res[ci] = 0
		ci = ci + 1
	}

	return res
}
