namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public bool PairOfShoes(int[][] shoes){
          int leftRight = 0;
          int sizes = 0;
          
          foreach(var shoe in shoes)
          {
            if(shoe[0] == 0)
            {
              leftRight++;
              sizes+=shoe[1];
            }
            if(shoe[0] == 1)
            {
              leftRight--;
              sizes-=shoe[1];
            }
          }
          return leftRight == 0 && sizes == 0;
        }
    }
}