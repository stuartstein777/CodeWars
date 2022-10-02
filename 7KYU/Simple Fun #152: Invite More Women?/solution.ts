export function inviteMoreWomen (l: number[]): boolean {
    return l.reduce((acc, i) => acc + i, 0) > 0;  
}