function addToMapOrIncrement(key, map) {
  if (map.hasOwnProperty(key)) {
    map[key] += 1;
  } else {
    map[key] = 1;
  }
}

const makeChange = (amount) => {
  var result = {};

  while(amount != 0){
    if(amount >= 50){
      addToMapOrIncrement("H", result);
      amount -= 50;
    } else if(amount >= 25){
      addToMapOrIncrement("Q", result);
      amount -= 25;
    } else if(amount >= 10){
      addToMapOrIncrement("D", result);
      amount -= 10;
    } else if(amount >= 5){
      addToMapOrIncrement("N", result);
      amount -= 5;
    } else if(amount >= 1){
      addToMapOrIncrement("P", result);
      amount -= 1;
    }
  }
  return result;
};