package kata

func HighestRank(nums []int) int {
	freqs := make(map[int]int)
	largestCnt := 0
	var largest int
	for _, n := range nums {
		cnt, found := freqs[n]
		cnt += 1
		if found {
			freqs[n] = cnt + 1
		} else {
			freqs[n] = 1
		}
		if cnt > largestCnt {
			largest = n
			largestCnt = cnt
		} else if cnt == largestCnt && n > largest {
			largest = n
		}
	}
	return largest
}
