package kata

type Customer struct {
	TimeToCheckout      int
	TimeEnteredCheckout int
}

func assignCustomerToCheckout(customerTime int, checkouts []Customer, time int) bool {
	for i, checkout := range checkouts {
		if checkout.TimeToCheckout == -1 {
			checkouts[i] = Customer{customerTime, time}
			return true
		}
	}
	return false
}

func finishCheckout(checkouts []Customer, time int) {
	for i, checkout := range checkouts {
		if checkout.TimeToCheckout != -1 && time-checkout.TimeEnteredCheckout == checkout.TimeToCheckout {
			checkouts[i] = Customer{-1, -1}
			//fmt.Printf("customer finished checkout at time %d\n", time)
		}
	}
}

func checkoutsAreAllEmpty(checkouts []Customer) bool {
	for _, checkout := range checkouts {
		if checkout.TimeToCheckout != -1 {
			return false
		}
	}
	return true
}

func QueueTime(customers []int, n int) int {
	time := 0
	currentCustomer := 0
	checkouts := make([]Customer, n)
	customerCount := len(customers)

	for {
		finishCheckout(checkouts, time)
		if currentCustomer == customerCount && checkoutsAreAllEmpty(checkouts) {
			break
		}

		for {
			if currentCustomer == customerCount {
				break
			}
			assigned := assignCustomerToCheckout(customers[currentCustomer], checkouts, time)
			if !assigned {
				break
			}
			currentCustomer++
		}

		time++
	}

	return time
}