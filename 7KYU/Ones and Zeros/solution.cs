using System;
namespace Solution
{
    class Kata
    {
        public static int binaryArrayToNumber(int[] binaryArray)
        {
           return Convert.ToInt32(string.Join("", binaryArray), 2);
        }
    }
}