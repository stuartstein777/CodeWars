package kata

import "strings"

func Capitalise(s string) string {
	splitStr := strings.FieldsFunc(s, func(c rune) bool {
		return c == '-' || c == '_'
	})

	for idx, s := range splitStr {
		splitStr[idx] = strings.ToUpper(string(s[0])) + s[1:]
	}
	return strings.Join(splitStr, "-")
}

func bandNameGenerator(name string) string {

	if name[0] == name[len(name)-1] {
		return Capitalise(name) + name[1:]
	}

	return "The " + Capitalise(name)
}
