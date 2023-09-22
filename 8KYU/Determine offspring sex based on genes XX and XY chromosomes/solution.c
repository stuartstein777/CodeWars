#include<string.h>

const char *chromosomeCheck(const char chromosomes[2 + 1])
{
   if(strcmp(chromosomes, "XY") == 0 || strcmp(chromosomes, "YX") == 0) {
     return "Congratulations! You're going to have a son.";
   }
	return "Congratulations! You're going to have a daughter.";
}