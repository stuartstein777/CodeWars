package kata

import (
	"fmt"
	"strings"
)

func Debug(nums []int) {
	fmt.Println(strings.Trim(fmt.Sprint(nums), "[]"))
}

func FindOutlier(nums []int) int {
	Debug(nums)
	if nums[0]&1 == nums[1]&1 && nums[2]&1 != nums[0]&1 {
		return nums[2]
	} else if nums[0]&1 != nums[1]&1 && nums[0]&1 != nums[2]&1 {
		return nums[0]
	} else if nums[0]&1 != nums[1]&1 && nums[0]&1 == nums[2]&1 {
		return nums[1]
	}

	for i := 3; i < len(nums); i++ {
		if (nums[i] & 1) != (nums[0] & 1) {
			return nums[i]
		}
	}

	return 0
}
