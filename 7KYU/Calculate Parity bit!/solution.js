function checkParity(parity, bin){
  var isEvenOnes = bin.replace(/0/g, '').length % 2 == 0;
  return (parity === 'even')
    ? isEvenOnes === true ? 0 : 1
    : isEvenOnes === true ? 1 : 0;
}