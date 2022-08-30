export function average(scores:number[]):number {
    return Math.round(scores.reduce((acc, i) => acc + i, 0) / scores.length)

}