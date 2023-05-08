package kata

import "unicode"

func Solve(s string) []int {
	upperCase := 0
  lowerCase := 0
  numbers := 0
  special := 0
  
  for _, c := range s {
    if unicode.IsUpper(c) {
      upperCase +=1
    } else if unicode.IsLower(c) {
      lowerCase += 1
    } else if unicode.IsDigit(c) {
      numbers += 1
    } else {
      special += 1
    }
  }
  
  return []int{upperCase, lowerCase, numbers, special}
}