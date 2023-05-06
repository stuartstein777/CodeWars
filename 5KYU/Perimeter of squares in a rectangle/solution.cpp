typedef unsigned long long ull;
class SumFct
{
  public:
  static ull perimeter(int n)
  {
    ull total = 0;
    ull a = 4;
    ull b = 4;
    
    for(auto i = 0; i <= n; i++ ) {
       total += a;
       auto c = a + b;
       a = b;
       b = c;
    }
    return total;
  }
};