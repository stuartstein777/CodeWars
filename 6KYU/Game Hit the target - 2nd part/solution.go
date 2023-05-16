package kata

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
	fmt.Println(fmt.Sprint(grid))
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

/* tests

// TODO: replace with your own tests (TDD). An example to get you started is included below.
// Ginkgo BDD Testing Framework <http://onsi.github.io/ginkgo/>
// Gomega Matcher Library <http://onsi.github.io/gomega/>

package kata_test
import (
  . "github.com/onsi/ginkgo"
  . "github.com/onsi/gomega"
  . "codewarrior/kata"
)


var _ = Describe("Tests", func() {
     It("Fixed tests", func() {
       Expect(Solution([][]rune{{'>', ' '}, {' ', 'x'}})).To(Equal(false))
       Expect(Solution([][]rune{{'x', '>'}, {' ', ' '}})).To(Equal(false))
       Expect(Solution([][]rune{{' ', ' '}, {'<', 'x'}})).To(Equal(false))
       Expect(Solution([][]rune{{'v', ' '}, {' ', 'x'}})).To(Equal(false))
       Expect(Solution([][]rune{{'x', ' '}, {'^', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', '>', ' ', 'x'},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', 'v'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', 'x'}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', 'v'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', 'x'}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', 'v'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', 'x'}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', 'v'},
                                {' ', ' ', ' ', ' ', 'x'}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' ', 'v', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', 'x', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', 'v', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', 'x', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', 'v', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', 'x', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', 'v', ' '},
                                {' ', ' ', ' ', 'x', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', 'v', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', 'x', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', 'v', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', 'x', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', 'v', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', 'x', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', 'v', ' ', ' '},
                                {' ', ' ', 'x', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', 'v', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', 'x', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', 'v', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', 'x', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', 'v', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', 'x', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', 'v', ' ', ' ', ' '},
                                {' ', 'x', ' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{'v', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {'x', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {'v', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {'x', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {'v', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {'x', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {'v', ' ', ' ', ' ', ' '},
                                {'x', ' ', ' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' ', '>', 'x'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', '>', ' ', 'x'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', '>', ' ', ' ', 'x'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{'>', ' ', ' ', ' ', 'x'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', '>', 'x'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', '>', ' ', 'x'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {' ', '>', ' ', ' ', 'x'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {'>', ' ', ' ', ' ', 'x'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {'x', ' ', ' ', ' ', '<'},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {'x', ' ', ' ', '<', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {'x', ' ', '<', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))
       Expect(Solution([][]rune{{' ', ' ', ' ', ' ', ' '},
                                {'x', '<', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '},
                                {' ', ' ', ' ', ' ', ' '}})).To(Equal(true))

       // 3 x 3
       // <
       Expect(Solution([][]rune{{'x', '<', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{'x', ' ', '<'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', '<', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {'<', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', '<'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {'<', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', '<', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', '<'}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', '<', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       // ^
       Expect(Solution([][]rune{{'x', ' ', '^'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', '^', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {'^', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', '^'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {'^', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', '^', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', '^'}})).To(Equal(false))

       // v
       Expect(Solution([][]rune{{'x', ' ', 'v'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', 'v', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {'v', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', 'v'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {'v', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'v', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'v'}})).To(Equal(false))

       // > x [0 0]
       Expect(Solution([][]rune{{'x', ' ', '>'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', '>', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {'>', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', '>'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {'>', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', '>', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', '>'}})).To(Equal(false))

       // > x [0 1]
       Expect(Solution([][]rune{{'>', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', 'x', '>'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', '>', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {'>', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', '>'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {'>', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', '>', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', '>'}})).To(Equal(false))

       // > x [0 2]
       Expect(Solution([][]rune{{'>', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', '>', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', '>', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {'>', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', '>'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {'>', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', '>', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', '>'}})).To(Equal(false))

       // > x [1 0]
       Expect(Solution([][]rune{{'>', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '>', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', '>', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '>'},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', '>'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {'>', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', '>', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', '>'}})).To(Equal(false))

       // > x [1 1]
       Expect(Solution([][]rune{{'>', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '>', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'>', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', '>'},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', '>'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {'>', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', '>', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', '>'}})).To(Equal(false))

       // > x [1 2]
       Expect(Solution([][]rune{{'>', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '>', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'>', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', '>'},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '>', 'x'},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {'>', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', '>', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', '>'}})).To(Equal(false))

       // > x [2 0]
       Expect(Solution([][]rune{{'>', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '>', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'>', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '>'},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '>', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', '>'},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', '>', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', '>'}})).To(Equal(false))

       // > x [2 1]
       Expect(Solution([][]rune{{'>', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '>', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'>', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '>'},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '>', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', '>'},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'>', 'x', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', '>'}})).To(Equal(false))

       // > x [2 2]
       Expect(Solution([][]rune{{'>', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '>', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'>', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '>'},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '>', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', '>'},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'>', ' ', 'x'}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', '>', 'x'}})).To(Equal(true))

       // ^ x [0 0]
       Expect(Solution([][]rune{{'x', ' ', '^'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', '^', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {'^', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', '^'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {'^', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', '^', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', '^'}})).To(Equal(false))

       // ^ x [0 1]
       Expect(Solution([][]rune{{'^', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', '^'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', '^', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {'^', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', '^'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {'^', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', '^', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', '^'}})).To(Equal(false))

       // ^ x [0 2]
       Expect(Solution([][]rune{{'^', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '^', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', '^', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {'^', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', '^'},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {'^', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', '^', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', '^'}})).To(Equal(true))

       // ^ x [1 0]
       Expect(Solution([][]rune{{'^', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '^', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', '^', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '^'},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', '^'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {'^', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', '^', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', '^'}})).To(Equal(false))

       // ^ x [1 1]
       Expect(Solution([][]rune{{'^', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '^', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'^', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '^'},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', '^'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {'^', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', '^', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', '^'}})).To(Equal(false))

       // ^ x [1 2]
       Expect(Solution([][]rune{{'^', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '^', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'^', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '^'},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '^', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {'^', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', '^', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', '^'}})).To(Equal(true))

       // ^ x [2 0]
       Expect(Solution([][]rune{{'^', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '^', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'^', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '^'},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '^', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', '^'},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', '^', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', '^'}})).To(Equal(false))

       // ^ x [2 1]
       Expect(Solution([][]rune{{'^', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '^', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'^', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '^'},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '^', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', '^'},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'^', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', '^'}})).To(Equal(false))

       // ^ x [2 2]
       Expect(Solution([][]rune{{'^', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '^', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'^', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '^'},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '^', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', '^'},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'^', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', '^', 'x'}})).To(Equal(false))

       // < x [0 0]
       Expect(Solution([][]rune{{'x', ' ', '<'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{'x', '<', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))


       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', '<', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {'<', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', '<'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {'<', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', '<', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', '<'}})).To(Equal(false))

       // < x [0 1]
       Expect(Solution([][]rune{{'<', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', '<'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', '<', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {'<', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', '<'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {'<', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', '<', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', '<'}})).To(Equal(false))

       // < x [0 2]
       Expect(Solution([][]rune{{'<', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '<', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', '<', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {'<', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', '<'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {'<', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', '<', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', '<'}})).To(Equal(false))

       // < x [1 0]
       Expect(Solution([][]rune{{'<', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '<', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', '<', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', '<'},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', '<'},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {'<', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', '<', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', '<'}})).To(Equal(false))

       // < x [1 1]
       Expect(Solution([][]rune{{'<', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '<', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'<', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '<'},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', '<'},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {'<', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', '<', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', '<'}})).To(Equal(false))

       // < x [1 2]
       Expect(Solution([][]rune{{'<', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '<', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'<', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '<'},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '<', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {'<', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', '<', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', '<'}})).To(Equal(false))

       // < x [2 0]
       Expect(Solution([][]rune{{'<', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '<', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'<', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '<'},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '<', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', '<'},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', '<', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', '<'}})).To(Equal(true))

       // < x [2 1]
       Expect(Solution([][]rune{{'<', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '<', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'<', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '<'},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '<', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', '<'},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'<', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', '<'}})).To(Equal(true))

       // < x [2 2]
       Expect(Solution([][]rune{{'<', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', '<', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'<', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', '<'},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', '<', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', '<'},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'<', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', '<', 'x'}})).To(Equal(false))

       // v x [0 0]
       Expect(Solution([][]rune{{'x', ' ', 'v'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', 'v', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {'v', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', 'v'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {'v', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'v', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{'x', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'v'}})).To(Equal(false))

       // v x [0 1]
       Expect(Solution([][]rune{{'v', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', 'v'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', 'v', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {'v', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', 'v'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {'v', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', 'v', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'x', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'v'}})).To(Equal(false))

       // v x [0 2]
       Expect(Solution([][]rune{{'v', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'v', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', 'v', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {'v', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', 'v'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {'v', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', 'v', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'x'},
                                {' ', ' ', ' '},
                                {' ', ' ', 'v'}})).To(Equal(false))

       // v x [1 0]
       Expect(Solution([][]rune{{'v', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', 'v', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', 'v', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'v'},
                                {'x', ' ', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', 'v'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {'v', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', 'v', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'x', ' ', ' '},
                                {' ', ' ', 'v'}})).To(Equal(false))

       // v x [1 1]
       Expect(Solution([][]rune{{'v', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'v', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'v', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'v'},
                                {' ', 'x', ' '},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', 'v'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {'v', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', 'v', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'x', ' '},
                                {' ', ' ', 'v'}})).To(Equal(false))

       // v x [1 2]
       Expect(Solution([][]rune{{'v', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'v', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'v', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'v'},
                                {' ', ' ', 'x'},
                                {' ', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'v', 'x'},
                                {' ', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {'v', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', 'v', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'x'},
                                {' ', ' ', 'v'}})).To(Equal(false))

       // v x [2 0]
       Expect(Solution([][]rune{{'v', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', 'v', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'v', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', 'v'},
                                {' ', ' ', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'v', ' '},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'v'},
                                {'x', ' ', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', 'v', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'x', ' ', 'v'}})).To(Equal(false))

       // v x [2 1]
       Expect(Solution([][]rune{{'v', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'v', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'v', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'v'},
                                {' ', ' ', ' '},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'v', ' '},
                                {' ', 'x', ' '}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'v'},
                                {' ', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'v', 'x', ' '}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'x', 'v'}})).To(Equal(false))

       // v x [2 2]
       Expect(Solution([][]rune{{'v', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', 'v', ' '},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {'v', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', 'v'},
                                {' ', ' ', ' '},
                                {' ', ' ', 'x'}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', 'v', ' '},
                                {' ', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', 'v'},
                                {' ', ' ', 'x'}})).To(Equal(true))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {'v', ' ', 'x'}})).To(Equal(false))

       Expect(Solution([][]rune{{' ', ' ', ' '},
                                {' ', ' ', ' '},
                                {' ', 'v', 'x'}})).To(Equal(false))

     })
})

*/
