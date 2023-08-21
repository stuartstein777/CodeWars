enum outcome { WIN = 1, LOSE = 2};

enum outcome bingo (const int numbers[10])
{
     int hasB =0;
     int hasI = 0;
     int hasN=0;
     int hasG=0;
     int hasO = 0;
     for(int i = 0; i < 10; i++) {
       if(numbers[i] == 2) {
         hasB = 1;
       }
       else if(numbers[i] == 9) {
         hasI = 1;
       }
       else if(numbers[i] == 14) {
         hasN = 1;
       }
       else if(numbers[i] == 7) {
         hasG = 1;
       }
       else if(numbers[i] == 15) {
         hasO = 1;
       }
     }
     if (hasB ==1 && hasI ==1 && hasN ==1 && hasG == 1 && hasO == 1) 
       return WIN;
     return LOSE;
}