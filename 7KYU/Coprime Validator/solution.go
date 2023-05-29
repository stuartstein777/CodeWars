package kata

func gcd(a, b int) int {
	if a == 0 {
		return b
	}
	return gcd(b%a, a)
}

func AreCoprime(n, m int) bool {
	return gcd(m, n) == 1
}
