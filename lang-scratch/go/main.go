package main

import (
	"fmt"
	"math"
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

// func GetNeighboursWithinRange(x, y, r int) [][]int {
// 	res := [][]int{}

// 	for Δx := -r; Δx <= r; Δx++ {
// 		for Δy := -r; Δy <= r; Δy++ {
// 			if Δx != 0 || Δy != 0 {
// 				res = append(res, []int{x + Δx, y + Δy})
// 			}
// 		}
// 	}

//		return res
//	}

type Coord struct {
	ΔX float64
	ΔY float64
}

// func GetNeighboursWithinRange(x, y, r int) map[Coord]interface{} {
// 	res := make(map[Coord]interface{})

// 	// only need to the absolute values of x and y, distances are
// 	// the same in all directions.
// 	for Δx := -r; Δx <= r; Δx++ {
// 		for Δy := -r; Δy <= r; Δy++ {
// 			if Δx != 0 || Δy != 0 {
// 				coord := Coord{ΔX: x + Δx, ΔY: y + Δy}
// 				if _, ok := res[coord]; !ok {
// 					res[coord] = nil
// 				}
// 			}
// 		}
// 	}

// 	return res
// }

func GetNeighboursWithinRange(x, y, r int) map[Coord]interface{} {
	res := make(map[Coord]interface{})
	for Δx := 0; Δx <= r; Δx++ {
		for Δy := 0; Δy <= r; Δy++ {
			if Δx != 0 || Δy != 0 {
				coord := Coord{ΔX: math.Abs(float64(x) + float64(Δx)), ΔY: math.Abs(float64(y) + float64(Δy))}
				if _, ok := res[coord]; !ok {
					res[coord] = nil
				}
			}
		}
	}

	return res
}

func roundFloat(val float64, precision uint) float64 {
	ratio := math.Pow(10, float64(precision))
	return math.Round(val*ratio) / ratio
}

func CalculateDistance(x1, y1, x2, y2 float64) float64 {
	return roundFloat(math.Sqrt(math.Pow(x2-x1, 2)+math.Pow(y2-y1, 2)), 10)
}

//-------------------------------------------------------------

func main() {

	digits := 5
	pi := []int{3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9, 7, 9, 3, 2, 3, 8, 4, 6, 2, 6, 4, 3, 3, 8, 3, 2, 7, 9, 5, 0, 2, 8, 8, 4, 1, 9, 7, 1, 6,
		9, 3, 9, 9, 3, 7, 5, 1, 0, 5, 8, 2, 0, 9, 7, 4, 9, 4, 4, 5, 9, 2, 3, 0, 7, 8, 1, 6, 4, 0, 6, 2, 8, 6, 2, 0, 8, 9, 9, 8, 6, 2,
		8, 0, 3, 4, 8, 2, 5, 3, 4, 2, 1, 1, 7, 0, 6, 7, 9}

	res := 0

	for i := 0; i < digits; i++ {
		res += pi[i] * pi[i]
	}

	res = int(math.Ceil(math.Sqrt(float64(res))))
	fmt.Println(res)
}
