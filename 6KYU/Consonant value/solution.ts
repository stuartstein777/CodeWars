export function solve(s: string) {
    let largest = 0;
    let current = 0;
    
    for(let i = 0; i < s.length; i++) {
        let c = s[i];
        if(c === 'a' || c === 'e' || c === 'i' || c === 'o' || c === 'u') {
          if(current > largest) {
            largest = current;
          }
          current = 0;
        } else {
          current += s[i].charCodeAt(0) - 96;
        }
    }
    
    return current > largest ? current : largest;
  }
  