class Kata {
    static def houseNumbersSum(inputArray) {
       int sum = 0;
       
       for(int i = 0; i < inputArray.size(); i++) {
         if(inputArray[i] == 0) {
           return sum;
         } else {
           sum = sum + inputArray[i];
         }
       }
      
       return sum;
    }
}