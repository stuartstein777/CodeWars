package kata

import (
	"fmt"
	"strconv"
)

func ordinalSuffix(n int) string {
	j := n % 10
	k := n % 100

	if j == 1 && k != 11 {
		return "st"
	} else if j == 2 && k != 12 {
		return "nd"
	} else if j == 3 && k != 13 {
		return "rd"
	} else {
		return "th"
	}
}

func WhatCentury(year string) string {
	y, _ := strconv.Atoi(year)
	century := 0

	if y%100 == 0 {
		century = y / 100
	} else {
		century = y/100 + 1
	}
	return fmt.Sprintf("%d%s", century, ordinalSuffix(century))
}
