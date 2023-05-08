package kata

func Sum(arr []int) int {
  total := 0
  l := len(arr)
  for i:=0; i < l; i++ {
    total += arr[i]
  } 
  return total
}

func FindEvenIndex(arr []int) int {
  l := len(arr)
  
  for i:=0; i < l; i++ {
     if i == 0 && Sum(arr[1:]) == 0 {
         return 0
     }
     if Sum(arr[:i]) == Sum(arr[i+1:]) {
       return i
     }
  } 
  
  return -1
}
