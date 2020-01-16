function cookie(x){
  var result = 'Who ate the last cookie? It was '; 
  switch(typeof(x))
  {
    case 'string':
      return result + 'Zach!';
    case 'number':
      return result + 'Monica!';
    default:
      return result + 'the dog!';
  }
}