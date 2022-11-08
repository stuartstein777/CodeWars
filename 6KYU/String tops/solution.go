package kata

func Tops(msg string) string {
	if msg == "" {
		return ""
	}

	res := ""
	n := 1
	idx := 1

	for {
		res = string(msg[idx]) + res
		n = n + 1
		idx = n * (2*n - 1)
		if idx >= len(msg) {
			break
		}
	}

	return res
}
