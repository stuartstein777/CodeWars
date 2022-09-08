module solution;

export ulong factorial(uint n) 
{
    uint res = 1;
    for(uint i = 1; i <= n; i++) {
        res *= i;
    }
        
    return res;
}
