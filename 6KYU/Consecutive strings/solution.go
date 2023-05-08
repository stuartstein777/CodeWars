package kata

func LongestConsec(strarr []string, k int) string {
  l := len(strarr)
  
  if l == 0 || k > l || k < 0 {
    return ""
  }
  
  res := ""
  for i := 0; i <= (l - k); i++ {
		cur := ""
		for j := i; j < i+k; j++ {
			cur += strarr[j]
		}

		if len(cur) > len(res) {
			res = cur
		}
	}
  
  return res
}