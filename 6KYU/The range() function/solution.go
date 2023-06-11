package kata

func Range(start, end, step int) []int {
	res := []int{}

	if end < start {
		return res
	}

	itemsToAdd := (end - start)
	if step > 0 {
		itemsToAdd = (itemsToAdd / step) + 1
	}

	n := start
	i := 0

	for {
		if n >= end || i >= itemsToAdd {
			break
		}
		res = append(res, n)
		n += step
		i++
	}

	return res
}
