package kata

func SquaresInRect(l int, w int) []int {

	if l == w {
		return nil
	}

	res := []int{}
	for {
		if l == 0 || w == 0 {
			return res
		}

		if l < w {
			res = append(res, l)
			w -= l
		} else {
			res = append(res, w)
			l -= w
		}
	}
}
