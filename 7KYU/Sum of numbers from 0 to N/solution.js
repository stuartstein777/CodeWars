var SequenceSum = (function() {
    function SequenceSum() {}
  
    SequenceSum.showSequence = function(count) {
      if(count < 0){
        return `${count}<0`;
      } else if (count ===  0) {
        return '0=0';
      } else {
        var res = "0";
        var total = 0;
        for(var i = 1; i <= count; i++){
          res += '+' + i;
          total+=i;
        }
        
        return res + ' = ' + total;
      }
    };
  
    return SequenceSum;
  
})();