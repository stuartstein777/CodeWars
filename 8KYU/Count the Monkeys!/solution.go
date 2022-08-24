package kata

func monkeyCount(n int) []int {
	monkeys := make([]int, n)

	for i := 1; i <= n; i++ {
		monkeys[i-1] = i
	}
	return monkeys
}
