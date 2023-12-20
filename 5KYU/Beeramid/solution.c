int next_level_cost(int level, double price) {
  return level * level * price;
}

int beeramid(double bonus, double price) {
    double total_cost = 0;
    int level = 0;
    
    do {
      level++;
      total_cost += next_level_cost(level, price);
    } while(total_cost <= bonus);
  
    return level-1;
}