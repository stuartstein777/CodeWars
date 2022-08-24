unsigned sequence_sum(unsigned start, unsigned end, unsigned step)
{
  unsigned result = 0;
  
  for(int i = start; i <= end; i+=step) {
    result += i;
  }
  return result;
}