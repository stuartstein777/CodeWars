package kata

func ReverseList(lst []int) []int {
	res := []int{}
	l := len(lst)

	for i := l - 1; i >= 0; i-- {
		res = append(res, lst[i])
	}

	return res
}
