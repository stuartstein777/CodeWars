function bloodAlcoholContent(drinks, weight, sex, time){
  var a = drinks.ounces * drinks.abv; 
  var r = (sex == "male") ? 0.73 : 0.66; 
  return Number(((a * (5.14 / weight) * r) - (.015 * time)).toFixed(4));
}