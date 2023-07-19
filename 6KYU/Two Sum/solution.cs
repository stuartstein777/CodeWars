public class Kata
{
  public static int[] TwoSum(int[] numbers, int target)
  {
    for(var i = 0; i < numbers.Length-1; i++) {
      for(var j = i+1; j < numbers.Length; j++) {
        if (numbers[i] + numbers[j] == target) {
          return new int[2]{i, j};
        }
      }
    }
    return new int[0];
  }
}