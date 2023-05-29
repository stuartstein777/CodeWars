package kata

import "math"

func HarvesterRescue(data Data) string {

	// find distance between worm and harvester
	hx := data.Harvester[0]
	hy := data.Harvester[1]

	wx := data.Worm[0]
	wy := data.Worm[1]

	cx := data.Carryall[0]
	cy := data.Carryall[1]
	cs := data.Carryall[2]

	distanceWormToHarvester := math.Sqrt(math.Abs(float64(hx-wx))*math.Abs(float64(hx-wx)) + (math.Abs(float64(hy-wy)))*math.Abs(float64(hy-wy)))

	// find how long worm will get there
	timeWormToHarvesterMin := distanceWormToHarvester / float64(data.Worm[2])

	// find distance between carryall and harvester
	distanceCarryallToHarvester := math.Sqrt(math.Abs(float64(hx-cx))*math.Abs(float64(hx-cx)) + (math.Abs(float64(hy-cy)))*math.Abs(float64(hy-cy)))

	// find how long it will take to get there + 1 min
	timeToRescueMin := (distanceCarryallToHarvester / float64(cs)) + 1

	if timeToRescueMin < timeWormToHarvesterMin {
		return "The spice must flow! Rescue the harvester!"
	}
	return "Damn the spice! I'll rescue the miners!"
}
