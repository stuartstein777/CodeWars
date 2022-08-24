package kata

import "sort"

func Reverse(xs []int) {
	for i, j := 0, len(xs)-1; i < j; i, j = i+1, j-1 {
		xs[i], xs[j] = xs[j], xs[i]
	}
}

func ToDigits(n int) []int {
	var digits []int
	i := 0
	for n != 0 {
		digits = append(digits, n%10)
		n /= 10
		i = i + 1
	}
	Reverse(digits)
	return digits
}

func BuildFinal(xs []int, d int) []int {
	a := xs[0 : d+1]
	b := xs[d+1:]
	sort.Ints(b)
	return append(a, b...)
}

func ToNumber(xs []int) int {
	res := 0
	op := 1
	for i := len(xs) - 1; i >= 0; i-- {
		res += xs[i] * op
		op *= 10
	}
	return res
}

func NextBigger(n int) int {
	digits := ToDigits(n)
	d := -1
	for i := len(digits) - 2; i >= 0; i-- {
		if digits[i] >= digits[i+1] {
			continue
		}
		d = i
		break
	}

	if d == -1 {
		return -1
	}

	e := d + 1

	for i := d + 1; i < len(digits); i++ {
		if digits[i] <= digits[d] || digits[i] > digits[e] {
			continue
		}
		e = i
	}

	t := digits[d]
	digits[d] = digits[e]
	digits[e] = t

	res := ToNumber(BuildFinal(digits, d))

	return res
}
