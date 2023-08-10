using System;

namespace Codewars {
  public static class KataChallenge {
    public static bool IsDivisible(params int[] args)
    {
       int fst = args[0];
      
       for(int i = 1; i < args.Length; i++) {
         if(fst % args[i] != 0) {
           return false;
         }
       }
       return true;
    }
  }
}