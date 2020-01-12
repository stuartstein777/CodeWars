namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int GrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
	          var height = 0;
	          int dayCount = 0;
	          while(desiredHeight > height)
	          {
					dayCount++;
		            height += upSpeed;
		            if(height >= desiredHeight)
			            return dayCount;
		            else
			            height -= downSpeed;
	          }
	          return dayCount;
        }
    }
}