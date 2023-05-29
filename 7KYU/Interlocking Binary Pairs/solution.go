package kata

import (
	"fmt"
	"strconv"
	"strings"
)

func ZeroPad(s string, l int) string {
	toPad := l - len(s)
	return strings.Repeat("0", toPad) + s
}

func Interlockable(a, b uint64) bool {
	ab := strconv.FormatUint(a, 2)
	bb := strconv.FormatUint(b, 2)

	var l int

	if len(ab) > len(bb) {
		l = len(ab)
		bb = ZeroPad(bb, len(ab))
	} else {
		l = len(bb)
		ab = ZeroPad(ab, len(bb))
	}

	fmt.Println(ab)
	fmt.Println(bb)
	for i := 0; i < l; i++ {
		if ab[i] == '1' && bb[i] == '1' {
			return false
		}
	}
	return true
}
