package kata

func Amidakuji(ar []string) []int {
	res := make([]int, len(ar[0])+1)

	for i := 0; i < len(res); i++ {
		res[i] = i
	}

	for _, s := range ar {
		for i := 0; i < len(s); i++ {
			if s[i] == '1' {
				res[i], res[i+1] = res[i+1], res[i]
			}
		}
	}
	return res
}
