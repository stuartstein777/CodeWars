package kata

func CartesianNeighbor(x, y int) [][]int {
	return [][]int{
		{x + 1, y},
		{x - 1, y},
		{x - 1, y + 1},
		{x - 1, y - 1},
		{x, y + 1},
		{x, y - 1},
		{x + 1, y - 1},
		{x + 1, y + 1}}
}
