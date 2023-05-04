package kata

func ToDigits(n int) []int {
	if n == 0 {
		return []int{0}
	}
	var digits []int
	i := 0
	for n != 0 {
		digits = append(digits, n%10)
		n /= 10
		i = i + 1
	}
	return digits
}

func Digitize(n int) []int {
	return ToDigits(n)
}
