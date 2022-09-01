function houseNumbersSum(inputArray) {
    var result = 0;
    for(var i = 0; i < inputArray.length; i++) {
      if(inputArray[i] === 0)
        return result;
      result += inputArray[i];
    }
    return result;  
}