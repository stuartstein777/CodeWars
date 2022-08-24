export function oddOrEven(array: number[]) {
    return array.length === 0
       ? "even"
       : (array.reduce((acc, i) => acc + i)) % 2 === 0
            ? "even"
            : "odd";
  }