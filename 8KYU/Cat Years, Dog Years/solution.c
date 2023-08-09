typedef struct Human_Cat_Dog_Years {
    unsigned human_years, cat_years, dog_years;
} years;

years human_years_cat_years_dog_years(unsigned human) {

  int dogAge = 0;
  int catAge = 0;
  
  for (unsigned i = 1; i <= human; i++) {
    if(i == 1) {
      dogAge += 15;
      catAge += 15;
    }
    else if(i == 2) {
      dogAge += 9;
      catAge += 9;
    }
    else {
      dogAge += 5;
      catAge += 4;
    }
  }

  struct Human_Cat_Dog_Years res = { .human_years = human, .cat_years = catAge, .dog_years = dogAge };
  
  return res;
}