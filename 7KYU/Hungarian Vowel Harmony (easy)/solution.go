package kata

// Dative returns the dative case for a given Hungarian word.
func Dative(word string) string {

	frontVowels := map[rune]interface{}{
		'e': nil, 'é': nil,
		'i': nil, 'í': nil,
		'ö': nil, 'ő': nil,
		'ü': nil, 'ű': nil}

	backVowels := map[rune]interface{}{
		'a': nil, 'á': nil,
		'o': nil, 'ó': nil,
		'u': nil, 'ú': nil}

	rs := []rune(word)
	l := len(rs)

	for i := l - 1; i >= 0; i-- {
		r := rs[i]
		if _, ok := frontVowels[r]; ok {
			return word + "nek"
		}
		if _, ok := backVowels[r]; ok {
			return word + "nak"
		}
	}
	return word
}
