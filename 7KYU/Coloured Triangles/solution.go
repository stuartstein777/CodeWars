package kata

func GetColour(a rune, b rune) rune {
	if a == 'B' && b == 'G' {
		return 'R'
	} else if a == 'G' && b == 'B' {
		return 'R'
	} else if a == 'R' && b == 'G' {
		return 'B'
	} else if a == 'G' && b == 'R' {
		return 'B'
	} else if a == 'B' && b == 'R' {
		return 'G'
	} else if a == 'R' && b == 'B' {
		return 'G'
	} else if a == b {
		return a
	}
	return ' '
}

func Triangle(row string) rune {

	for {
		if len(row) == 1 {
			return rune(row[0])
		}

		nextRow := ""

		for i := 0; i < len(row)-1; i++ {
			nextRow += string(GetColour(rune(row[i]), rune(row[i+1])))
		}

		row = nextRow
	}
	return rune(row[0])
}
