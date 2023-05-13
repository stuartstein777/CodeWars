package kata

func PartsSums(ls []uint64) []uint64 {
	l := len(ls)
	if l == 0 {
		return []uint64{0}
	}
	res := make([]uint64, l+1)
	total := uint64(0)
	res[l] = total
	for i := l - 1; i >= 0; i-- {
		total += ls[i]
		res[i] = total
	}
	return res
}
