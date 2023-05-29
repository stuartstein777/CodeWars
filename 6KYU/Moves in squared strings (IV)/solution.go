package kata

import (
	"fmt"
	"strings"
)

func Rot90Counter(s string) string {
	rows := strings.Split(s, "\n")
	l := len(rows)
	res := []string{}
	n := l - 1
	for i := 0; i < l; i++ {
		r := ""
		for j := 0; j < l; j++ {
			r += fmt.Sprintf("%c", rows[j][n])
		}
		n -= 1
		res = append(res, r)
	}
	return strings.Join(res, "\n")
}

func Diag2Sym(s string) string {
	rows := strings.Split(s, "\n")
	l := len(rows)
	res := []string{}
	n := l - 1
	for i := 0; i < l; i++ {
		r := ""
		for j := l - 1; j >= 0; j-- {
			r += fmt.Sprintf("%c", rows[j][n])
		}
		n -= 1
		res = append(res, r)
	}
	return strings.Join(res, "\n")
}

func SelfieDiag2Counterclock(s string) string {
	res := []string{}
	rows := strings.Split(s, "\n")
	rot90 := strings.Split(Rot90Counter(s), "\n")
	diag := strings.Split(Diag2Sym(s), "\n")
	l := len(diag)

	for i := 0; i < l; i++ {
		r := fmt.Sprintf("%s|%s|%s", rows[i], diag[i], rot90[i])
		res = append(res, r)
	}
	return strings.Join(res, "\n")
}

type FParam func(string) string

func Oper(f FParam, x string) string {
	return f(x)
}
