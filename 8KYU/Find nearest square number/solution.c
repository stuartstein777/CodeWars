int nearest_sq(int n)
{
  double sq = sqrt(n);
  double f = floor(sq);
  double c = ceil(sq);
  
  int fDiff = abs(n - f * f);
  int cDiff = abs(n - c * c);
  
  if(fDiff > cDiff)
    return c * c;
  
  return f * f;
}