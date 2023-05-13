package kata

import (
	"fmt"
	"strconv"
	"strings"
)

type Order struct {
	Stock  string
	Amount int
	Price  float64
	Buy    bool
}

func parseOrder(s string) (Order, string) {
	s = strings.Trim(s, " ")
	items := strings.Split(s, " ")
	if len(items) != 4 {
		return Order{}, s
	}

	stock := items[0]
	amount, amountErr := strconv.Atoi(items[1])
	price, priceErr := strconv.ParseFloat(items[2], 64)
	buy := items[3]

	if buy != "B" && buy != "S" {
		return Order{}, s
	}

	if !strings.ContainsRune(items[2], '.') || priceErr != nil {
		return Order{}, s
	}

	if amountErr != nil {
		return Order{}, s
	}

	return Order{stock, amount, price, buy == "B"}, ""
}

func BalanceStatement(input string) string {
	orders := strings.Split(input, ",")
	badlyFormedOrders := make([]string, 0)
	totalBuys := 0.0
	totalSells := 0.0

	for _, order := range orders {
		orderItems, err := parseOrder(order)

		if err != "" {
			badlyFormedOrders = append(badlyFormedOrders, err)
		} else {
			if orderItems.Buy {
				totalBuys += float64(orderItems.Amount) * orderItems.Price
			} else {
				totalSells += float64(orderItems.Amount) * orderItems.Price
			}
		}
	}

	summary := fmt.Sprintf("Buy: %0.f Sell: %0.f", totalBuys, totalSells)
	if len(badlyFormedOrders) > 0 {
		summary += fmt.Sprintf("; Badly formed %d: %s ;", len(badlyFormedOrders), strings.Join(badlyFormedOrders, " ;"))
	}

	return summary
}
