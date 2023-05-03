package kata

import (
	"strings"
)

type MyString string

func (s MyString) IsUpperCase() bool {
	return string(s) == strings.ToUpper(string(s))

}
