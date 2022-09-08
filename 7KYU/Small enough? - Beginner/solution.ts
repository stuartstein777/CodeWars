export function smallEnough(a: number[], limit: number): boolean{
    return Math.max(...a) <= limit;
}