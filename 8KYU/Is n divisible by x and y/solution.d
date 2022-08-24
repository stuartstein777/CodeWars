module solution;

export bool isDivisible(uint n, uint a, uint b) 
{
    return n % a == 0 && n % b == 0;
}
