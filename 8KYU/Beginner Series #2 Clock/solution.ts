export function past(h: number, m: number, s: number): number {
    return s * 1000 + m * 60000 + h * 3600000;
}