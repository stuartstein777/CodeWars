package kata

import (
  "fmt"
  "unicode"
)

func FirstNonRepeating(str string) string {
  println(str)
  
  if str == "" {
    return ""
  }
	charCount := make(map[rune][3]int)
  for idx, c := range str {
    if val, found := charCount[unicode.ToLower(c)]; found {
      val[1]+=1
      charCount[unicode.ToLower(c)] = val
    } else {
      charCase := 0
      
      if unicode.IsUpper(c) {
        charCase = 1
      }
      
      charCount[unicode.ToLower(c)] = [3]int{idx, 1, charCase}
    }
  }
  
  // debug and print the map
  for key, value := range charCount {
		fmt.Printf("Key: %c, Value: %v\n", key, value)
	}
  
  pos := -1
  resCase := -1
  var resChar rune
  
  for k, v := range charCount {
    if v[1] == 1 && (pos == -1 || v[0] < pos) {
      pos = v[0]
      resCase = v[2]
      resChar = k
    } 
  }
  
  if pos == -1 {
    return ""
  } else if resCase == 1 {
    return string(unicode.ToUpper(resChar))
  } else {
    return string(unicode.ToLower(resChar))
  }
}