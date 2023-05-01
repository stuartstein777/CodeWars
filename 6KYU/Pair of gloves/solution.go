package kata

func NumberOfPairs(gloves []string) int {
	glovesColours := make(map[string]int)

	for _, glove := range gloves {
		glovesColours[glove] = glovesColours[glove] + 1
	}

	var count int = 0

	for _, v := range glovesColours {
		count = count + (v / 2)
	}

	return count
}
