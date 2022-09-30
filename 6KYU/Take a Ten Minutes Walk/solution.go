package kata

func IsValidWalk(walk []rune) bool {
	if len(walk) != 10 {
		return false
	}

	dirs := make(map[rune]int)
	dirs['n'] = 0
	dirs['e'] = 0
	dirs['s'] = 0
	dirs['w'] = 0

	for _, e := range walk {
		dirs[e] = dirs[e] + 1
	}

	return dirs['n'] == dirs['s'] && dirs['e'] == dirs['w']
}
