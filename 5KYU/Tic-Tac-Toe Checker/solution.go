package kata

func Winner(board [3][3]int, state [][]int) int {
	s1x := state[0][0]
	s1y := state[0][1]
	s2x := state[1][0]
	s2y := state[1][1]
	s3x := state[2][0]
	s3y := state[2][1]

	if board[s1x][s1y] == board[s2x][s2y] && board[s1x][s1y] == board[s3x][s3y] &&
		board[s1x][s1y] != 0 {
		return board[s1x][s1y]
	}
	return -1
}

func BoardComplete(board [3][3]int) bool {
	for x := 0; x < 3; x++ {
		for y := 0; y < 3; y++ {
			if board[x][y] == 0 {
				return false
			}
		}
	}
	return true
}

func IsSolved(board [3][3]int) int {

	winningStates := [][][]int{
		{{0, 0}, {0, 1}, {0, 2}},
		{{1, 0}, {1, 1}, {1, 2}},
		{{2, 0}, {2, 1}, {2, 2}},
		{{0, 0}, {1, 0}, {2, 0}},
		{{0, 1}, {1, 1}, {2, 1}},
		{{0, 2}, {1, 2}, {2, 2}},
		{{0, 0}, {1, 1}, {2, 2}},
		{{0, 2}, {1, 1}, {2, 0}}}

	for _, winningState := range winningStates {
		winner := Winner(board, winningState)
		if winner != -1 {
			return winner
		}
	}

	if BoardComplete(board) {
		return 0
	} else {
		return -1
	}
}
