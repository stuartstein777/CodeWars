package kata

func Invert(arr []int) []int {
	var a []int
	aLen := len(arr)
	for i := 0; i < aLen; i++ {
		a = append(a, -arr[i])
	}

	return a
}
