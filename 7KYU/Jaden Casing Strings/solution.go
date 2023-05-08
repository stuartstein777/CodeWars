package kata

import "strings"

func ToJadenCase(str string) string {
  
  words := strings.Split(str, " ")
  jCased := []string{}
  
  for _, w := range words {
    jCased = append(jCased, strings.Title(w))  
  }
  
  return strings.Join(jCased, " ")
}