package kata

func HasUniqueChar(str string) bool {
	m := map[rune]int{}
	for _, s := range []rune(str) {
		_, found := m[s]
		if found {
			return false
		} else {
			m[s] = 1
		}
	}
	return true
}
