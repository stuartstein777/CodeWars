function evalObject(value){
  console.log(value);
  var result = 0;
  console.log(value.a);
  console.log(value.b);
  switch(value.operation){
    case'+': result = value.a + value.b; break;
    case'-': result = value.a - value.b; break;
    case'/': result = value.a / value.b; break;
    case'*': result = value.a * value.b; break;
    case'%': result = value.a % value.b; break;
    case'^': result = Math.pow(value.a, value.b); break;
  }
  console.log(result);
  return result;
}