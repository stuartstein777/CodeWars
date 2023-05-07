// Reverse array
for i, j := 0, len(slc)-1; i < j; i, j = i+1, j-1 {
	slc[i], slc[j] = slc[j], slc[i]
}

// Number to digits
func Reverse(xs *[]int) {
	for i, j := 0, len(*xs)-1; i < j; i, j = i+1, j-1 {
		  (*xs)[i], (*xs)[j] = (*xs)[j], (*xs)[i]
	  }
  } 
  
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
  