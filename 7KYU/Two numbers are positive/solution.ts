export function twoArePositive(a: number, b: number, c: number): boolean {
    return (a > 0 && b > 0 && c <= 0) ||
           (a > 0 && b <= 0 && c > 0) ||
           (a <= 0 && b > 0 && c > 0);
}