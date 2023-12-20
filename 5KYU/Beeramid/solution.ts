export function beeramid(bonus: number, price: number): number {
  let level:number = 0;
  let totalCost:number = 0;
  
  while(totalCost <= bonus) {
    level ++;
    totalCost += level * level * price;
  }
  return level == 0 ? level : level -1;
}