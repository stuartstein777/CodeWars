// Reverse array
for i, j := 0, len(slc)-1; i < j; i, j = i+1, j-1 {
	slc[i], slc[j] = slc[j], slc[i]
}

// Number to digits
func NumberToDigits(n int) []int {

	var digits []int

	for {
		if n == 0 {
			break
		}
	
		r := n % 10
		n /= 10
		digits = append(digits, r)
	}
	Reverse(&digits)
	return digits
}
  
// Reverse string
func Reverse(s string) string {
	xs := []rune(str)
  
	for i, j := 0, len(xs)-1; i < j; i, j = i+1, j-1 {
		  xs[i], xs[j] = xs[j], xs[i]
	}
  
	return string(runes)
}
  
func gcd(a, b int) int {
	if a == 0 {
		return b
	}
	return gcd(b%a, a)
}

func RemoveItem[T any](idx int, xs []T) []T {
	if idx == 0 {
		return xs[1:]
	} else {
		return append(xs[:idx], xs[idx+1:]...)
	}
}

// Replace rune in a string at specified index
func replaceAtIndex(s string, r rune, idx int) string {
	out := []rune(s)
	out[idx] = r
	return string(out)
}
