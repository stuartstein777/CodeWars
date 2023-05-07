package kata

func TwoOldestAges(ages []int) [2]int {
  
  largest := 0
  secondLargest := 0
  if(ages[0] > ages[1]) {
    largest = ages[0]
    secondLargest = ages[1]
  } else {
    largest = ages[1]
    secondLargest = ages[0]
  }
  ageLen := len(ages)
  for i:=2; i < ageLen; i++ {
    if ages[i] > largest {
      secondLargest = largest
      largest = ages[i]
    } else if ages[i] > secondLargest {
      secondLargest = ages[i]
    }
  }
  
  return [2]int{secondLargest, largest}
}