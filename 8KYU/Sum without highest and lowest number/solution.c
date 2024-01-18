#include<stdio.h>

int sum(int* numbers, int numbersCount)
{
  if(numbersCount == 1) {
    return 0;
  }
  int largest = numbers[0];
  int smallest = numbers[0];
  int total = 0;
  
  for(int i=0; i < numbersCount; i++) {
    printf("%d,", numbers[i]);
    if(numbers[i] < smallest) {
      smallest = numbers[i];
    }
    
    if (numbers[i] > largest) {
      largest = numbers[i];
    }
    total += numbers[i];
  }
  printf("\n");
  
  
  return total - largest - smallest;
}