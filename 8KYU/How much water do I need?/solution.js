function howMuchWater(water, load, clothes){
    if(clothes > (2*load)) {
      return "Too much clothes";
    } else if (clothes < load) {
      return "Not enough clothes";
    } else if (clothes > load) {
      
      var waterRequired = water;
      var diff = clothes - load;
      for(var i = 0; i < diff; i++) {
        waterRequired += waterRequired * 0.1;
      }
      return Number(waterRequired.toFixed(2));
      
    } else {
      return water;
    }
}