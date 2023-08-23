class Solution {
  public static function hanoi(disks: Int): Int {
    return Std.int(Math.pow(2, disks) -1);
  }
}