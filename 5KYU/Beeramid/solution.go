package kata

func NextLevelCost(level int, price float64) float64 {
	return float64(level) * float64(level) * price
}

func Beeramid(bonus int, price float64) int {
  totalCost := 0.0
	level := 1
	for {
		totalCost += NextLevelCost(level, price)
		level++
		if totalCost > float64(bonus) {
			level -= 2
			break
		}
	}
	return level
}
