package kata

func Typist(s string) int {
  capsOn := false
  clicks := 0
  slen := len(s)
  for i:= 0; i < slen; i++ {
    if s[i] >= 'A' && s[i] <= 'Z' && !capsOn {
      capsOn = true
      clicks += 2
    } else if s[i] >= 'a' && s[i] <= 'z' && capsOn {
      capsOn = false
      clicks += 2
    } else {
      clicks ++
    }
  }
  
  return clicks
}