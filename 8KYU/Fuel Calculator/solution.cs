using System;

public class Kata
{
  public static double FuelPrice(double litres, double pricePerLitre)
  {
       var discountPerLitre = Math.Floor(litres / 2.0) * 5;
       if(discountPerLitre > 25)
         discountPerLitre = 25;
       discountPerLitre /= 100;
       return Math.Round((pricePerLitre - discountPerLitre) * litres, 2);
  }
}