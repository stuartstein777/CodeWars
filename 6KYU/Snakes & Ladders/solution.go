package kata

func move(board []int, idx, goal int) int {
	if board[idx] == 0 || idx == goal {
		return idx
	} else {
		return move(board, idx+board[idx], goal)
	}
}

func SnakesAndLadders(board, dice []int) int {
	var idx = 0
	var diceIdx = 0
	var goalIdx = len(board) - 1
	var rollCount = len(dice)

	for {
		if idx == goalIdx || diceIdx == rollCount {
			return idx
		}

		var toMove = dice[diceIdx]
		if idx+toMove <= goalIdx {
			idx = move(board, idx+toMove, goalIdx)
		}

		diceIdx = diceIdx + 1
	}

	return idx
}
