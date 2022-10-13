package kata

import "fmt"

func countSheep(num int) string {
	res := ""
	for i := 1; i <= num; i++ {
		res += fmt.Sprint(i) + " sheep..."
	}
	return res
}
