package kata

import "strconv"

func countOnes(s string) int {
	sum := 0
	for _, c := range s {
		if c == '1' {
			sum += 1
		}
	}
	return sum
}

func RangeBitCount(a,b int) int {
  noOnes := 0 
  for i:=a; i <=b; i++ {
    bin := strconv.FormatInt(int64(i), 2)
    noOnes += countOnes(bin)    
  }
  return noOnes
}