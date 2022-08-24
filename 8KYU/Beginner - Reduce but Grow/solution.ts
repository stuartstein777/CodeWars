export function grow(arr: number[]): number {
    return arr.reduce((acc, i) => acc * i, 1);
  }