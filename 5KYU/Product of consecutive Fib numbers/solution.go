package kata

func ProductFib(prod uint64) [3]uint64 {
  a := uint64 (0)
  b := uint64(1)
  
  for {
    if prod == a * b {
      return [3]uint64{a, b, 1}
    } else if a * b > prod {
      return [3]uint64{a, b, 0}
    } else {
      t := a
      a = b
      b = t + a
    }
  }
  return [3]uint64{}
}