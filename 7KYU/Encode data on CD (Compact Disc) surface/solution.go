package kata

import (
	"strconv"
	"strings"
)

func EncodeCd(n uint8) string {
	b := strconv.FormatInt(int64(n), 2)
	if len(b) < 8 {
		b = strings.Repeat("0", 8-len(b)) + b
	}
	b = b[len(b)-8:]

	res := "P"
	cur := "P"

	for i := len(b) - 1; i >= 0; i-- {
		if b[i] == '1' {
			if cur == "P" {
				cur = "L"
			} else {
				cur = "P"
			}
		}
		res += cur
	}
	return res
}
