package main

import "fmt"

func Print(m map[byte][2]int) {
	for k, v := range m {
		fmt.Println(fmt.Sprintf("%c (%d): %v", k, k, v))
	}
}
func Solve(s string) rune {
	m := make(map[byte][2]int)
	m[s[0]] = [2]int{0, 0}
	res := s[0]
	l := len(s)
	largest := 0

	for i := 1; i < l; i++ {
		r := s[i]
		if _, ok := m[r]; ok {
			a := m[r]
			a[1] = i
			m[r] = a
			if a[1]-a[0] > largest {
				largest = a[1] - a[0]
				res = r
			} else if a[1]-a[0] == largest {
				if r < res {
					res = r
				}
			}
		} else {
			m[r] = [2]int{i, i}
		}
	}

	Print(m)
	return rune(res)
}

func main() {
	fmt.Println(Solve("areasuvklaxjaizezrnqvryjvdscwtgtsgzpamwexrwmnbvoqxrfgvabqszeppqvfpsdujggwqvtcrxghacgckzesjtrvjmlhgvgqnsoclfgqnvkbseyleyshvoarszqbvodweyyylqgmmliqhziawiaihrsxzqflccpwbpowshiohomsxxybvsbzpkyvftvdbucltuqdqtgeaeolgksdrhqxigcsdlkpnvzpoplytksrbhxxuonzkraxkmzsuvsvmpauzbqmazrhimndcgdvynegbuibkpfjaxhsabeodpmrdqilyemnftnqnqautzndmydantpkkxntgxgrpjesqmmhnouamcdrthsboreabermmxrxzizeummywlhaondpmrnjmjvanadnhannmognlzrotfrfcihigensylkwyafekocrxlutrzbpdqclnuhhyucelcerexanvawrywymnflzxnpsddtpdalxdbsrikajtvbmzmgsvcngamcbofwxdlsvwgwtldccyulvgpiodejukqiugvsujqeoaclmeeviuylfyxubahaojyrfujswkvvjurujqmktcckdqfbyutpbifymzbxxwqbynbaogwpdzqdxgkckaaojvfdnufrzyrkoaalgxlylyfdajtajlqbqbsqvgeicgripttxilmjjdjphnogaregupsvpsvvlnfeimgboxjgshzxblzgiddjbhequpobuievfkmgzsfbcfnwapodjielaichazyjgpqlhklzhojamqbztucponzgldjzkvwxmslcciwkzoswkywhbfbuxxtavtiwatgpybxojrnfvacqumrjplavfcupfyreeouzxvrbdalgqccmhynecgcnbmtjbjrazvh"))
}
