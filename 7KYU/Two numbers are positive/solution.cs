namespace Solution {
    public static class Kata {
        public static bool TwoArePositive(int a, int b, int c) {
            return (a > 0 && b > 0 && c <= 0) ||
                   (a > 0 && b <= 0 && c > 0) ||
                   (a <= 0 && b > 0 && c > 0);
        }
    }
}