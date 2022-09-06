module solution;

export int findSmallestInt(const int[] arr) 
{
    int smallest = arr[0];
    
    for(int i = 1; i < arr.length; i++)
    {
        if(arr[i] < smallest)
            smallest = arr[i];
    }
    return smallest;
}
