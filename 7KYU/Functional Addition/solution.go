package kata

func Add(x int) func(int) int {
	return func(n int) int {
		return x + n
	}
}
