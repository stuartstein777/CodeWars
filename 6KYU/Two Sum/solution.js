function twoSum(numbers, target) {
    const len = numbers.length;
    
    for(var i = 0; i < len-1; i++) {
      for(var j = i + 1; j < len; j++) {
        if(numbers[i] + numbers[j] == target) {
          return [i, j];
        }
      }
    }
    return [];
  }