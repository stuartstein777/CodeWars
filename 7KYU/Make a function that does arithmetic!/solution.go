package kata

func Arithmetic(a int, b int, operator string) int {
	if operator == "add" {
		return a + b
	}
	if operator == "subtract" {
		return a - b
	}
	if operator == "multiply" {
		return a * b
	}
	if operator == "divide" {
		return a / b
	}
	panic("invalid")
}
