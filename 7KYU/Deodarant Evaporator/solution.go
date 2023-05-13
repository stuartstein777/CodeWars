package kata

func Evaporator(content float64, evapPerDay int, threshold int) int {
	target := (float64(threshold) / 100.0) * content
	n := 0
	for {
		n += 1
		content -= (content * float64(evapPerDay) / 100.0)
		if content <= target {
			break
		}
	}
	return n
}
