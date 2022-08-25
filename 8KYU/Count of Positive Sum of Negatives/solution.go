package kata

func CountPositivesSumNegatives(numbers []int) []int {
	var res []int
	posCnt := 0
	sumNeg := 0

	for _, i := range numbers {
		if i > 0 {
			posCnt = posCnt + 1
		} else {
			sumNeg = sumNeg + i
		}
	}

	res = append(res, posCnt)
	res = append(res, sumNeg)
	return res
}
