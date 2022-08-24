module solution;

export uint maxMultiple(uint divisor, uint bound) 
{
  return bound - bound % divisor;    
}
