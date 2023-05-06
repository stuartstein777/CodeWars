package kata

import(
  "math"
)

func FindSumOfSquaredDivisors(n int) int {
  res := 0
  for i:=1; i <= int(math.Sqrt(float64(n))); i++ {
     if n % i == 0 {
       res += (i * i)
       
       if i != n/i {
         res += (n/i * n/i)
         }
     } 
  } 
  return res
}

func IsPerfectSquare(num int) bool {
	sqrt := int(math.Sqrt(float64(num)))
	return sqrt*sqrt == num
}

func ListSquared(m, n int)  [][]int {
  
   res := [][]int{}
   for i := m; i <= n; i++ {
     sumOfSquaredDivisors := FindSumOfSquaredDivisors(i)
     if IsPerfectSquare(sumOfSquaredDivisors) {
       x := []int{i, sumOfSquaredDivisors}
       res = append(res, x)
     }
   }
  
   return res
}