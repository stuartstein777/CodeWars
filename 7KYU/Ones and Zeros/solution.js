const binaryArrayToNumber = arr => {
    var res = 0;
    var m = 1;
    for(var i = arr.length-1; i >= 0; i--)
    {
      if(arr[i] == 1)
        res+= m;
        
      m *= 2;
    }
    
    return res;  
  };