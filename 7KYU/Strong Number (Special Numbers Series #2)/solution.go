package kata

func GetDigits(n int) []int {
	var digits []int

	for {
		if n <= 0 {
			return digits
		}

		d := n % 10
		digits = append(digits, d)
		n = n / 10
	}
}

func Factorial(n int) int {
	res := 1

	for i := 1; i <= n; i++ {
		res *= i
	}

	return res
}

func Strong(n int) string {

	digits := GetDigits(n)
	sumFactorials := 0

	for i := 0; i < len(digits); i++ {
		sumFactorials = sumFactorials + Factorial(digits[i])
	}

	if sumFactorials == n {
		return "STRONG!!!!"
	} else {
		return "Not Strong !!"
	}
}
