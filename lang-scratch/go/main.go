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

// -------------------------------------------------------------
// fmt.Println(strconv.FormatInt(int64(c), 2)) conver to binary
func GetBracketJumpTable(s string) map[int]int {
	stack := []int{}
	stackIdx := -1
	jumpTable := map[int]int{}

	for idx, c := range s {
		// if it's a [, put its index on the stack
		if c == '[' {
			stack = append(stack, idx)
			stackIdx++
		} else if c == ']' {
			// if its a ], pop the latest [ off the stack
			// store the indexes in the map
			open := stack[stackIdx]
			jumpTable[open] = idx
			jumpTable[idx] = open
			stack = stack[:stackIdx]
			stackIdx--
		}
	}

	return jumpTable
}

func main() {
	s := "[<<;,[;][>>]]"
	jumpTable := GetBracketJumpTable(s)

	fmt.Printf("%v\n", jumpTable)
}
