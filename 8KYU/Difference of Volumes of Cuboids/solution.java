public class CuboidVolumes {
  public static int findDifference(final int[] a, final int[] b) {
    return Math.abs(a[0] * a[1] * a[2] - b[0] * b[1] * b[2]);
  }
}