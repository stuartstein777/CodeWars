var noIfsNoButs = function (a,b) {
    var x = a < b;
    switch(x){
      case true:
        return a + ' is smaller than ' + b;
      }
    var x = a == b;
    switch(x){
      case true:
        return a + ' is equal to ' + b;
    }
    return a + ' is greater than ' + b;
}