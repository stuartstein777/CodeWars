def no_odds(values):
    return [x for x in values if x % 2 == 0]if(arr[0] == arr[1] && arr[2] != arr[0]) {
      return arr[2]
  } else if(arr[0] != arr[1] && arr[0] != arr[2]) {
      return arr[0]
  } else if(arr[0] != arr[1] && arr[0] == arr[2]) {
      return arr[1]
  }