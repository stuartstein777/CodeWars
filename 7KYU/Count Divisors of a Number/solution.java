public class FindDivisor {
  public long numberOfDivisors(int n) {
    int numDivisors = 0;
    for(int i = 1; i <= n; i++) {
      if(n % i == 0){
        numDivisors++;
      }
    }
    return numDivisors;
  }
}