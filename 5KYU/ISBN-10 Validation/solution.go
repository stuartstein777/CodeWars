package kata

import (
	"fmt"
	"regexp"
)

func ValidISBN10(isbn string) bool {

	match, _ := regexp.MatchString(`^\d{9}[\dX|x]$`, isbn)
	if !match {
		return false
	}

	total := 0

	for idx, n := range isbn {
		if n == 'X' || n == 'x' {
			total += (idx + 1) * 10
		} else {
			total += (idx + 1) * int(n-'0')
		}
	}

	fmt.Println(isbn + " : " + fmt.Sprintf("%d", total))

	return (total%11 == 0)
}
