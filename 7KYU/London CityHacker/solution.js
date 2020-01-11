function londonCityHacker(journey) {
  let consecutiveBuses = 0;
  let cost = 0.0;
  for(let i = 0; i < journey.length; i++) {
    if(isNaN(journey[i])) {
      cost += 2.40;
      consecutiveBuses = 0;
    } else {
      if(consecutiveBuses < 1) {
        cost += 1.50;
        consecutiveBuses++;
      } else {
        consecutiveBuses = 0;
      }
      
    }
  }
  return "£" + cost.toFixed(2);
}