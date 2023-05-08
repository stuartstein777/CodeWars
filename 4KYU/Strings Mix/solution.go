package kata

import (
	"sort"
	"strings"
)

type Occurance struct {
	S     int  // 1 or 2
	Char  rune // The character from the string a-z
	Count int  // The max count between s1 and s2 of Char
}

func GetOccurances(s string) map[rune]int {
	res := map[rune]int{}
	validChars := "abcdefghijklmnopqrstuvwxyz"
	for _, c := range s {
		if strings.Contains(validChars, string(c)) {
			_, found := res[c]

			if found {
				res[c] += 1
			} else {
				res[c] = 1
			}
		}
	}

	return res
}

func RepeatChar(c rune, cnt int) string {
	res := ""

	for i := 0; i < cnt; i++ {
		res += string(c)
	}
	return res
}

func BuildCharEntry(occ Occurance) string {
	res := ""

	if occ.S == 1 {
		res += "1:"
	} else if occ.S == 2 {
		res += "2:"
	} else {
		res += "=:"
	}

	res += RepeatChar(occ.Char, occ.Count)
	return res
}

func Mix(s1, s2 string) string {
  lchars := "abcdefghijklmnopqrstuvwxyz"
	freqs1 := GetOccurances(s1)
	freqs2 := GetOccurances(s2)
	var maxes []Occurance

	for _, c := range lchars {
		cnt1, _ := freqs1[c]
		cnt2, _ := freqs2[c]

		if cnt1 > 1 || cnt2 > 1 {
			t := Occurance{
				Char: c,
			}

			if cnt1 > cnt2 {
				t.S = 1
				t.Count = cnt1
				maxes = append(maxes, t)
			} else if cnt2 > cnt1 {
				t.S = 2
				t.Count = cnt2
				maxes = append(maxes, t)
			} else if cnt1 == cnt2 && cnt1 != 0 {
				t.S = 3
				t.Count = cnt1
				maxes = append(maxes, t)
			}
		}
	}

	sort.Slice(maxes, func(i, j int) bool {

		if maxes[i].Count != maxes[j].Count {
			return maxes[i].Count >= maxes[j].Count
		}
		if maxes[i].S != maxes[j].S {
			return maxes[i].S < maxes[j].S
		}

		return maxes[i].Char < maxes[j].Char
	})

	res := []string{}

	for _, occ := range maxes {
		res = append(res, BuildCharEntry(occ))
	}

	return strings.Join(res, "/")
}