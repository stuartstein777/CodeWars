let linesScores = {1: 40, 2: 100, 3: 300, 4: 1200};

function getScore(arr) {
  var linesCleared = 0;
  var score = 0;
  for(var i = 0; i < arr.length; i++)
  {
    if(arr[i] != 0) {
      var multiplier = ((linesCleared - (linesCleared % 10)) / 10);
      score += (linesScores[arr[i]] + (linesScores[arr[i]] * multiplier));
      linesCleared += arr[i];
    }
  }
  return score;
}