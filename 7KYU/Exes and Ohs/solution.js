function numberOf(str, c){
  return str.toLowerCase()
            .split('')
            .reduce((r, i) => i === c ? r+=1 : r, 0);
}
function XO(str) {
    var xs = numberOf(str, 'x');
    var os = numberOf(str, 'o');
    return xs === os;
}