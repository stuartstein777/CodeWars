package kata

import "strings"

func DecodeMorse(morseCode string) string {
	trimmed := strings.Trim(morseCode, " ")
	words := strings.Split(trimmed, "   ")
	res := []string{}
	for _, word := range words {
		letters := strings.Split(word, " ")
		decodedWord := ""
		for _, letter := range letters {
			decodedWord += MORSE_CODE[letter]
		}
		res = append(res, decodedWord)
	}
	return strings.Join(res, " ")
}
