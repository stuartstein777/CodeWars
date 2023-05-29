package kata

import (
	"fmt"
	"strings"
)

func Vaporcode(str string) string {
	str = strings.ToUpper(str)
	res := []string{}
	for _, s := range str {
		if s != ' ' {
			res = append(res, fmt.Sprintf("%c", rune(s)))
		}
	}
	return strings.Join(res, "  ")
}
