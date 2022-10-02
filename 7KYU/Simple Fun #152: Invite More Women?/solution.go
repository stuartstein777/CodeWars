package kata

func inviteMoreWomen(l []int) bool {
	total := 0

	for i := 0; i < len(l); i++ {
		total = total + l[i]
	}
	return total > 0
}
