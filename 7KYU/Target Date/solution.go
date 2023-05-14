package kata

import (
	"time"
)

func DateNbDays(a int, p int, r int) string {
	i := 0
	t := float64(a)
	dailyInterest := float64(r) / 36000.0
	startDt := time.Date(2016, time.January, 1, 0, 0, 0, 0, time.UTC)
	for t < float64(p) {
		i++
		t += (t * dailyInterest)
	}

	dt := startDt.AddDate(0, 0, i)
	return dt.Format("2006-01-02")
}
