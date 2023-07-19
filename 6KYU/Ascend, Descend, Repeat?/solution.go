package kata

import "fmt"

func AscendDescend(length, minimum, maximum int) string {
	if maximum < minimum || length == 0 {
		return ""
	}
	res := fmt.Sprintf("%d", minimum)
	ascending := true
	n := minimum

	for {
		if len(res) >= length {
			break
		}
		if minimum != maximum {
			if ascending && n < maximum {
				n++
			} else if ascending && n == maximum {
				n--
				ascending = false
			} else if !ascending && n > minimum {
				n--
			} else if !ascending && n == minimum {
				n++
				ascending = true
			}
		}
		res += fmt.Sprintf("%d", n)
	}

	return string(res[:length])
}
