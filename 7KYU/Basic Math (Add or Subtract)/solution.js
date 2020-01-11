function calculate(str) {
  let operands = str.match(/[0-9]+/g);
  let operators = str.match(/[a-zA-z]+/g);
  var total = Number(operands[0]);

  for (var i = 1; i < operands.length; i++){
	  if(operators[i-1].toLowerCase() === "plus")
		  total += Number(operands[i]);
    else
		  total -= Number(operands[i]);
  }
  return total.toString();
}