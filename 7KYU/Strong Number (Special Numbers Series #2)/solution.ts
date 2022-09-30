export const factorial = (n: number): number => [...Array(n+1).keys()].slice(1).reduce((acc: number, i: number) => acc * i, 1);

export const strongNumber = (n: number): string => {
  var f = String(n).split('')
                   .map(Number)
                   .reduce((acc: number, i: number) => acc + factorial(i), 0);
  return f === n ? "STRONG!!!!" : "Not Strong !!" ;
};