export function positiveSum(arr:number[]):number {
    return arr.filter(f => f > 0).reduce((acc,i) => acc + i, 0);
  }