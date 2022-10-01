export const findOdd = (xs: number[]): number => {
    return xs.reduce((acc: number, i: number) => acc ^ i, 0);
};