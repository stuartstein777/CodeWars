package kata

import (
	"math"
)

// Calculate how many points you would make in 7 Wonders from these science cards!
func SevenWondersScience(compasses int, gears int, tablets int) int {
	println(compasses)
	println(gears)
	println(tablets)
	return (compasses * compasses) +
		(gears * gears) +
		(tablets * tablets) +
		int((math.Min(math.Min(float64(compasses), float64(gears)), float64(tablets)) * 7))
}
