module solution;

export bool smallEnough(const uint[] arr, uint limit) 
{
    for(uint i = 0; i < arr.length; i++)
    {
        if(arr[i] > limit)
        {
            return false;
        }
            
    }
    return true;
}
