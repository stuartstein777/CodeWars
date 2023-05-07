package kata

func Tribonacci(signature [3]float64, n int) []float64 {
    var res []float64
    res = append(res, signature[0])
    res = append(res, signature[1])
  
    if n < 3 {
      return res[:n]      
    }
    
    a, b, c := signature[0], signature[1], signature[2]
    for i:=0; i < n-2; i++ {
      res = append(res, c)
      t := c + a + b
      a = b
      b = c
      c = t      
    }
    return res
}