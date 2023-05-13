package kata

import (
	"fmt"
	"strconv"
	"strings"
)

func GetCodeAndQuantity(book string) (string, int) {
	s := strings.Split(book, " ")
	bookCode := string(s[0][0])
	bookQuantity, _ := strconv.Atoi(s[1])
	return bookCode, bookQuantity
}

func Summarize(code string, quantity int) string {
	return fmt.Sprintf("(%s : %d)", code, quantity)
}

func StockList(listArt []string, listCat []string) string {

	if len(listArt) == 0 {
		return ""
	}

	catsToQuantity := map[string]int{}
	for _, book := range listArt {

		code, quantity := GetCodeAndQuantity(book)
		catsToQuantity[code] += quantity
	}

	res := []string{}
	for _, cat := range listCat {
		if _, ok := catsToQuantity[cat]; ok {
			res = append(res, Summarize(cat, catsToQuantity[cat]))
		} else {
			res = append(res, Summarize(cat, 0))
		}
	}

	return strings.Join(res, " - ")
}
