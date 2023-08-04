// Return the nth triangular number
export function triangular(n: number): number {
    return n > 0 ? ((n+1) * n) / 2 : 0;
}