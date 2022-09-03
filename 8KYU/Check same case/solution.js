const isUpperCase = (c) => c.charCodeAt(0) >= 65 && c.charCodeAt(0) <= 90;
const isLowerCase = (c) => c.charCodeAt(0) >= 97 && c.charCodeAt(0) <= 122;

function sameCase(a, b){
  if((isUpperCase(a) && isUpperCase(b)) || (isLowerCase(a) && isLowerCase(b)))
    return 1;
  if((isUpperCase(a) && isLowerCase(b)) || (isUpperCase(b) && isLowerCase(a)))
    return 0;
  return -1;
}