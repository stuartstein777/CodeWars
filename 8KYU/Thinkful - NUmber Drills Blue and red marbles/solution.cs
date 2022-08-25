public static class BlueAndRedMarbles {
    public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
    {
        var total = blueStart + redStart;
        var blueRemaining = blueStart - bluePulled;
        return blueRemaining / (double)(total - (bluePulled + redPulled));
    }
}