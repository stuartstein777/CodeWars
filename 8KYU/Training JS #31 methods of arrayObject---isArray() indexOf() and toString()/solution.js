function blackAndWhite(arr){
  var arrayType;
  if(!Array.isArray(arr))
    arrayType = 'fake';
  else if(arr.includes(5) && arr.includes(13))
    arrayType = 'black';
  else
    arrayType = 'white';
  return `It's a ${arrayType} array`; 
}