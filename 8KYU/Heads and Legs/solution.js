function animals(heads, legs){
    var cows = (legs - (heads * 2)) / 2;
    var chickens = (legs - (cows * 4)) / 2;
    if ((cows % 1 !== 0) || (chickens % 1 !== 0) || cows < 0 || chickens < 0)
      return "No solutions";
    else
      return [chickens, cows];
  }