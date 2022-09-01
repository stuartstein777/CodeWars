export function noOdds(values: number[]): number[] {
    return values.filter(f => f % 2 == 0);
}