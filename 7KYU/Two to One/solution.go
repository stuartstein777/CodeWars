package kata

import (
  "sort"
)

func TwoToOne(s1 string, s2 string) string {
  chars := make(map[rune]struct{})
  
  s := s1 + s2
  var res []rune
  for _, c := range s {
     _, found := chars[c]
    
    if !found {
      chars[c] = struct{}{}
      res = append(res, c) 
    }
  }
  
	sort.Slice(res, func(i, j int) bool {
		return res[i] < res[j]
	})

	return string(res)
}
