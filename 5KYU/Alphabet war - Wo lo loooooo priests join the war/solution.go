package kata

var LeftPriest = 't'
var RightPriest = 'j'

var LeftPowers = map[rune]int{
	'w': 4,
	'p': 3,
	'b': 2,
	's': 1}

var RightPowers = map[rune]int{
	'm': 4,
	'q': 3,
	'd': 2,
	'z': 1}

var opposites = map[rune]rune{
	'w': 'm',
	'p': 'q',
	'b': 'd',
	's': 'z',
	'm': 'w',
	'q': 'p',
	'd': 'b',
	'z': 's'}

func Score(fight string) (int, int) {
	left, right := 0, 0

	for _, c := range fight {
		if _, ok := LeftPowers[c]; ok {
			left += LeftPowers[c]
		}

		if _, ok := RightPowers[c]; ok {
			right += RightPowers[c]
		}
	}
	return left, right
}

func GetNeighbours(fight string, idx int) (rune, rune) {
	leftNeighbour, rightNeighbour := ' ', ' '
	length := len(fight)
	if idx > 0 {
		leftNeighbour = rune(fight[idx-1])
	}

	if idx < length-1 {
		rightNeighbour = rune(fight[idx+1])
	}

	return leftNeighbour, rightNeighbour
}

func CanConvert(c rune, leftNeighbour rune, rightNeighbour rune) bool {
	if _, ok := LeftPowers[c]; ok {
		if (leftNeighbour == RightPriest && rightNeighbour != LeftPriest) ||
			(rightNeighbour == RightPriest && leftNeighbour != LeftPriest) {
			return true
		}
	} else if _, ok := RightPowers[c]; ok {
		if (leftNeighbour == LeftPriest && rightNeighbour != RightPriest) ||
			(rightNeighbour == LeftPriest && leftNeighbour != RightPriest) {
			return true
		}
	}
	return false
}

func AlphabetWar(fight string) string {
	res := ""
	for idx, c := range fight {
		leftNeighbour, rightNeighbour := GetNeighbours(fight, idx)
		if CanConvert(c, leftNeighbour, rightNeighbour) {
			res += string(opposites[c])
		} else {
			res += string(c)
		}
	}

	leftScore, rightScore := Score(res)
	if leftScore > rightScore {
		return "Left side wins!"
	} else if rightScore > leftScore {
		return "Right side wins!"
	} else {
		return "Let's fight again!"
	}
}
