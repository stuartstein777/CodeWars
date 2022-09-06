export const iceBrickVolume = (radius: number, bottleLength: number, rimLength: number): number => {
    return ((radius * radius) * (bottleLength - rimLength)) * 2;
}