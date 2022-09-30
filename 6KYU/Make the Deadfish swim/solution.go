package kata

func Parse(data string) []int {
	v := 0
	outputs := []int{}

	for i := 0; i < len(data); i++ {
		d := data[i]
		if d == 'i' {
			v = v + 1
		} else if d == 'd' {
			v = v - 1
		} else if d == 's' {
			v *= v
		} else if d == 'o' {
			outputs = append(outputs, v)
		}
	}
	return outputs
}
