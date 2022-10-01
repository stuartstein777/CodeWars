export function findDifference(a: [number, number, number], b: [number, number, number]): number{
    return Math.abs(a[0] * a[1] * a[2] - b[0] * b[1] * b[2]);
}