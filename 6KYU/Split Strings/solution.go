package kata

func Solution(input string) []string {
	println(input)
	length := len(input)
	if length&1 != 0 {
		input = input + "_"
	}
	res := []string{}

	for i := 0; i <= length-1; i += 2 {
		res = append(res, input[i:i+2])
	}
	return res
}
