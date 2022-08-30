package kata

import (
	"regexp"
	"strconv"
)

func PrinterError(s string) string {
	cnt := len(s)
	re := regexp.MustCompile(`[a-m]`)
	cntrl := len(re.FindAllString(s, -1))
	return strconv.Itoa(cnt-cntrl) + "/" + strconv.Itoa(cnt)
}
