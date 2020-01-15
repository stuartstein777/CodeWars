function numberToPower(number, power){
  // how inefficent can we make exponentiation...
  return "*".repeat(power).split("").reduce((acc, i) => acc*=number, 1);
}