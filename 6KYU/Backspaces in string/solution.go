package kata

func CleanString(s string) string {
	res := ""
	length := len(s)
	charsToSkip := 0
	for i := length - 1; i >= 0; i-- {
		if s[i] == '#' {
			charsToSkip = charsToSkip + 1
		} else {
			if charsToSkip > 0 {
				charsToSkip = charsToSkip - 1
			} else {
				res = string(s[i]) + res
			}

		}
	}
	return res
}
