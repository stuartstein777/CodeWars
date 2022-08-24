module solution;

export uint grow(uint[] arr) 
{
    uint total = 1;
    
    for(int i = 0; i < arr.length; i++) {
        total *= arr[i];
    }
    
    return total;
}