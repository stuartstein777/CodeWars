package kata

func GrowingPlant(upSpeed, downSpeed, desiredHeight int) int {
	height := 0
	dayCount := 0

	for {
		dayCount = dayCount + 1
		height = height + upSpeed

		if height >= desiredHeight {
			return dayCount
		} else {
			height = height - downSpeed
		}
	}
}
