package kata

func Solve(arr []int) int {
	found := make(map[int]interface{})
	res := 0

	for _, i := range arr {
		if _, ok := found[i]; !ok {
			res += i
			found[i] = nil
		}
	}

	return res
}
