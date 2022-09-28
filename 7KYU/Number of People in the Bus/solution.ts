export function number(busStops: [number, number][]): number {
    return busStops.reduce((acc, onoff) => acc + onoff[0] - onoff[1], 0);
}