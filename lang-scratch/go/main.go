package main

func RoundToNext5(n int) int {
	for i := 0; i < 5; i++ {
		m := n + i
		if m%5 == 0 {
			return m
		}
	}
	return n
}

func main() {
	println(RoundToNext5(2))
	println(RoundToNext5(3))
	println(RoundToNext5(12))
	println(RoundToNext5(-2))
	println(RoundToNext5(-5))
}

/*

56789
67895
68957
68579
68597

*/
