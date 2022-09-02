function whoIsPaying(name){
    if(name.length < 3)
      return [name]
    else
      return [name, name.substring(0, 2)];
}