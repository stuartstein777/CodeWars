function golfScoreCalculator(parList, scoreList){
    var pars = parList.split('').map(x => Number.parseInt(x));
    var scores = scoreList.split('').map(x => Number.parseInt(x));
    
    var diffs = scores.map((x, i) => x - pars[i]).reduce((acc, i) => acc+i, 0);
    return diffs;
}