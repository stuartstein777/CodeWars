package uniq

func Uniq(s []string) []string {
	if len(s) == 0 {
		return []string{}
	}
	c := s[0]
	res := []string{s[0]}

	for i := 1; i < len(s); i++ {
		if s[i] != c {
			res = append(res, s[i])
			c = s[i]
		}
	}
	return res
}
