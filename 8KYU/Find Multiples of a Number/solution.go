package kata

func FindMultiples(integer, limit int) []int {
	res := make([]int, int(limit/integer))
	c := 0
	for i := integer; i <= limit; i += integer {
		res[c] = i
		c = c + 1
	}
	return res
}
