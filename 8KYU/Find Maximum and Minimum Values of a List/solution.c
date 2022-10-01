int min(int* array, int arrayLength)
{
  int x = array[0];
  
  for(int i = 1; i < arrayLength; i++) {
    if(array[i] < x) {
      x = array[i];
    }
  }
  return x;
}

int max(int* array, int arrayLength)
{
  int x = array[0];
  
  for(int i = 1; i < arrayLength; i++) {
    if(array[i] > x) {
      x = array[i];
    }
  }
  return x;
}