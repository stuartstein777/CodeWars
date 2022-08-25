export function collatz(n:number):number{
    var c = 1;  
     while(n != 1){
       c++;
       if(n % 2 == 0)
         n /= 2;
       else
         n = n * 3 + 1;
     }
     return c;
  }