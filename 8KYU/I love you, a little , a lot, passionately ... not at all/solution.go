package kata

func HowMuchILoveYou(i int) string {
	phrases := []string{"I love you", "a little", "a lot", "passionately", "madly", "not at all"}
	return phrases[(i-1)%6]
}
