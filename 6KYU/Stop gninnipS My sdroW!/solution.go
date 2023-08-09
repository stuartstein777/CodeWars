package kata

import "strings"

func Reverse(s string) string {
	runes := []rune(s)
	for i, j := 0, len(runes)-1; i < j; i, j = i+1, j-1 {
		runes[i], runes[j] = runes[j], runes[i]
	}
	return string(runes)
}

func SpinWords(str string) string {
	words := strings.Split(str, " ")
	resWords := []string{}
	for _, word := range words {
		if len(word) >= 5 {
			resWords = append(resWords, Reverse(word))
		} else {
			resWords = append(resWords, word)
		}
	}

	return strings.Join(resWords, " ")
} // SpinWords
