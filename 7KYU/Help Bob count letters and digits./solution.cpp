int countLettersAndDigits(std::string input)
{
   unsigned int count = 0;
    for(int i = 0; input[i] != 0; i++){
      if((input[i] >= 'a' && input[i] <= 'z') ||
         (input[i] >= 'A' && input[i] <= 'Z') ||
         (input[i] >= '0' && input[i] <= '9'))
          count++;
    }
    return count;
}