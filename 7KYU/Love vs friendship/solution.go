package kata

func WordsToMarks(s string) int {
	res := 0
	for _, c := range s {
		res += int(c) - 96
	}
	return res
}
