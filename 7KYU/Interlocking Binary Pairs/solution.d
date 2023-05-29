module solution;

export bool interlockable(ulong a, ulong b) 
{
    return (a & b) == 0;
}
