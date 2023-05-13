package kata

func BouncingBall(h, bounce, window float64) int {
	if h <= 0 || window > h || bounce <= 0 || bounce >= 1 {
		return -1
	}
	bounces := 0
	for {
		if h <= window {
			break
		}

		h = h * bounce
		bounces += 1
	}

	return ((bounces - 1) * 2) + 1
}
