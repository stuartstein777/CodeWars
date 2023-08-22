package kata

func sum(numbers []int) int {

	length := len(numbers)
	sum := 0
	for i := 0; i < length; i++ {
		sum = sum + numbers[i]
	}
	return sum
}

func maxReduction(numbers []int) int {
	length := len(numbers)
	max := 0
	for i := 0; i < length; i++ {
		for j := i; j < length; j++ {
			x := sum(numbers[i : j+1])
			if x > max {
				max = x
			}
		}
	}
	return max
}

func MaximumSubarraySum(numbers []int) int {
	length := len(numbers)
	max := 0
	for i := 0; i < length; i++ {
		s := maxReduction(numbers[i:])
		if s > max {
			max = s
		}
	}
	return max
}
