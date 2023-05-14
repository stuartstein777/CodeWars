package main

import "fmt"

func Solution(mtrx [][]rune) bool {
	for i := 0; i < len(mtrx); i++ {
		arrowFound := false
		targetFound := false
		for j := 0; j < len(mtrx[i]); j++ {
			if mtrx[i][j] == '>' {
				arrowFound = true
			} else if mtrx[i][j] == 'x' {
				return arrowFound
			}
		}

		if arrowFound && !targetFound {
			return false
		}
	}
	return false
}

func main() {
	mx := [][]rune{
		{' ', ' ', ' ', ' ', ' '},
		{' ', ' ', ' ', ' ', ' '},
		{'>', ' ', ' ', ' ', 'x'},
		{' ', ' ', ' ', ' ', ' '},
		{' ', ' ', ' ', ' ', ' '}}

	fmt.Println(Solution(mx))
}
