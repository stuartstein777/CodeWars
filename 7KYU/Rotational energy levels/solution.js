function rotEnergies(b, jMin, jMax) {
  
    if (b <= 0 || jMin > jMax)
      return [];
    
    var result = [];
    for(var i = jMin; i <= jMax; i++) {
      result.push(b * i * (i+1));
    }
    return result;
}