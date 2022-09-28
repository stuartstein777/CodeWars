int house_numbers_sum(const std::vector<int> &arr)
{
    int sum = 0;
    for(int i = 0; i < arr.size(); i++) {
      if(arr[i] == 0) {
        return sum;
      } else {
        sum += arr[i];
      }
    }
    return 0;
}