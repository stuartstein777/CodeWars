package kata

func FakeBin(x string) string {
	res := ""
	for _, char := range x {
		if char == '0' || char == '1' || char == '2' || char == '3' || char == '4' {
			res = res + "0"
		} else if char == '5' || char == '6' || char == '7' || char == '8' || char == '9' {
			res = res + "1"
		}
	}
	return res
}
