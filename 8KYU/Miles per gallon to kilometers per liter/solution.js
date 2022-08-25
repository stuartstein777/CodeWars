function converter (mpg) {
    var kml = (mpg * 1.609344) / 4.54609188;
    
    if(kml % 10 === 0)
      return Number(kml.toFixed(1));
    else
      return Number(kml.toFixed(2));
  }