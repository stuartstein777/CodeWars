function pattern(n){
    var output="1";
    if(n < 1)
      return "";
    
    for(var i = 2; i <= n; i++){
      output += "\n" + i.toString().repeat(i);
    }
    return output;
}