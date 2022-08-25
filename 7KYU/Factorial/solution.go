package kata

func Factorial(n int) int {
	res := 1
	i := 1
	for {
		if i == n+1 {
			break
		} else {
			res = res * i
			i = i + 1
		}
	}
	return res
}
