class Kata {
    static def guessBlue(blueStart, redStart, bluePulled, redPulled) {
        int total = blueStart + redStart;
        int blueRemaining = blueStart - bluePulled;
        return blueRemaining / (double)(total - (bluePulled + redPulled));
    }
}