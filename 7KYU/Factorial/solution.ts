export function factorial(n: number) {
    let total = 1;
    for(let i = 1; i <= n; i++)
      total *= i;
    return total;
}