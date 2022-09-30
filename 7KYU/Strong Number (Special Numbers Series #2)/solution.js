function factorial(n){
    return [...Array(n+1).keys()].slice(1).reduce((acc,i) => acc * i, 1);
  }
  
  function strong(n) {
    var f = String(n).split('').map(Number).reduce((acc, i) => acc + factorial(i), 0);
    return f === n ? "STRONG!!!!" : "Not Strong !!" ;
  }