function isValid(formula){
    console.log(formula);
    if(!formula.includes(7) && !formula.includes(8))
      return false;
    if(formula.includes(1) && formula.includes(2))
      return false;
    if(formula.includes(3) && formula.includes(4))
      return false;
    if(formula.includes(5) && !formula.includes(6))
      return false;
    if(formula.includes(6) && !formula.includes(5))
      return false;
    return true;
}