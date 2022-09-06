export function findSmallestInt(args: number[]): number {
    var smallest = args[0];
      
      for(var i = 1; i < args.length; i++){
        if(args[i] < smallest)
          smallest = args[i];
      }
      return smallest;
}