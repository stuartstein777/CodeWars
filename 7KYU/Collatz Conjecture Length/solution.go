package kata

func Collatz(n int) int {

	c := 1
	for n != 1 {
		if n&1 == 0 {
			n /= 2
		} else {
			n = n*3 + 1
		}
		c++
	}
	return c
}
