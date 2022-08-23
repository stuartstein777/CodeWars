package kata

import (
	"fmt"
)

func GetMiddle(s string) string {
	if len(s)%2 == 0 {
		half := len(s) / 2
		return fmt.Sprint(s[half-1 : half+1])
	} else {
		half := int(len(s) / 2)
		return string(s[half])
	}
}
