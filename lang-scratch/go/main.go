package main

import (
	"fmt"
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

// -------------------------------------------------------------
// boolfuck interpreter

func inputToBinaryString(s string) string {
	b := ""

	for _, c := range s {
		cb := strconv.FormatInt(int64(c), 2)
		b += cb
	}

	return b
}

func getBracketJumpTable(s string) map[int]int {
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

func padWithZerosToMultipleOfEight(output string, l int) string {
	toPad := 8 - (l % 8)
	fmt.Printf("padding with %d zeros.\n", toPad)
	return strings.Repeat("0", toPad) + output

}

// break into 8 bit chunks, convert that binary to
// int, convert that to rune and add to string.
func binaryOutputToString(output string) string {

	// if its not a multiple of len, we need to pad it.
	l := len(output)
	fmt.Printf("output len: %d\n", l)
	if l%8 != 0 {
		output = padWithZerosToMultipleOfEight(output, l)
	}
	s := ""
	for i := 0; i < l; i += 8 {
		c := output[i : i+8]
		fmt.Printf("%s\n", c)
		n, _ := strconv.ParseInt(c, 2, 64)
		s = string(rune(n)) + s
		fmt.Printf("output char: %s\n", string(rune(n)))
		fmt.Printf("%d\n", n)
	}
	// reverse output
	return s
}

func interpreter(source, input string) string {
	pointer := 0
	output := ""
	tape := make(map[int]bool)

	jumpTable := getBracketJumpTable(source)
	binaryInput := inputToBinaryString(input)
	fmt.Printf("%v\n", jumpTable)
	fmt.Printf("%s\n", binaryInput)

	for _, c := range source {
		if c == '+' {
			if v, ok := tape[pointer]; ok {
				tape[pointer] = !v
			} else {
				tape[pointer] = true
			}
		} else if c == ';' {
			outputBit := 0
			if v, ok := tape[pointer]; ok {
				if v {
					outputBit = 1
				} else {
					outputBit = 0
				}
			} else {
				outputBit = 0
			}
			output = fmt.Sprint(outputBit) + output
		} else if c == '<' {
			pointer--
		} else if c == '>' {
			pointer++
		} else if c == '[' {
			if _, ok := tape[pointer]; !ok {
				pointer = jumpTable[pointer]
			}
		} else if c == ']' {
			if _, ok := tape[pointer]; ok {
				pointer = jumpTable[pointer]
			}
		} else if c == ',' {
			// read input.
		}
	}

	return binaryOutputToString(output)
}

func main() {
	//;
	source := ";;;+;+;;+;+;\n+;+;+;+;;+;;+;\n;;+;;+;+;;+;\n;;+;;+;+;;+;\n+;;;;+;+;;+;\n;;+;;+;+;+;;\n;;;;;+;+;;\n+;;;+;+;;;+;\n+;;;;+;+;;+;\n;+;+;;+;;;+;\n;;+;;+;+;;+;\n;;+;+;;+;;+;\n+;+;;;;+;+;;\n;+;+;+"
	input := ""
	fmt.Println(interpreter(source, input))
}
