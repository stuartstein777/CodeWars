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

// -------------------------------------------------------------
func replaceAtIndex(s string, r rune, idx int) string {
	out := []rune(s)
	out[idx] = r
	return string(out)
}

func row(w int) string {
	s := []string{}
	for i := 0; i < w; i++ {
		s = append(s, " o ")
	}
	return "|" + strings.Join(s, "|") + "|"
}

func seperator(w int) string {
	s := []string{}
	for i := 0; i < w; i++ {
		s = append(s, "---")
	}
	return "+" + strings.Join(s, "+") + "+"
}

func main() {
	w, h := 1, 1

	rows := []string{}
	rows = append(rows, seperator(w))
	for i := 0; i < h; i++ {
		rows = append(rows, row(w))
		if h-i > 1 {
			rows = append(rows, seperator(w))
		}
	}
	rows = append(rows, seperator(w))
	// fmt.Println(s)

	fmt.Println(strings.Join(rows, "\n"))
}
