package kata

import (
	"strconv"
	"strings"
)

func HighAndLow(in string) string {
	nums := strings.Fields(in)
	max, _ := strconv.Atoi(nums[0])
	min, _ := strconv.Atoi(nums[0])

	for i := 1; i < len(nums); i++ {

		p, _ := strconv.Atoi(nums[i])
		if p > max {
			max = p
		}
		if p < min {
			min = p
		}
	}
	return strconv.Itoa(max) + " " + strconv.Itoa(min)
}
