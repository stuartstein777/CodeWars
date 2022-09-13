function evenLast(numbers) {
    if(numbers.length == 0) return 0;
    
    var total = 0;
    
    for(var i = 0; i < numbers.length; i+=2) {
      total += numbers[i];
    }
    
    return total * numbers[numbers.length-1];
}