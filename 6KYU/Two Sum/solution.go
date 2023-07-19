package kata

func TwoSum(numbers []int, target int) [2]int {
	lenxs := len(numbers)

	for i := 0; i < lenxs-1; i++ {
		for j := i + 1; j < lenxs; j++ {
			if numbers[i]+numbers[j] == target {
				return [2]int{i, j}
			}
		}
	}

	return [2]int{}
}
