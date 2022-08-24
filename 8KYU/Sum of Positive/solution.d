module solution;


export int positiveSum(const int[] arr)
{
    int result = 0;
  
    for(int i = 0; i < arr.length; i++){
        if(arr[i] > 0) {
           result += arr[i];
        }
    }
    return result;
}
