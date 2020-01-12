class RowSumOddNumbers {
    public static int rowSumOddNumbers(int n) {
        var last = (n * n) + (n - 1);
        var start = last - (2 * (n - 1));
        return ((start + last) / 2) * n;
    }
}