function isIntArray(arr) {
  if(Array.isArray(arr) === false)
     return false;
  if(arr.length === 0)
     return true;
     
  for(let i = 0; i < arr.length; i++) {
      if(Number.isInteger(arr[i]) === false)
         return false;
  }
  return true;
}