package kata

import (
	"strconv"
)

func Reverse(s string) string {
	runes := []rune(s)
	for i, j := 0, len(runes)-1; i < j; i, j = i+1, j-1 {
		runes[i], runes[j] = runes[j], runes[i]
	}
	return string(runes)
}

func Chunk(s string, n int) []string {
	var chunks []string
	for i := 0; i < len(s); i += n {
		if i+n <= len(s) {
			chunks = append(chunks, s[i:i+n])
		}
	}
	return chunks
}

func IsDigitsSumOfCubesEven(s string) bool {
	total := 0
	for _, c := range s {
		d, _ := strconv.Atoi(string(c))
		total += d * d * d
	}
	return total&1 == 0
}

func RotateLeft(s string) string {
	return string(s[1:]) + string(s[0])
}

func Revrot(s string, n int) string {

	if n <= 0 || s == "" {
		return ""
	}

	chunks := Chunk(s, n)

	res := ""
	for _, chunk := range chunks {
		if IsDigitsSumOfCubesEven(chunk) {
			res += Reverse(chunk)
		} else {
			res += RotateLeft(chunk)
		}
	}
	return res
}
