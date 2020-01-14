function whatNumberIsIt(n){
  console.log(n);
  var num = Number(n);
  var result = "Input number is Number.";
  
  if(num === Number.MAX_VALUE)
    result += "MAX_VALUE";
  else if(num === Number.MIN_VALUE)
    result += "MIN_VALUE";
  else if(Number.isNaN(num))
    result += "NaN";
  else if(num === Number.NEGATIVE_INFINITY)
    result += "NEGATIVE_INFINITY";
   else if(num === Number.POSITIVE_INFINITY)
     result += "POSITIVE_INFINITY";
   else
     result = `Input number is ${num}`; 
  return result;
}