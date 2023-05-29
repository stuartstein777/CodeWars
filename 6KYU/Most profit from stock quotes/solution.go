package kata

func GetMostProfitFromStockQuotes(quotes []int) int {
	largest := 0
	l := len(quotes)
	profit := 0
	for i := l - 1; i >= 0; i-- {
		if quotes[i] < largest {
			profit += largest - quotes[i]
		} else {
			largest = quotes[i]
		}
	}

	return profit
}
