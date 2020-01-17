function fuelPrice(litres, pricePerLiter) {
  var discountPerLitre = (Math.floor(litres / 2.0)) *5;
  if(discountPerLitre > 25)
    discountPerLitre = 25;
  discountPerLitre /= 100;
  return Number(((pricePerLiter - discountPerLitre) * litres).toFixed(2));  
}