package kata

func Josephus(items []interface{}, k int) []interface{} {
  
  if len(items) == 0 {
    return []interface{}{}
  }
  i := k - 1
  var res []interface{}

  for {
    if len(items) == 0 {
      break
    }
    
    if i >= len(items) {
      i = i % len(items)
    } else {
      res = append(res, items[i])
      items = append(items[:i], items[i+1:]...)
      if len(items) == 0 {
        break
      }
      i = (i + k-1) % len(items)  
    }
  }
  return res
}