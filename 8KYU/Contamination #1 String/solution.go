package kata

func Contamination(text, char string) string {
	if text == "" || char == "" {
		return ""
	}

	sol := ""
	for i := 0; i < len(text); i++ {
		sol = sol + string(char)
	}
	return sol
}
