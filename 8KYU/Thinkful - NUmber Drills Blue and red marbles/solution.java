public class BlueAndRedMarbles {
    public static double guessBlue(int blueStart, int redStart, int bluePulled, int redPulled) {
        int total = blueStart + redStart;
        int blueRemaining = blueStart - bluePulled;
        return blueRemaining / (double)(total - (bluePulled + redPulled));
    }
}