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

func GetIndexOf2LargestItems(xs []int) []int {
	if xs[0] >= xs[2] && xs[1] >= xs[2] {
		return []int{0, 1}
	}

	if xs[0] >= xs[1] && xs[2] >= xs[1] {
		return []int{0, 2}
	}

	return []int{1, 2}
}

func CanPlay(xs []int) bool {
	return (xs[0] > 0 && xs[1] > 0) ||
		(xs[0] > 0 && xs[2] > 0) ||
		(xs[1] > 0 && xs[2] > 0)
}

func Solve(xs []int) int {
	daysPlayed := 0

	for CanPlay(xs) {
		ys := GetIndexOf2LargestItems(xs)
		xs[ys[0]] -= 1
		xs[ys[1]] -= 1
		daysPlayed += 1
	}

	return daysPlayed
}

func main() {
	fmt.Println(Solve([]int{12, 12, 12}))
}
