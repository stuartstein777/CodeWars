package kata

func SumEvenFibonacci(limit int) int {

	if limit == 1 {
		return 2
	}
	a, b := 1, 2
	res := 0
	for {
		c := a + b
		a = b
		b = c

		if a > limit {
			return res
		} else if a&1 == 0 {
			res += a
		}
	}
}
