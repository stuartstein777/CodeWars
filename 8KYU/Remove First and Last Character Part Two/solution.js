function array(arr){
    var split = arr.split(',')
                   .map(x => x.trimLeft().trimRight());
    if(split.length < 3)
      return null;
    return split.slice(1, split.length-1).join(' ');  
  }