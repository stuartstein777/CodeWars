package kata

import "math"

func EquableTriangle(a, b, c int) bool {
	perimeter := float64(a + b + c)
	area := math.Sqrt(float64((a+b+c)*(-a+b+c)*(a-b+c)*(a+b-c))) * 0.25

	return perimeter == area
}
