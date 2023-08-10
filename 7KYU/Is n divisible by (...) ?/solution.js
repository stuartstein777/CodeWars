function isDivisible(...args){
    const n = args[0];
    
    for(var i = 1; i < args.length; i++) {
        if(n % args[i] != 0) {
          return false;
        }
    }
    return true;
}