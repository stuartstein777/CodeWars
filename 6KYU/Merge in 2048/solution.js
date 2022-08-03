function slideIntoEmptySlots(line){
    var noZeroes = line.filter(x => x !== 0);
    return noZeroes.concat(Array(line.length - noZeroes.length).fill(0));
  }
  
  function merge(line) {
    console.log(line);
    var linec = slideIntoEmptySlots(line);
    var result = [];
    
    while(linec.length > 0) {
      if(linec[0] === linec[1]) {
        result.push(linec[0] * 2);
        linec = linec.slice(2);
      } else {
        result.push(linec[0])
        linec = linec.slice(1);
      }
    }
    return result.concat(Array(line.length - result.length).fill(0));
  };