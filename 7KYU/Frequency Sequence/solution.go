package kata

import (
  "fmt"
  "strings"
)

func Frequencies(s string) map[rune]int {
  xs := map[rune]int{}
  
  for _, c := range s {
    xs[c]+=1  
  }
  
  return xs
}

func FreqSeq(str string, sep string) string {
  freqs := Frequencies(str)
  res := []string{}
  
  for _, c := range str {
    res = append(res, fmt.Sprint(freqs[c]))
  }
  return strings.Join(res, sep)
}