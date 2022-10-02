class Kata {
  static positiveSum(list) {
     int total = 0
    
     for(int i in list) {
       if(i > 0) {
         total = total + i
       }
     }
     return total
  }
}