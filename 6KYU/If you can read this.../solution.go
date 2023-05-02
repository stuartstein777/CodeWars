package kata

import (
	"strings"
	"unicode"
)

func WordToNato(word string) string {
	nato := map[rune]string{
		'A': "Alfa",
		'B': "Bravo",
		'C': "Charlie",
		'D': "Delta",
		'E': "Echo",
		'F': "Foxtrot",
		'G': "Golf",
		'H': "Hotel",
		'I': "India",
		'J': "Juliett",
		'K': "Kilo",
		'L': "Lima",
		'M': "Mike",
		'N': "November",
		'O': "Oscar",
		'P': "Papa",
		'Q': "Quebec",
		'R': "Romeo",
		'S': "Sierra",
		'T': "Tango",
		'U': "Uniform",
		'V': "Victor",
		'W': "Whiskey",
		'X': "X-ray",
		'Y': "Yankee",
		'Z': "Zulu"}

	var res []string

	for _, c := range word {
		substitute, found := nato[unicode.ToUpper(c)]
		if found {
			res = append(res, substitute)
		} else {
			res = append(res, string(c))
		}
	}

	return strings.Join(res, " ")
}

func ToNato(message string) string {

	words := strings.Fields(message)
	var natoWords []string

	for _, word := range words {
		natoWords = append(natoWords, WordToNato(word))
	}

	return strings.Join(natoWords, " ")
}
