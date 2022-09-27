export function findAverage(array: number[]): number {
    return array.length == 0
           ? 0
           : array.reduce((acc: number, i: number) => acc + i, 0) / array.length;
}