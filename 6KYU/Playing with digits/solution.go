package kata

import (
  "math"
)

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

func Sum(xs []int, p int) int {
  sum := 0.0
  
  for _, n := range xs {
    sum += math.Pow(float64(n), float64(p))
    p+=1
  }
  return int(sum)
}

func DigPow(n, p int) int {
  digits := NumberToDigits(n)
  sum := Sum(digits, p)

  if sum % n == 0 {
    return sum / n
  }
  return -1  
}