package kata

func PrevMultOfThree(n int) interface{} { 
  for {
    if n == 0 {
      return nil
    }
    if n % 3 == 0 {
      return n
    }    
    n = n / 10
  }
}