package kata

func FindUniq(arr []float32) float32 {
	if arr[0] == arr[1] && arr[2] != arr[0] {
		return arr[2]
	} else if arr[0] != arr[1] && arr[0] != arr[2] {
		return arr[0]
	} else if arr[0] != arr[1] && arr[0] == arr[2] {
		return arr[1]
	}

	for i := 3; i < len(arr); i++ {
		if arr[i] != arr[0] {
			return arr[i]
		}
	}

	return arr[0]
}
