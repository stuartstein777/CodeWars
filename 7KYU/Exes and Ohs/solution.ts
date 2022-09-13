export function numberOf(str: string, c: string){
    return str.toLowerCase()
              .split('')
              .reduce((r, i) => i === c ? r+=1 : r, 0);
}
  
  export function xo(str: string) {
    const xs = numberOf(str, 'x');
    const os = numberOf(str, 'o');
    return xs === os;
}