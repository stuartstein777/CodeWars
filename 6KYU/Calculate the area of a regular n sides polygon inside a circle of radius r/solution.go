package kata

import (
	"math"
)

const PI = 3.141592653589793 // Use this value as pi in your calculations if necessary

func AreaOfPolygonInsideCircle(circleRadius float64, numberOfSides int) float64 {
	return math.Round((((circleRadius*circleRadius)*float64(numberOfSides))/2.0)*(math.Sin((PI*2.0)/float64(numberOfSides)))*1000) / 1000
}
