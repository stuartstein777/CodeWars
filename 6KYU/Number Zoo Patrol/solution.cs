public class Kata
{
  public static int FindNumber(int[] nums)
  {
       var biggest = 0;
       var total = 0;
       for (var i = 0; i < nums.Length; i++)
       {
           if (nums[i] > biggest)
              biggest = nums[i];

           total += nums[i];
        }
        var shouldTotal = biggest * (biggest + 1) / 2;
        if(shouldTotal > total)
          return shouldTotal - total;
        else
          return biggest+1;
  }
}