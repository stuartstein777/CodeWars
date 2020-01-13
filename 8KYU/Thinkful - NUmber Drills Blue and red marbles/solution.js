function guessBlue(blueStart, redStart, bluePulled, redPulled) {
  var total = blueStart + redStart;
  var blueRemaining = blueStart - bluePulled;
  return blueRemaining / (total - (bluePulled + redPulled));
}