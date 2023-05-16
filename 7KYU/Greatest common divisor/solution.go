package kata

func Gcd(x, y uint32) uint32 {
	if x == 0 {
		return y
	}
	return Gcd(y%x, x)
}
