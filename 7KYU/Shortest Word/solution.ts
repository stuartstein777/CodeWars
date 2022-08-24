export function findShort(s: string): number {
    return Math.min(...s.split(' ')
                        .map(c => c.length));
}