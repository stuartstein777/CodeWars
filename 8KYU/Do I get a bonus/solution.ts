export class Kata {
    public static bonusTime(salary:number, bonus:boolean):string {
      if(bonus)
        return `£${salary*10}`;
      return `£${salary}`;
    }
}