package kata

func SuMin(m int) int64 {
	acc := int64(0)
	i := int64(1)
	for m > 0 {
		acc = acc + i*int64(m)
		i += 2
		m--
	}
	return acc
}

func SuMax(m int) int64 {
	acc := int64(0)
	i := int64((m * 2) - 1)

	for m >= 0 {
		acc = acc + i*int64(m)
		i -= 2
		m--
	}
	return acc
}

func SumSum(m int) int64 {
	return SuMax(m) + SuMin(m)
}
