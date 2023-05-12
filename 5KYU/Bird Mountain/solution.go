package kata

func ToHeightMap(mountain []string) [][]int {
	heightMap := make([][]int, len(mountain))
	for i, row := range mountain {
		heightMap[i] = make([]int, len(row))
		for j, _ := range row {
			if mountain[i][j] == ' ' {
				heightMap[i][j] = 0
			} else {
				heightMap[i][j] = -1
			}
		}
	}
	return heightMap
}

func PeakHeight(mountain []string) int {

	heightMap := ToHeightMap(mountain)

	n := 1

	for {
		updated := false
		w := len(heightMap) - 1
		h := len(heightMap[0]) - 1
		for i, row := range heightMap {
			for j, _ := range row {
				cell := heightMap[i][j]

				if cell == -1 {
					if i == 0 || j == 0 || i == w || j == h {
						heightMap[i][j] = n
						updated = true
					} else if i > 0 && heightMap[i-1][j] == n-1 {
						heightMap[i][j] = n
						updated = true
					} else if i < len(heightMap)-1 && heightMap[i+1][j] == n-1 {
						heightMap[i][j] = n
						updated = true
					} else if j > 0 && heightMap[i][j-1] == n-1 {
						heightMap[i][j] = n
						updated = true
					} else if j < len(row)-1 && heightMap[i][j+1] == n-1 {
						heightMap[i][j] = n
						updated = true
					}
				}
			}
		}
		if !updated {
			break
		}
		n++
	}

	return n - 1
}
