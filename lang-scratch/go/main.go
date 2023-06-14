package main

import (
	"fmt"
	"math/big"
	"sort"
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
		b = cb + b
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
	fmt.Printf("output bin: %s\n", output)
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

func Boolfuck(source, input string) string {
	pointer := 0
	output := ""
	tape := make(map[int]bool)
	jumpTable := getBracketJumpTable(source)
	binaryInput := inputToBinaryString(input)

	inputLen := len(binaryInput)
	inputPtr := inputLen - 1

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
			if inputLen == 0 || inputPtr > inputLen-1 || inputPtr < 0 {
				tape[pointer] = false
			} else {
				tape[pointer] = binaryInput[inputPtr] == '1'
				inputPtr--
			}
		}
	}

	return binaryOutputToString(output)
}

func Gcdi(a, b int) int {
	if a == 0 {
		return b
	}
	return Gcdi(b%a, a)
}

func Lcmu(x, y int) int {
	gcd := Gcdi(x, y)
	if x < 0 {
		x = -x
	}
	if y < 0 {
		y = -y
	}

	return (x * y) / gcd
}

func Solve(s string, a, b int) string {
	if b > len(s) {
		b = len(s) - 1
	}
	s1 := s[:a]
	s2 := s[b+1:]

	// reverse sr
	r := []rune(s[a : b+1])

	for i, j := 0, len(r)-1; i < j; i, j = i+1, j-1 {
		r[i], r[j] = r[j], r[i]
	}

	sr := string(r)

	return s1 + sr + s2
}

// ------------------------------
func gcd(a, b *big.Int) *big.Int {
	if b.Cmp(big.NewInt(0)) == 0 {
		return a
	}
	return gcd(b, new(big.Int).Mod(a, b))
}

func lcm(a, b *big.Int) *big.Int {
	if a == big.NewInt(0) {
		return big.NewInt(0)
	} else {
		g := gcd(a, b)
		x := new(big.Int).Mul(a, b)
		res := new(big.Int).Div(x, g)
		fmt.Printf("%v\n", res)
		return res
	}
}

func LCM(nums ...int64) *big.Int {
	fmt.Printf("%v\n", nums)

	if len(nums) == 0 {
		return big.NewInt(1)
	}
	if len(nums) == 1 {
		return big.NewInt(nums[0])
	}
	res := big.NewInt(nums[0])

	for i := 1; i < len(nums); i++ {
		a := res
		b := nums[i]
		res = lcm(a, big.NewInt(b))
		fmt.Printf("%v, %v, %v\n", a, b, res)
	}

	return res
}

// 2 3 3 4 5 5 6 8 9 9 10
// last = 2
// i           |         v    | last
// 0		   |		 2	  | 2
// 1		   |		 3    | 2
// 2		   |		 3    | 3
// 3		   |		 4	  | 3
// 4		   |		 5	  | 4
// 5		   |		 5    | 5
// 6		   |		 6    | 5
// 7		   |		 8    | 6  (v - last > 1)

func main() {

	arr := []int{10, 9, 8, 9, 6, 1, 2, 4, 3, 2, 5, 5, 3}
	sort.Ints(arr)
	occured := make(map[int]int)
	dupes := []int{}
	last := arr[0]
	missing := -1

	for i := 0; i < len(arr); i++ {
		v := arr[i]
		if v != last && v-last > 1 {
			missing = v
		}
		if _, ok := occured[v]; ok {
			dupes = append(dupes, v)
		} else {
			occured[v] = 1
		}
		last = v
	}

	fmt.Printf("%v\n", dupes)
	fmt.Printf("%v\n", missing)

	// ---------------------------------------------

	// Deal with Boolfuck interpreter as array of bytes ?
	// fmt.Println()
	// fmt.Println()
	// fmt.Println()
	// // Print Hello, world!
	// source := ";;;+;+;;+;+;\n+;+;+;+;;+;;+;\n;;+;;+;+;;+;\n;;+;;+;+;;+;\n+;;;;+;+;;+;\n;;+;;+;+;+;;\n;;;;;+;+;;\n+;;;+;+;;;+;\n+;;;;+;+;;+;\n;+;+;;+;;;+;\n;;+;;+;+;;+;\n;;+;+;;+;;+;\n+;+;;;;+;+;;\n;+;+;+"
	// input := ""
	// fmt.Println(Boolfuck(source, input))

	// fmt.Println("======================================")
	// // Print Codewars
	// source := ">,>,>,>,>,>,>,>,>+<<<<<<<<+[>+]<[<]>>>>>>>>>[+<<<<<<<<[>]+<[+<]>;>;>;>;>;>;>;>;>+<<<<<<<<+[>+]<[<]>>>>>>>>>[+<<<<<<<<[>]+<[+<]>>>>>>>>>+<<<<<<<<+[>+]<[<]>>>>>>>>>[+]+<<<<<<<<+[>+]<[<]>>>>>>>>>]<[+<]>,>,>,>,>,>,>,>,>+<<<<<<<<+[>+]<[<]>>>>>>>>>]<[+<]"
	// // //source := ">,>,>,>,>,>,>,>,<<<<<<<<;>;>;>;>;>;>;>;"
	// input := "Codewars"
	// fmt.Println(Boolfuck(source, input))

	//source := ">,>,>,>,>,>,>,>,>>,>,>,>,>,>,>,>,<<<<<<<<+<<<<<<<<+[>+]<[<]>>>>>>>>>[+<<<<<<<<[>]+<[+<]>>>>>>>>>>>>>>>>>>+<<<<<<<<+[>+]<[<]>>>>>>>>>[+<<<<<<<<[>]+<[+<]>>>>>>>>>+<<<<<<<<+[>+]<[<]>>>>>>>>>[+]>[>]+<[+<]>>>>>>>>>[+]>[>]+<[+<]>>>>>>>>>[+]<<<<<<<<<<<<<<<<<<+<<<<<<<<+[>+]<[<]>>>>>>>>>]<[+<]>>>>>>>>>>>>>>>>>>>>>>>>>>>+<<<<<<<<+[>+]<[<]>>>>>>>>>[+<<<<<<<<[>]+<[+<]>>>>>>>>>+<<<<<<<<+[>+]<[<]>>>>>>>>>[+]<<<<<<<<<<<<<<<<<<<<<<<<<<[>]+<[+<]>>>>>>>>>[+]>>>>>>>>>>>>>>>>>>+<<<<<<<<+[>+]<[<]>>>>>>>>>]<[+<]<<<<<<<<<<<<<<<<<<+<<<<<<<<+[>+]<[<]>>>>>>>>>[+]+<<<<<<<<+[>+]<[<]>>>>>>>>>]<[+<]>>>>>>>>>>>>>>>>>>>;>;>;>;>;>;>;>;<<<<<<<<"
	//input, _ := strconv.Unquote("0809")
	//fmt.Println(Boolfuck(source, input))

}

/*
11000011

"Hello"
01001000 01100101 01101100 01101100 01101111
H        e        l        l         o
0110111101101100011011000110010101001000

"Codewars"
01000011	01101111	01100100	01100101	01110111	01100001	01110010	01110011
C			o			d			e			w			a			r			s
0111001101110010011000010111011101100101011001000110111101000011

abc
cba < read right to left
BYtes are read in little endian order

01100001 << first bit read is 1
a



-- For dealing with input

package main

import (
	"fmt"
)

func main() {
	str := "\x08\x09"
	bytes := []byte(str)

	result := ""
	for _, b := range bytes {
		result += fmt.Sprintf("%d", b)
	}

	fmt.Println(result) // Output: 89
}


*/
