package kata

import (
  "strings"
  "unicode"
)

func MakeSection(s rune, n int) string  {
  res := string(unicode.ToUpper(s))
  
  for i := 0; i < n ; i++ {
    res += string(unicode.ToLower(s))
  }
  return res
}

func Accum(s string) string {
  s = strings.ToLower(s)
  var res []string
  for idx, letter := range s {
    res = append(res, MakeSection(letter, idx)) 
  }  
  return strings.Join(res, "-")
}