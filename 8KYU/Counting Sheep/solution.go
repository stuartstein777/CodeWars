package kata

func CountSheeps(numbers []bool) int {
	sheep := 0

	for i := 0; i < len(numbers); i++ {
		if numbers[i] == true {
			sheep = sheep + 1
		}
	}

	return sheep
}
