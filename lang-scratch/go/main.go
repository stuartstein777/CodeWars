package main

func Fusc(n int) int {
	total := 0
	for n != 0 {
		if n == 1 {
			total += 1
		}

		if n&1 == 0 {
			n /= 2
		} else {
			n = (n - 1) / 2
		}
	}
	return total
}

func main() {
	println(Fusc(10))
}

// 1771561
