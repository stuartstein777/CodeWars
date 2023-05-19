package main

import (
	"math"
	"strconv"
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

func FizzBuzzCuckooClock(time string) string {
	split := strings.Split(time, ":")
	hour, _ := strconv.Atoi(split[0])
	hour = hour % 12
	min, _ := strconv.Atoi(split[1])

	if min == 0 {
		return strings.Repeat("Cuckoo ", hour)
	} else if min == 30 {
		return "Cuckoo "
	} else if min%3 == 0 && min%5 == 0 {
		return "Fizz Buzz"
	} else if min%3 == 0 {
		return "Fizz"
	} else if min%5 == 0 {
		return "Buzz"
	} else {
		return "tick"
	}
}

func main() {
	time := "8:33"
	println(FizzBuzzCuckooClock(time))
}
