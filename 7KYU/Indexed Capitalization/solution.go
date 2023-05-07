package kata

import(
  "unicode"
)

func Capitalize(st string, arr []int) string {
	res := []rune(st)
  l := len(res)
  for _,i := range arr {
    if i < l {
      res[i] = unicode.ToUpper(res[i])
    }
  }
  return string(res)
}