const reverse = (str) => str.split("").reverse().join("");

function shorter_reverse_longer(a,b){
  return (a.length < b.length)
    ? a + reverse(b) + a
    : b + reverse(a) + b;
}