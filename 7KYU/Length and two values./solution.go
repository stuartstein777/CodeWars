package kata

func Alternate(n int, firstValue string, secondValue string) []string {
	var res []string

	for i := 0; i < n; i += 2 {
		res = append(res, firstValue)
		if len(res) != n {
			res = append(res, secondValue)
		}

	}

	return res
}
