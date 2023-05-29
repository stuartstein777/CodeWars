function toAcronym(inp){
    console.log(inp);
    let splits = inp.split(' ');
    var s = "";
    for(var i = 0; i < splits.length; i++) {
      s += splits[i][0].toUpperCase();
    }
    return s;
  }