module solution;

export uint findOdd(const uint[] arr) 
{
    uint x = 0;
    
    for(int i = 0; i < arr.length; i++) {
        x ^= arr[i];
    }
    return x;
}
