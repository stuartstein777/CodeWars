export function cubeChecker(volume: number, side: number): boolean{
    return ((side > 0 && volume > 0) && (volume == side * side * side));
} 