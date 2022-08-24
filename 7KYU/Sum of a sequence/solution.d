module solution;

export uint sequenceSum(uint start, uint end, uint step) 
{
  uint result = 0;
  
  for(uint i = start; i <= end; i+=step) {
    result += i;
  }
  return result;
}
