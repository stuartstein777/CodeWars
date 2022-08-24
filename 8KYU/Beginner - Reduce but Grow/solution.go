package kata

func Grow(arr []int) int {
	total := 1

	for i := 0; i < len(arr); i++ {
		total = total * arr[i]
	}
	return total
}
