package kata


import (
	"strings"
)

func Reverse(s string) string {
  xs := []rune(s)

  for i, j := 0, len(xs)-1; i < j; i, j = i+1, j-1 {
		xs[i], xs[j] = xs[j], xs[i]
	}

  return string(xs)
}

func ReverseWords(str string) string {
  words := strings.Split(str, " ")

  for idx, w := range words {
    words[idx] = Reverse(w)    
  }
    
  return strings.Join(words, " ")
}