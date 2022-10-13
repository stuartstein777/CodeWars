export function countSheep(num: number): string {
    let res :string = "";
    for(let i:number = 1; i <= num; i++) {
      res += i + " sheep...";
    }
    return res;
}