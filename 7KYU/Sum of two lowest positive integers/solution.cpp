#include <vector>

long sumTwoSmallestNumbers(std::vector<int> numbers)
{
    sort(numbers.begin(), numbers.end());
    long result = (long)numbers[0] + (long)numbers[1]; 
    return result;
}