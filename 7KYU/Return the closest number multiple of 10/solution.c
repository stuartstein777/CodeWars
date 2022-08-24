int round_to_10 (int n)
{
  int remainder = n % 10;  
  return remainder < 5 ? n - remainder : n + (10 - remainder);
}