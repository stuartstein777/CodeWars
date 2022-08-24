int sequenceSum(int start, int end, int step)
{
  int result = 0;
  
  for(int i = start; i <= end; i+=step) {
    result += i;
  }
  return result;
}