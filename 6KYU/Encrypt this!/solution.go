package kata

import (
	"fmt"
	"strings"
)

func encryptWord(w string) string {
	fmt.Printf("Encrypting word **%s**", w)
	l := len(w)

	if l == 1 {
		return fmt.Sprint(w[0])
	}

	bytes := []byte(w)
	t := bytes[1]
	bytes[1] = bytes[l-1]
	bytes[l-1] = t
	return fmt.Sprintf("%d%s", w[0], string(bytes[1:]))
}

func EncryptThis(text string) string {
	if text == "" {
		return text
	}
	words := strings.Split(text, " ")

	res := []string{}

	for _, word := range words {
		res = append(res, encryptWord(word))
	}

	return strings.Join(res, " ")
}
