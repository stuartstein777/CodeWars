package kata

func Interpreter(code string) string {
	memory := byte(0)
	res := []byte{}
	for _, c := range code {
		if c == '+' {
			if memory == 255 {
				memory = 0
			} else {
				memory += 1
			}
		} else if c == '.' {
			res = append(res, memory)
		}
	}

	return string(res[:])
}
