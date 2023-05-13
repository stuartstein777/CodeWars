module solution;

export ulong collatz(ulong n)
{
    ulong c = 1;
    
    while(n != 1) {
        if(n % 2 == 0) {
            n /= 2;
        } else {
            n = n * 3 + 1;
        }
        c++;
    }
    return c;
}
