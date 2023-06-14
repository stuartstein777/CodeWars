package kata

func isVowel(c rune) bool {
	return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
}

func solve(str string) int {

	max := 0
	cur := 0

	for _, c := range str {
		if isVowel(c) {
			if cur > max {
				max = cur
			}
			cur = 0
		} else {
			cur += int(c) - 96
		}
	}

	if cur > max {
		max = cur
	}

	return max
}
