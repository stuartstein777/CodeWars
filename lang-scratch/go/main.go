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

func FindCats(yard []string) [][]int {
	cats := [][]int{}

	for i, row := range yard {
		l := len(row)
		for j := 0; j < l; j++ {
			cell := row[j]
			if cell != '-' {
				cats = append(cats, []int{i, j})
			}
		}
	}
	return cats
}

func Distance(xy1, xy2 []int) float64 {
	x1 := float64(xy1[0])
	y1 := float64(xy1[1])
	x2 := float64(xy2[0])
	y2 := float64(xy2[1])

	return math.Sqrt(math.Pow(math.Abs(x2-x1), 2) + math.Pow(math.Abs(y2-y1), 2))
}

func main() {
	yard := []string{
		"-----------L",
		"--R---------",
		"------------",
		"------------",
		"------------",
		"--M---------"}

	cats := FindCats(yard)
	minDistance := 4

	fmt.Println(fmt.Sprint(cats))
	l := len(cats)
	for i := 0; i < l; i++ {
		for j := i + 1; j < l; j++ {
			d := Distance(cats[i], cats[j])
			fmt.Println(fmt.Sprintf("%v, %v, %v", cats[i], cats[j], d))
			if d < float64(minDistance) {
				fmt.Println("fight!")
				return
			}

		}
	}
}
