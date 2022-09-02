const reverse = (str) => str.toString().split("").reverse().join("");

function reverseAndInvert(x){
  if(x < 0)
    return Number(reverse(Math.abs(Math.floor(x))));
  else
    return -Number(reverse(Math.floor(x)));
}


function reverseInvert(array){
  return array.filter(Number.isInteger)
              .map(reverseAndInvert);
}