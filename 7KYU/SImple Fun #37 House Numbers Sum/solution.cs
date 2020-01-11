namespace myjinxin
{
    using System;
    using System.Linq;
    
    public class Kata
    {
        public int HouseNumbersSum(int[] inputArray)
        {
			var total = 0;
			var houses = inputArray.Reverse();
			foreach(var house in houses)
			{
				if(house == 0)
					total = 0;
				else
				total += house;
			}
			return total;
        }
    }
}