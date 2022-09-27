export class Kata {
    static isVowel(x: string): boolean {
      if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u') {
        return true;
      } 
      return false;
    }
    
    static getCount(str: string): number {
      var cnt = 0;
    
      for(var i = 0; i < str.length; i++) {
         if(Kata.isVowel(str[i]))
            cnt++;
      }
      return cnt;
    }
}