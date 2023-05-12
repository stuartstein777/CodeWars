package kata

import "unicode"

func ShiftLetter(c byte, shift int) byte {
	if c >= 'a' && c <= 'z' {
		return byte((int(c-'a')+shift)%26 + int('a'))
	} else if c >= 'A' && c <= 'Z' {
		return byte((int(c-'A')+shift)%26 + int('A'))
	} else {
		return c
	}
}

func GetNineComplement(c byte) byte {
	return byte('9' - (c - '0'))
}

func Reverse(xs []rune) {
	l := len(xs)
	for i, j := 0, l-1; i < j; i, j = i+1, j-1 {
		xs[i], xs[j] = xs[j], xs[i]
	}
}

func PlayPass(s string, n int) string {
	sb := []rune{}

	for i := 0; i < len(s); i++ {
		if unicode.IsLetter(rune(s[i])) {
			c := ShiftLetter(s[i], n)
			if i&1 == 0 {
				sb = append(sb, unicode.ToUpper(rune(c)))
			} else {
				sb = append(sb, unicode.ToLower(rune(c)))
			}
		} else if unicode.IsNumber(rune(s[i])) {
			sb = append(sb, rune(GetNineComplement(s[i])))
		} else {
			sb = append(sb, rune(s[i]))
		}
	}

	Reverse(sb)
	return string(sb)
}
