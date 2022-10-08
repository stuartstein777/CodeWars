#include <string.h>

double arithmetic(double a, double b, const char* operator) {
  if(strcmp(operator, "add")==0){
    return a+b; 
  }
  if(strcmp(operator, "subtract")==0){
    return a-b;
  }
  if(strcmp(operator, "multiply")==0){
    return a*b;
  }
  if(strcmp(operator, "divide")==0){
    return a/b;
    
  }
  
}