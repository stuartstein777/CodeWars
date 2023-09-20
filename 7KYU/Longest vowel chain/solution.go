package kata

func isVowel(c rune) bool {
	return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
}

func Solve(s string) int {
  max := 0
	cur := 0
	for _, c := range s {
		if isVowel(c) {
			cur++
		} else {
			if cur > max {
				max = cur
			}
			cur = 0
		}
	}
	if cur > max {
		 return cur
	} else {
		 return max
	}
}