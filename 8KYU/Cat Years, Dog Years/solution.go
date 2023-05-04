package kata

func CalculateYears(years int) (result [3]int) {
	dogAge := 0
	catAge := 0

	for i := 1; i <= years; i++ {
		if i == 1 {
			dogAge += 15
			catAge += 15
		} else if i == 2 {
			dogAge += 9
			catAge += 9
		} else {
			dogAge += 5
			catAge += 4
		}
	}
	return [3]int{years, catAge, dogAge}
}
