package kata

func SumDigits(n int) int {
  total := 0
  
  for {
    if n == 0 {
      break
    }
    
    total += n % 10
    n /= 10
  }
  return total
}

func SumDigNthTerm(initVal int, pattern []int, nth int) int {
  patternIdx := 0
  t:= initVal
  l := len(pattern)
  for i:=1; i < nth; i++ {
    t += pattern[patternIdx]
    patternIdx += 1
    if patternIdx == l {
      patternIdx = 0
    } 
  }
  
  return SumDigits(t)
}
