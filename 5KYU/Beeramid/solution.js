// Returns number of complete beeramid levels
var beeramid = function(bonus, price) {
  level = 0;
  totalCost = 0;
  
  while(totalCost <= bonus) {
    level ++;
    totalCost += level * level * price;
  }
  return level == 0 ? level : level -1;
}