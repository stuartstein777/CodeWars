package main

import (
	"fmt"
	"strings"
)

func ScanDown(grid [][]rune, ci, cj, rows int, lookingFor rune) bool {
	for i := ci; i < rows; i++ {
		if grid[i][cj] == lookingFor {
			return true
		}
	}
	return false
}

func ScanRight(grid [][]rune, ci, cj, cols int, lookingFor rune) bool {
	for i := cj; i < cols; i++ {
		if grid[ci][i] == lookingFor {
			return true
		}
	}
	return false
}

func Solution(grid [][]rune) bool {
	rows := len(grid)
	cols := len(grid[0])
	for i := 0; i < rows; i++ {
		for j := 0; j < cols; j++ {
			if grid[i][j] == 'x' {
				if ScanDown(grid, i+1, j, rows, '^') {
					return true
				} else if ScanRight(grid, i, j+1, cols, '<') {
					return true
				}
			} else if grid[i][j] == '>' {
				return ScanRight(grid, i, j+1, cols, 'x')
			} else if grid[i][j] == 'v' {
				return ScanDown(grid, i+1, j, cols, 'x')
			}
		}
	}
	return false
}

func ToGrid(s string) [][]rune {
	splits := strings.Split(s, "\n")
	grid := make([][]rune, len(splits))
	for i, v := range splits {
		grid[i] = []rune(v)
	}
	return grid
}

func ToStr(grid [][]rune) string {
	s := ""
	for _, v := range grid {
		s += string(v) + "\n"
	}
	return s
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

func SelfieAndDiag(s string) string {
	grid := ToGrid(s)
	diag := strings.Split(Diag1Sym(s), "\n")
	res := []string{}

	for i := 0; i < len(grid); i++ {
		s := string(grid[i]) + "|" + string(diag[i])
		res = append(res, s)
	}

	return strings.Join(res, "\n")
}

func main() {
	s := "abcd\nefgh\nijkl\nmnop"
	fmt.Println(Diag1Sym(s))
	fmt.Println("------------------")
	fmt.Println(Rot90Clock(s))
	fmt.Println("------------------")
	fmt.Println(SelfieAndDiag(s))
}
