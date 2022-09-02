function roundIt(n){
    var digits = n.toString().split('.');
    if(digits[0].length > digits[1].length)
      return Math.floor(n);
    else if(digits[0].length < digits[1].length)
      return Math.ceil(n);
    return Math.round(n);
}