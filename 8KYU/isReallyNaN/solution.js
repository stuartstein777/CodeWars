const isReallyNaN = (val) => {
    console.log(val);
    if(val !== undefined)
      return Number.isNaN(val);
    else
      return false;
};