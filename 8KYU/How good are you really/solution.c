int better_than_average(int class_points[], int class_size, int your_points) {
   int total_score = 0;
  
   for(int i=0; i < class_size; i++) {
     total_score += class_points[i];
   }
  
   if(your_points > (total_score / class_size)) {
     return 1;
   }
   return 0;
}