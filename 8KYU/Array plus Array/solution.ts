export const arrayPlusArray = (arr1 : number[], arr2 : number[]) : number => {
    return arr1.reduce((s, x) => x + s) + arr2.reduce((s, x) => x + s);
}