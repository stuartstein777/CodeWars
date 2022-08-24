package kata

func ClosestMultipleOf10(n uint32) uint32 {
	remainder := n % 10

	if remainder < 5 {
		return n - remainder
	} else {
		return n + (10 - remainder)
	}
}
