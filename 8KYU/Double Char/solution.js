function doubleChar(str) {
  return str.split("").reduce((acc, i) => acc+i.repeat(2), ""); 
}
