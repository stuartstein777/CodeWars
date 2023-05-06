package kata

import (
  "unicode"
)

func ToAlternatingCase(str string) string {
  res := ""
  
  for _, c := range str {
    if unicode.IsUpper(c) {
      res += string(unicode.ToLower(c))
    } else {
      res += string(unicode.ToUpper(c))
    }
  }
  
  return res
}