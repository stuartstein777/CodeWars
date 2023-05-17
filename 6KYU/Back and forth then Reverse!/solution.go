package kata

func Arrange(s []int) []int {
	l := len(s)
	if l == 0 {
		return nil
	} else if l == 1 {
		return s
	}

	l -= 1
	aIdx := 0
	bIdx := l
	t := []int{s[aIdx], s[bIdx]}
	aInc := 1
	bInc := -1

	n := 0
	for n < l-1 {
		aIdx += aInc
		bIdx += bInc

		if bIdx >= 0 && bIdx <= l {
			t = append(t, s[bIdx])
			n++
		}
		if aIdx >= 0 && aIdx <= l && aIdx != bIdx {
			t = append(t, s[aIdx])
			n++
		}
		aInc *= -1
		bInc *= -1

		c := bIdx
		bIdx = aIdx
		aIdx = c
	}
	return t
}
