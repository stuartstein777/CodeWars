int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
{
   int height = 0;
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
}