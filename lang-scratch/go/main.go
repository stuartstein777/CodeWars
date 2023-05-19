package main

import "fmt"

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

func main() {

	var leftPowers = map[rune]int{
		'w': 4,
		'p': 3,
		'b': 2,
		's': 1,
	}

	var rightPowers = map[rune]int{
		'm': 4,
		'q': 3,
		'd': 2,
		'z': 1,
	}

	s := "*z*dq*mmw*pbzb*ssz*"
	ls := len(s) - 1

	for idx, c := range s {
		if c == '*' {
			if idx > 0 {
				s = replaceAtIndex(s, '_', idx-1)
			}
			if idx < ls {
				s = replaceAtIndex(s, '_', idx+1)
			}
		}
	}

	fmt.Println(s)

	var lScore = 0
	var rScore = 0

	for _, c := range s {
		if score, ok := leftPowers[c]; ok {
			lScore += score
		}

		if score, ok := rightPowers[c]; ok {
			rScore += score
		}
	}

}
