package kata

import (
	"strconv"
	"strings"
)

func FizzBuzzCuckooClock(time string) string {
	split := strings.Split(time, ":")
	hour, _ := strconv.Atoi(split[0])
	hour = hour % 12
	if hour == 0 {
		hour = 12
	}
	min, _ := strconv.Atoi(split[1])

	if min == 0 {
		return strings.Trim(strings.Repeat("Cuckoo ", hour), " ")
	} else if min == 30 {
		return "Cuckoo"
	} else if min%3 == 0 && min%5 == 0 {
		return "Fizz Buzz"
	} else if min%3 == 0 {
		return "Fizz"
	} else if min%5 == 0 {
		return "Buzz"
	} else {
		return "tick"
	}
}
