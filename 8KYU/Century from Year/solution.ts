export const centuryFromYear = (year: number): number => {
    if(year <= 100)
      return 1;
 
    if(year % 100 == 0)
      return year / 100;
 
    return Math.floor((year / 100) + 1);
}; 