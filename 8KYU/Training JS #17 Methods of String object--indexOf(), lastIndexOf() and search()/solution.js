function firstToLast(str,c){
  var first = str.indexOf(c);
  var last = str.lastIndexOf(c);
  if(first == -1)
    return -1;
  return last - first;  
}