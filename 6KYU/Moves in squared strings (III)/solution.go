package kata

import "strings"

func ToGrid(s string) [][]rune {
	splits := strings.Split(s, "\n")
	grid := make([][]rune, len(splits))
	for i, v := range splits {
		grid[i] = []rune(v)
	}
	return grid
}

func Diag1Sym(s string) string {
	grid := ToGrid(s)
	l := len(grid)
	res := []string{}
	for i := 0; i < l; i++ {
		r := ""
		for j := 0; j < l; j++ {
			r += string(grid[j][i])
		}
		res = append(res, r)
	}

	return strings.Join(res, "\n")
}

func Rot90Clock(s string) string {
	grid := ToGrid(s)
	l := len(grid)
	res := []string{}
	for i := 0; i < l; i++ {
		r := ""
		for j := l - 1; j >= 0; j-- {
			r += string(grid[j][i])
		}
		res = append(res, r)
	}

	return strings.Join(res, "\n")
}

func SelfieAndDiag1(s string) string {
	grid := ToGrid(s)
	diag := strings.Split(Diag1Sym(s), "\n")
	res := []string{}

	for i := 0; i < len(grid); i++ {
		s := string(grid[i]) + "|" + string(diag[i])
		res = append(res, s)
	}

	return strings.Join(res, "\n")
}

type FParam func(string) string

func Oper(f FParam, x string) string {
	return f(x)
}
