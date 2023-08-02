int sumDigits(int n)
{
    int sum = 0;
    while(n != 0)
    {
       sum += (n % 10);
       n /= 10;
    }
    return sum;
}

int lateRide(int n) {
  int hours = n / 60;
   n = n - (hours * 60);
  
   return sumDigits(n) + sumDigits(hours);
}