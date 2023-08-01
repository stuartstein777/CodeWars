package kata

func FindMissingLetter(chars []rune) rune {
	l := len(chars) - 1
	res := rune(0)

	for i := 0; i < l; i++ {
		if chars[i+1] != chars[i]+1 {
			res = chars[i] + 1
			break
		}
	}

	return rune(res)
}
