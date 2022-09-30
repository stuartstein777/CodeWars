export function isValidWalk(walk: string[]) {
    let ns: number = 0;
    let ew: number = 0;
    
    for(var i: number = 0; i < walk.length; i++) {
      if(walk[i] == 'n') ns++;
      if(walk[i] == 's') ns--;
      if(walk[i] == 'e') ew++;
      if(walk[i] == 'w') ew--;
    }
    return walk.length == 10 && ns == 0 && ew == 0;
}