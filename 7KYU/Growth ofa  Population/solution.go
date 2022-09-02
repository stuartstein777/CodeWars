package kata

import "math"

func NbYear(p0 int, percent float64, aug int, p int) int {
	years := 0
	for p0 < p {
		p0 = int(math.Floor(float64(p0) + float64(aug) + (float64(p0) * (percent / 100.0))))
		years++
	}
	return years
}
