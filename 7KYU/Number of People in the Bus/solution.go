package kata

func Number(busStops [][2]int) int {
	var total = 0
	for _, x := range busStops {
		total = total + x[0] - x[1]
	}
	return total
}
