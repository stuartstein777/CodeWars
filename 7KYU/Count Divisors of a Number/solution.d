module solution;

export uint divisors(uint n) 
{
    uint num_divisors = 0;
    for(int i = 1; i <= n; i++) {
      if(n % i == 0)
        num_divisors++;
    }
    return num_divisors;
}
