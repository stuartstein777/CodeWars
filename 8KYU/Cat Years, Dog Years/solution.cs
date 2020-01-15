public class Dinglemouse {

  public static int[] humanYearsCatYearsDogYears(int humanYears) {
    var dogAge = 0;
    var catAge = 0;
    for(int i = 1; i <= humanYears; i++)
    {
      if(i == 1)
      {
        dogAge += 15;
        catAge += 15;
      }
      else if(i == 2)
      {
        dogAge += 9;
        catAge += 9;
      }
      else
      {
        dogAge += 5;
        catAge += 4;
      }
    }
    return new int[]{humanYears, catAge, dogAge};
  }

}