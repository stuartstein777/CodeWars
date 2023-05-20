package kata

func Decode(roman string) int {
	conversions := map[rune]int{
		'I': 1,
		'V': 5,
		'X': 10,
		'L': 50,
		'C': 100,
		'D': 500,
		'M': 1000}

	l := len(roman)
	last := rune(roman[0])
	res := conversions[last]

	for i := 1; i < l; i++ {
		c := rune(roman[i])
		if c == 'V' && last == 'I' {
			res += 3
		} else if c == 'X' && last == 'I' {
			res += 8
		} else if c == 'L' && last == 'X' {
			res += 30
		} else if c == 'C' && last == 'X' {
			res += 80
		} else if c == 'D' && last == 'C' {
			res += 300
		} else if c == 'M' && last == 'C' {
			res += 800
		} else {
			res += conversions[c]
		}
		last = c
	}
	return res
}
