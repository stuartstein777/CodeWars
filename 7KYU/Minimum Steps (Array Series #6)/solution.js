function minimumSteps(numbers, value){
    let sorted = numbers.sort((a, b) => a - b);
    let total = 0;
    for(var i = 0; i < sorted.length; i++) {
      total += sorted[i];
      if(total >= value)
        return i;
    }
  }