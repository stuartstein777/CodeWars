package kata

import "strings"

func ToCamelCase(s string) string {
	splitStr := strings.FieldsFunc(s, func(c rune) bool {
		return c == '-' || c == '_'
	})

	for i, s := range splitStr {
		if i > 0 {
			splitStr[i] = strings.ToUpper(string(s[0])) + s[1:]
		}
	}

	return strings.Join(splitStr, "")
}
