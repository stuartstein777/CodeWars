package kata

import (
	"fmt"
	"math"
)

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

	return math.Sqrt(math.Pow(x2-x1, 2) + math.Pow(y2-y1, 2))
}

func PeacefulYard(yard []string, minDistance int) bool {
	fmt.Println(fmt.Sprint(yard))
	fmt.Println(minDistance)

	cats := FindCats(yard)
	l := len(cats)
	for i := 0; i < l; i++ {
		for j := i + 1; j < l; j++ {
			if Distance(cats[i], cats[j]) < float64(minDistance) {
				return false
			}

		}
	}
	return true

}
