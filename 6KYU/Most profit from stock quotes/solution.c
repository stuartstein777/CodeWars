#include <stddef.h>
unsigned get_most_profit_from_stock_quotes(const unsigned *quotes, size_t z) {
    unsigned profit = 0;
    unsigned largest = 0;

    for (size_t i = z; i --> 0 ;) {
      if(quotes[i] < largest) {
        profit += largest - quotes[i];
      } else {
        largest = quotes[i];
      }
    }
    return profit;
}