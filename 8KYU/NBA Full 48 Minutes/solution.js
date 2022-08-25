function pointsPer48(ppg, mpg) {
    if(mpg === 0)
       return 0;
    return Number(((48 / mpg) * ppg).toFixed(1));
  }