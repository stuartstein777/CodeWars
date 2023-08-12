module solution;

export bool tidyNumber(uint number) 
{
    uint n = number % 10;
    number /= 10;
    
    while(number != 0) {
        uint d = number % 10;
        number /= 10;
        if(d > n)
            return false;
        n = d;        
    }
    return true;
}
