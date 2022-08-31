function sumOfDifferences(arr) {
    if(arr.length < 2)
      return 0;
      
    var sorted = arr.sort((a,b) => b-a);
    var answer = 0;
    for(var i=0; i < sorted.length-1; i++)
      answer += (sorted[i] - sorted[i+1]);
    return answer;
}