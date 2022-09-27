int house_numbers_sum(const int *arr, int count)
{
    int sum = 0;
  
    for(int i = 0; i < count; i++) {
      if(arr[i] == 0)
        return sum;
      else
        sum += arr[i];
    }
    return 0;
}