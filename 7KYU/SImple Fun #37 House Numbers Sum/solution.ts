export function houseNumbersSum(inputArray: number[]): number {
    let result: number = 0;
    for(var i: number = 0; i < inputArray.length; i++) {
      if(inputArray[i] === 0)
        return result;
      result += inputArray[i];
    }
    return result;  
}