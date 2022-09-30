module solution;

export bool isValidWalk(char[] walk) 
{
    ulong len = walk.length;
    int ns = 0; int ew = 0;
    
    for(int i = 0; i < len; i++) {
        if(walk[i] == 'n') ns++;
        if(walk[i] == 's') ns--;
        if(walk[i] == 'e') ew++;
        if(walk[i] == 'w') ew--;
    }
    
    return len == 10 && ns == 0 && ew == 0;
}
