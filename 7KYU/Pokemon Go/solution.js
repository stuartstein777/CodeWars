function pidgeyCalc ( pidgeys, candy ) {
  
    console.log(pidgeys + " " + candy);
    var xp = 0;
    while((candy >= 12 && pidgeys > 0) || (candy < 12 && pidgeys > 12)) {
      if(candy >= 12 && pidgeys > 0){
        candy -= 12;
        candy += 1;
        xp += 500;
        pidgeys --;
      }
  
      if(candy < 12 && pidgeys > 0) {
        var neededCandy = 12 - candy;
        if(pidgeys > neededCandy){
          candy += neededCandy;
          pidgeys -= neededCandy;
        }
      }
    }
    return xp;  
  }
  
  