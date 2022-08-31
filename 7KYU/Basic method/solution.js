Array.prototype.max = function() {
    var max = 0;
    for(var i = 0; i < this.length; i++){
      if(Number.isNaN(Number(this[i])))
        return Number.NaN;
      else if(Number(this[i]) > max)
        max = Number(this[i]);
    }
    return max;
}