module solution;
import std.stdio;
export uint binaryArrayToNumber(const uint[] arr) 
{
    uint res = 0;
    uint m = 1;
    
    foreach_reverse (e; arr) {
       writeln(e);
       if(e == 1)
           res+=m;
        
       m*=2;
    }
    return res;  
}
