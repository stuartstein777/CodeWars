class SmallestIntegerFinder {
    findSmallestInt(args) {
      var smallest = args[0];
      
      for(var i = 1; i < args.length; i++){
        if(args[i] < smallest)
          smallest = args[i];
      }
      return smallest;
    }
}