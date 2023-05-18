package kata

import "strings"

func Rot(s string) string {
	xs := strings.Split(s, "\n")
	l := len(xs) - 1
	res := []string{}

	for i := l; i >= 0; i-- {
		s := ""
		for j := l; j >= 0; j-- {
			s += string(xs[i][j])
		}
		res = append(res, s)
	}
	return strings.Join(res, "\n")
}

func SelfieAndRot(s string) string {
	var rot = Rot(s)
	var xs = strings.Split(s, "\n")
	var ys = strings.Split(rot, "\n")

	l := len(xs)
	res := []string{}
	dots := strings.Repeat(".", l)

	for _, x := range xs {
		res = append(res, x+dots)
	}

	for _, x := range ys {
		res = append(res, dots+x)
	}

	return strings.Join(res, "\n")
}

type FParam func(string) string

func Oper(f FParam, x string) string {
	return f(x)
}
