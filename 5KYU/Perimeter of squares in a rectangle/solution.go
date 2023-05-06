package kata

func Perimeter(n int) int {
  a := 4
  b := 4
  total := 0
  for i:=0; i <= n; i ++ {
    total += a
    c := a + b
    a = b
    b = c
  }
  return total
}