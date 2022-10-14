package kata

func BinToDec(bin string) int {
	res := 0
	p := 1
	for i := len(bin) - 1; i >= 0; i-- {
		if bin[i] == '1' {
			res = res + p
		}
		p = p * 2
	}
	return res
}
