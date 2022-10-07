package kata

func BestMatch(a, b []int) int {
	smallestGoalDiff := a[0] - b[0]
	idx := 0
	g := b[0]

	for i := 1; i < len(a); i++ {
		goalDiff := a[i] - b[i]
		if goalDiff < smallestGoalDiff {
			smallestGoalDiff = goalDiff
			idx = i
			g = b[i]
		} else if goalDiff == smallestGoalDiff && b[i] > g {
			g = b[i]
			idx = i
		}
	}
	return idx
}
