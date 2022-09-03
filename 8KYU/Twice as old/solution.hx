class Solution {
    public static function twiceAsOld(dad: Int, son: Int):Int {
      return Std.int(Math.abs(((dad-son) * 2) - dad));
    }
}