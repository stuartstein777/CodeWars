module solution;

export uint zeros(uint n) 
{
    uint result = 0;
    for (int i = 5; n / i >= 1; i *= 5)
       result += n / i;
    return result;
}
