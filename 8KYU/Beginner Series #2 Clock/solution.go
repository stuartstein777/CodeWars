package kata

func Past(h, m, s int) int {
	return (s * 1000) + (m * 60000) + (h * 3600000)
}
