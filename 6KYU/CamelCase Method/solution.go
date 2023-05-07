package kata

import (
  "fmt"
  "strings"
)

func CamelCaseWord(word string) string {
  println(word + fmt.Sprint(len(word)))
  return strings.ToUpper(string(word[0])) + string(word[1:])  
}

func CamelCase(s string) string {
  
  println("input: " + s)
  if(s == "") {
    return ""
  }
  xs := strings.Split(strings.Trim(s, " "), " ")
  var arr []string
  
  for _, w := range xs {
    arr = append(arr, CamelCaseWord(w))  
  }
  
  return strings.Join(arr, "")
}