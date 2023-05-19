package kata

func replaceAtIndex(s string, r rune, idx int) string {
	out := []rune(s)
	out[idx] = r
	return string(out)
}

func AlphabetWar(s string) string {
	var leftPowers = map[rune]int{
		'w': 4,
		'p': 3,
		'b': 2,
		's': 1,
	}

	var rightPowers = map[rune]int{
		'm': 4,
		'q': 3,
		'd': 2,
		'z': 1,
	}

	ls := len(s) - 1

	for idx, c := range s {
		if c == '*' {
			if idx > 0 {
				s = replaceAtIndex(s, '_', idx-1)
			}
			if idx < ls {
				s = replaceAtIndex(s, '_', idx+1)
			}
		}
	}

	var lScore = 0
	var rScore = 0

	for _, c := range s {
		if score, ok := leftPowers[c]; ok {
			lScore += score
		}

		if score, ok := rightPowers[c]; ok {
			rScore += score
		}
	}

	if lScore > rScore {
		return "Left side wins!"
	} else if rScore > lScore {
		return "Right side wins!"
	} else {
		return "Let's fight again!"
	}
}
