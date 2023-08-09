export function hanoi(disks: number): number {
    return Math.pow(2, disks) - 1;
  }