package kata

import "math"

func getTotal(card, ticket int, perc float64, cnt int) float64 {
	d := float64(ticket) * perc
	return float64(card) + d*(1-(math.Pow(perc, float64(cnt))))/(1.0-perc)
}

func Movie(card, ticket int, perc float64) int {
	cnt := 1

	for {
		a := cnt * ticket
		b := getTotal(card, ticket, perc, cnt)

		if (float64(a) - float64(b)) > 1 {
			return cnt
		} else {
			cnt += 1
		}
	}
}
