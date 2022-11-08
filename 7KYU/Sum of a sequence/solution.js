const sequenceSum = (begin, end, step) => {
    var result = 0;
    
    for(var i = begin; i <= end; i+=step) {
      result += i;
    }
    
    return result;
};