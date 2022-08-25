float guess_blue(int blueStart, int redStart, int bluePulled, int redPulled)
{
    int total = blueStart + redStart;
    int blueRemaining = blueStart - bluePulled;
    return blueRemaining / (float)(total - (bluePulled + redPulled));
}