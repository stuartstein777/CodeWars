export function squaresNeeded(grains: number) {
    var cnt = 0;
    
    while(grains > 0){
      grains = Math.floor(grains/2);
      cnt++;
    }
    
    return cnt;
}