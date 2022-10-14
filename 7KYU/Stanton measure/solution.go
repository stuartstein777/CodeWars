package kata

func StantonMeasure(arr []int) int {

	oneCounts := 0
	for i := 0; i < len(arr); i++ {
		if arr[i] == 1 {
			oneCounts = oneCounts + 1
		}
	}
	x := 0

	for i := 0; i < len(arr); i++ {
		if arr[i] == oneCounts {
			x = x + 1
		}
	}

	return x
}
