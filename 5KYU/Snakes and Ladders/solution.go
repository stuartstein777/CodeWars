package kata

import "strconv"

// SnakesLadders - Stucture that game is played on
type SnakesLadders struct {
	P1Square        int
	P2Square        int
	SnakeAndLadders map[int]int
	WhosTurn        int
}

// NewGame - Method that starts a new game for the SnakesLadders struct
func (sl *SnakesLadders) NewGame() {
	sl.P1Square = 0
	sl.P2Square = 0
	sl.WhosTurn = 1
	sl.SnakeAndLadders = map[int]int{
		2:  38,
		7:  14,
		8:  31,
		15: 26,
		16: 6,
		21: 42,
		28: 84,
		36: 44,
		46: 25,
		49: 11,
		51: 67,
		62: 19,
		64: 60,
		71: 91,
		74: 53,
		78: 98,
		89: 68,
		87: 94,
		92: 88,
		95: 75,
		99: 80}
}

func (sl *SnakesLadders) Play(die1, die2 int) string {

	if sl.P1Square == 100 || sl.P2Square == 100 {
		return "Game over!"
	}
	toMove := die1 + die2
	if sl.WhosTurn == 1 {
		sl.P1Square += toMove
		if sl.P1Square > 100 {
			sl.P1Square = 100 - (sl.P1Square - 100)
		}
		if sl.P1Square == 100 {
			return "Player 1 Wins!"
		}
		if v, ok := sl.SnakeAndLadders[sl.P1Square]; ok {
			sl.P1Square = v
		}
		if die1 != die2 {
			sl.WhosTurn = 2
		}
		return "Player 1 is on square " + strconv.Itoa(sl.P1Square)
	} else {
		sl.P2Square += toMove
		if sl.P2Square > 100 {
			sl.P2Square = 100 - (sl.P2Square - 100)
		}
		if sl.P2Square == 100 {
			return "Player 2 Wins!"
		}
		if v, ok := sl.SnakeAndLadders[sl.P2Square]; ok {
			sl.P2Square = v
		}
		if die1 != die2 {
			sl.WhosTurn = 1
		}
		return "Player 2 is on square " + strconv.Itoa(sl.P2Square)
	}
}
