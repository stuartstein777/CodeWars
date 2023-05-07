package kata

import (
  "fmt"
)

func GetMinAndMax(xs []string) [2]int {
  
  largest := 0
  smallest := 0
  xsLen := len(xs)
  
  if xsLen == 1 {
    t := len(xs[0])
    return [2]int {t, t}
  }
  
  if len(xs[0]) > len(xs[1]) {
    largest, smallest = len(xs[0]), len(xs[1])
  } else {
    largest, smallest = len(xs[1]), len(xs[0])
  }
  
  for i:=2; i < xsLen; i++ {
     l := len(xs[i]) 
    
     if l < smallest {
       smallest = l
     } else if l > largest {
       largest = l
     }
  }
  
  return [2]int{smallest, largest}
}

func MxDifLg(a1 []string, a2 []string) int {
  a1Len := len(a1)
  a2Len := len(a2)
  
  if a1Len == 0 || a2Len == 0 {
    return -1
  }
  
  a1MinMax := GetMinAndMax(a1)
  a2MinMax := GetMinAndMax(a2)

  maxDiffa1a2 := a1MinMax[1] - a2MinMax[0]
  maxDiffa2a1 := a2MinMax[1] - a1MinMax[0]
   
  if maxDiffa1a2 > maxDiffa2a1 {
    return maxDiffa1a2
  } 
  
  return maxDiffa2a1
}