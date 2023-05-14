package kata

func GetAllRots(s string) []string {
	var res []string
	for i := 0; i < len(s); i++ {
		res = append(res, s[i:]+s[:i])
	}
	return res
}

func ContainAllRots(s string, arr []string) bool {
	allRots := GetAllRots(s)

	for _, x := range allRots {
		found := false

		for _, y := range arr {
			if x == y {
				found = true
				break
			}
		}

		if !found {
			return false
		}
	}

	return true
}
